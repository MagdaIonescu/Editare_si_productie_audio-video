using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Laboratorul1
{
    public partial class Form2 : Form
    {
        private Video video;

        public Form2()
        {
            InitializeComponent();
            video = new Video();
            video.FrameProcessed += Video_FrameProcessed;
        }

        private void Video_FrameProcessed(object sender, Bitmap frame)
        {
            pictureBox1.Image = frame;
        }

        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                video.LoadVideo(ofd.FileName);
                Mat m = new Mat();
                video.capture.Read(m);
                pictureBox1.Image = m.ToBitmap();

                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = video.totalFrames;
            }
        }

        private async void ReadAllFrames()
        {
            await video.PlayVideo();
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            if (video.capture == null)
            {
                return;
            }
            video.isReadingFrame = true;
            ReadAllFrames();
        }

        private void ProcessFrames(object sender, EventArgs e)
        {
            video.ProcessFrame();
        }

        private void btnLoadBackgroundImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                video.LoadBackgroundImage(ofd.FileName);
            }
        }

        private void btnStopVideo_Click(object sender, EventArgs e)
        {
            video.StopVideo();
        }

        private void btnWriteVideo_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFilePath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\First.mp4";
                string outputFilePath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\SecondVideo.mp4"; 
                string logoPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\imagine.jpg"; 

                video.WriteVideo(inputFilePath, outputFilePath, logoPath);

                MessageBox.Show("Videoclipul a fost scris cu succes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea videoclipului: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplyTransition_Click(object sender, EventArgs e)
        {
            string videoPath1 = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\First.mp4";
            string videoPath2 = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Second.mp4";
            string blackImagePath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Black.png";
            string whiteImagePath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\White.png";

            video.LoadBlackWhiteImages(blackImagePath, whiteImagePath);

            string transition = comboBoxTransitions.SelectedItem.ToString();

            video.ApplyTransition(transition, new VideoCapture(videoPath1), new VideoCapture(videoPath2), 10);
        }

        private void btnBackgroundSubtraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (video.capture != null)
                {
                    video.fgDetector = new BackgroundSubtractorMOG2();
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

        private void btnAudio_Click(object sender, EventArgs e)
        {
            Form3 videoForm = new Form3();
            this.Hide();

            videoForm.ShowDialog();
            Show();
        }
    }
}
