using Emgu.CV;
using System;
using System.Windows.Forms;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


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
        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 videoForm = new Form2();
            this.Hide();

            videoForm.ShowDialog();
            Show();
        }

        // ------------------ BLENDING ----------------------
        private async Task BlendImagesSmoothly(string folderPath, double alphaStep)
        {
            string[] fileNames = Directory.GetFiles(folderPath, "*.jpg");
            List<Image<Bgr, byte>> listImages = new List<Image<Bgr, byte>>();

            foreach (var file in fileNames)
            {
                listImages.Add(new Image<Bgr, byte>(file));
            }

            for (int i = 0; i < listImages.Count - 1; i++)
            {
                for (double alpha = 0.0; alpha <= 1.0; alpha += alphaStep)
                {
                    pictureBox1.Image = listImages[i + 1].AddWeighted(listImages[i], alpha, 1 - alpha, 0).ToBitmap();
                    await Task.Delay(25); 
                }
            }
        }
        private async void btnBlendImages_Click_1(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Imagini";
            double alphaStep = 0.01;

            await BlendImagesSmoothly(folderPath, alphaStep);
        }
    }
}
