using Emgu.CV.CvEnum;
using Emgu.CV;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Laboratorul1
{
    public partial class Form2 : Form
    {
  
        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;
        VideoCapture capture1, capture2;

        private Image<Bgr, Byte> newBackgroundImage;
        private static IBackgroundSubtractor fgDetector;
        private Mat blackImage;
        private Mat whiteImage;

        public Form2()
        {
            InitializeComponent();
        }
        private void btnLoadVideo_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                pictureBox1.Image = m.ToBitmap();

                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;
                numericUpDown1.Value = FrameNo;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = TotalFrame;
            }
        }
        private async void ReadAllFrames()
        {
            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                pictureBox1.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
            }
        }
        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                return;
            }
            IsReadingFrame = true;
            ReadAllFrames();
        }
        private void ProcessFrames(object sender, EventArgs e)
        {
            Mat frame = capture.QueryFrame();
            Image<Bgr, byte> frameImage = frame.ToImage<Bgr, Byte>();

            Mat foregroundMask = new Mat();
            fgDetector.Apply(frame, foregroundMask);
            var foregroundMaskImage = foregroundMask.ToImage<Gray, Byte>();
            foregroundMaskImage = foregroundMaskImage.Not();

            if (newBackgroundImage != null)
            {
                var copyOfNewBackgroundImage = newBackgroundImage.Resize(foregroundMaskImage.Width, foregroundMaskImage.Height, Inter.Lanczos4);
                copyOfNewBackgroundImage = copyOfNewBackgroundImage.Copy(foregroundMaskImage);

                foregroundMaskImage = foregroundMaskImage.Not();
                frameImage = frameImage.Copy(foregroundMaskImage);
                frameImage = frameImage.Or(copyOfNewBackgroundImage);
            }

            pictureBox1.Image = frameImage.ToBitmap();

        }
        private void btnLoadBackgroundImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> background = new Image<Bgr, byte>(ofd.FileName);
                newBackgroundImage = background;
            }
        }
        private void btnStopVideo_Click(object sender, EventArgs e)
        {
            IsReadingFrame = false;
        }

        private void btnWriteVideo_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                MessageBox.Show("Nu a fost încarcat niciun videoclip.");
                return;
            }

            int Fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
            int Width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
            int Height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
            double Fps = capture.Get(CapProp.Fps);
            int TotalFrame = Convert.ToInt32(capture.Get(CapProp.FrameCount));

            string destionpath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\SecondVideo.mp4";
            string logoPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\imagine.jpg";

            try
            {
                using (VideoWriter writer = new VideoWriter(destionpath, Fourcc, Fps, new Size(Width, Height), true))
                {
                    using (Image<Bgr, byte> logo = new Image<Bgr, byte>(logoPath))
                    {
                        if (logo.Width > Width || logo.Height > Height)
                        {
                            MessageBox.Show("Dimensiunile logo-ului sunt prea mari.");
                            return;
                        }

                        Image<Bgr, byte> resizedLogo = logo.Resize(Width / 5, Height / 5, Emgu.CV.CvEnum.Inter.Linear);

                        Mat m = new Mat();
                        int FrameNo = 1;

                        while (FrameNo < TotalFrame)
                        {
                            capture.Read(m);
                            if (m.IsEmpty)
                            {
                                break;
                            }

                            using (Image<Bgr, byte> img = m.ToImage<Bgr, byte>())
                            {
                                img.ROI = new Rectangle(Width - resizedLogo.Width - 30, 10, resizedLogo.Width, resizedLogo.Height);
                                resizedLogo.CopyTo(img);
                                img.ROI = Rectangle.Empty;

                                writer.Write(img.Mat);
                            }

                            FrameNo++;
                        }
                    }
                }

                MessageBox.Show("Procesarea videoclipului a fost facuta cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A aparut o eroare: {ex.Message}");
            }
        }

        private void btnApplyTransition_Click(object sender, EventArgs e)
        {
            string videoPath1 = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Second.mp4";
            string videoPath2 = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\First.mp4";
            string blackImagePath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Black.png";
            string whiteImagePath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\White.png";

            capture1 = new VideoCapture(videoPath1);
            capture2 = new VideoCapture(videoPath2);

            blackImage = new Image<Bgr, byte>(blackImagePath).Mat;
            whiteImage = new Image<Bgr, byte>(whiteImagePath).Mat;


            string transition = comboBoxTransitions.SelectedItem.ToString();

            switch (transition)
            {
                case "Abrupt":
                    ApplyAbruptTransition();
                    break;
                case "Cross-Dissolve":
                    ApplyCrossDissolveTransition();
                    break;
                case "Fade to Black/White":
                    ApplyFadeToBlackTransition();
                    break;
                default:
                    MessageBox.Show("Selecteaza o tranzitie!");
                    break;
            }
        }
        private void btnBackgroundSubtraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (capture != null)
                {
                    fgDetector = new BackgroundSubtractorMOG2();
                    Application.Idle += ProcessFrames;
                }
                else
                {
                    MessageBox.Show("Nu a fost incarcat niciun videoclip.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ApplyAbruptTransition()
        {
            DisplayVideo(capture1, 10);  
            DisplayVideo(capture2, 10);  
        }

        private void ApplyCrossDissolveTransition()
        {
            int transitionFrames = 10;
            Mat m = new Mat();
            Mat nextMat = new Mat();
            double fps = capture1.Get(CapProp.Fps);

            // Display first 10 seconds of the first video
            DisplayVideo(capture1, 10 - transitionFrames / fps);

            capture1.Set(CapProp.PosFrames, (int)(fps * 10) - transitionFrames);

            for (int i = 0; i < transitionFrames; i++)
            {
                capture1.Read(m);
                capture2.Read(nextMat);
                var blendedMat = new Mat();
                CvInvoke.AddWeighted(m, 1.0 - i / (double)transitionFrames, nextMat, i / (double)transitionFrames, 0, blendedMat);
                pictureBox1.Image = blendedMat.ToBitmap();
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(1000 / (int)fps);
            }
            DisplayVideo(capture2, 10 - transitionFrames / fps);
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            Form3 videoForm = new Form3();
            this.Hide();

            videoForm.ShowDialog();
            Show();
        }

        private void ApplyFadeToBlackTransition()
        {
            int transitionFrames = 10;
            Mat m = new Mat();
            double fps1 = capture1.Get(CapProp.Fps);
            double fps2 = capture2.Get(CapProp.Fps);
           
            DisplayVideo(capture1, 10 - transitionFrames / fps1);

            capture1.Set(CapProp.PosFrames, (int)(fps1 * 10) - transitionFrames);

            for (int i = 0; i < transitionFrames; i++)
            {
                capture1.Read(m);
                var blendedMat = new Mat();
                CvInvoke.AddWeighted(m, 1.0 - i / (double)transitionFrames, blackImage, i / (double)transitionFrames, 0, blendedMat);
                pictureBox1.Image = blendedMat.ToBitmap();
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(1000 / (int)fps1);
            }
            
            for (int i = 0; i < transitionFrames; i++)
            {
                capture2.Read(m);
                var blendedMat = new Mat();
                CvInvoke.AddWeighted(whiteImage, 1.0 - i / (double)transitionFrames, m, i / (double)transitionFrames, 0, blendedMat);
                pictureBox1.Image = blendedMat.ToBitmap();
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(1000 / (int)fps2);
            }

            DisplayVideo(capture2, 10 - transitionFrames / fps2);
        }

        private void DisplayVideo(VideoCapture capture, double durationInSeconds)
        {
            Mat m = new Mat();
            double fps = capture.Get(CapProp.Fps);
            int totalFrames = (int)(fps * durationInSeconds);

            for (int i = 0; i < totalFrames; i++)
            {
                capture.Read(m);
                if (m.IsEmpty)
                {
                    break;
                }
                pictureBox1.Image = m.ToBitmap();
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(1000 / (int)fps);
            }
        }
    }
}