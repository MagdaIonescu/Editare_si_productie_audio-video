using Emgu.CV;
using System;
using System.Windows.Forms;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;


namespace Laboratorul1
{ 
    public partial class Form1 : Form
    {
        private BusinessLogic.Image image;
        Rectangle rect;
        Point StartROI;
        bool MouseDown;

        public Form1()
        { 
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {  
            rect = Rectangle.Empty;
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                image = new BusinessLogic.Image(Openfile.FileName);
                pictureBox1.Image = image.OriginalImage.ToBitmap();
            }
        }

        private void btnGenerateHistogram_Click(object sender, EventArgs e)
        {
            if(image!=null)
            {
                HistogramViewer v = new HistogramViewer();
                Image<Bgr, byte> sectionImage;
                if (rect != Rectangle.Empty)
                {
                    sectionImage = image.OriginalImage.Clone();
                    sectionImage.ROI = rect;
                    v.HistogramCtrl.GenerateHistograms(sectionImage, 255);
                }
                else
                {
                    v.HistogramCtrl.GenerateHistograms(image.OriginalImage, 255);
                }
                    v.Show();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }
        private void btnTransformInGrayImage_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.ConvertToGray();
                pictureBox2.Image = image.GrayImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void btnBrightnessContrast_Click(object sender, EventArgs e)
        {
            double alpha = (double)numericUpDownAlpha.Value;
            int beta = (int)numericUpDownBeta.Value;

            if (image != null)
            {
                var originalCopy = image.OriginalImage.Clone();
                if (rect!=Rectangle.Empty)
                {
                    originalCopy.ROI = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
                    originalCopy._Mul(alpha);
                    originalCopy.Add(new Bgr(beta, beta, beta));
                    originalCopy.ROI = Rectangle.Empty;
                    pictureBox2.Image = originalCopy.ToBitmap();
                }
                else
                {
                    image.AdjustBrightnessContrast(alpha, beta);
                    pictureBox2.Image = image.BrightnessImage.ToBitmap();
                }  
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void btnApplyGamma_Click(object sender, EventArgs e)
        {
            double gamma = (double)numericUpDownGamma.Value;

            if (image != null)
            {
                var originalCopy = image.OriginalImage.Clone();
                Bitmap originalBitmap = originalCopy.ToBitmap();

                if (rect != Rectangle.Empty)
                {
                    originalCopy.ROI = rect;
                    originalCopy._GammaCorrect(gamma);
                    originalCopy.ROI = Rectangle.Empty;
                    pictureBox2.Image = originalCopy.ToBitmap();
                }
                else
                {
                    originalCopy._GammaCorrect(gamma);
                    pictureBox2.Image = originalCopy.ToBitmap();
                }
               }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (image != null)
            {
                if (rect != Rectangle.Empty)
                {
                    image.ApplyColorFilter(comboBoxFilter, rect);
                }
                else
                {
                    image.ApplyColorFilter(comboBoxFilter);
                }
                pictureBox2.Image = image.OriginalImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                double scaleFactor = Convert.ToDouble(numericUpDownScaleFactor.Value);
                Inter interpolationType = Emgu.CV.CvEnum.Inter.Cubic;

                image.Resize(scaleFactor, interpolationType);
                pictureBox2.Image = image.OriginalImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                double angle = Convert.ToDouble(numericUpDownAngle.Value);
                Bgr color = new Bgr(0, 1, 0);
                bool crop = false;

                image.Rotate(angle, color, crop);
                pictureBox2.Image = image.OriginalImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }

            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
                Math.Min(StartROI.Y, e.Y),
                width,
                height);
            Refresh();


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            if (pictureBox1.Image == null || rect == Rectangle.Empty)
            { return; }

            var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();

            pictureBox2.Image = imgROI.ToBitmap();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
