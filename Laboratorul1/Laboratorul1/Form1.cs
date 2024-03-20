using Emgu.CV;
using System;
using System.Windows.Forms;
using Emgu.CV.UI;


namespace Laboratorul1
{ 
    public partial class Form1 : Form
    {
        private BusinessLogic.Image image;
        public Form1()
        { 
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
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
                v.HistogramCtrl.GenerateHistograms(image.OriginalImage, 255);
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
            if (image != null)
            {
                double alpha = (double)numericUpDownAlpha.Value;
                int beta = (int)numericUpDownBeta.Value;

                image.AdjustBrightnessContrast(alpha, beta);
                pictureBox2.Image = image.BrightnessImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }

        private void btnApplyGamma_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                double gamma = (double)numericUpDownGamma.Value;

                image.ApplyGamma(gamma);
                pictureBox2.Image = image.OriginalImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(image!=null)
            {
                image.ApplyColorFilter(comboBoxFilter);
                pictureBox2.Image = image.OriginalImage.ToBitmap();
            }
             else
            {
                MessageBox.Show("You have not loaded an image!");
            }
        }
    }
}
