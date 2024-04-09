using Emgu.CV;
using System;
using System.Windows.Forms;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;


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
            image.GenerateHistogram(new HistogramViewer(), rect);
        }
        private void btnTransformInGrayImage_Click(object sender, EventArgs e)
        {
            image.ConvertToGray(rect);
            pictureBox2.Image = image.ModifiedImage.ToBitmap();
        }

        private void btnBrightnessContrast_Click(object sender, EventArgs e)
        {
            double alpha = (double)numericUpDownAlpha.Value;
            int beta = (int)numericUpDownBeta.Value;

            image.AdjustBrightnessContrast(alpha, beta, rect);
            pictureBox2.Image = image.ModifiedImage.ToBitmap();
        }

        private void btnApplyGamma_Click(object sender, EventArgs e)
        {
            double gamma = (double)numericUpDownGamma.Value;

            image.ApplyGamma(gamma, rect);
            pictureBox2.Image = image.ModifiedImage.ToBitmap();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            image.ApplyColorFilter(comboBoxFilter, rect);
            pictureBox2.Image = image.ModifiedImage.ToBitmap();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                double scaleFactor = Convert.ToDouble(numericUpDownScaleFactor.Value);
                Inter interpolationType = Emgu.CV.CvEnum.Inter.Cubic;

                image.Resize(scaleFactor, interpolationType);
                pictureBox2.Image = image.ModifiedImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(numericUpDownAngle.Value);
            Bgr color = new Bgr(0, 1, 0);
            bool crop = true; // ca sa il incadreze

            image.Rotate(angle, color, crop, rect);
            pictureBox2.Image = image.ModifiedImage.ToBitmap();
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
