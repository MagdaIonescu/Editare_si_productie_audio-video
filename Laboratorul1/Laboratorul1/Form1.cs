using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Emgu.CV.UI;


namespace Laboratorul1
{ 
    public partial class Form1 : Form
    {
        private Image image;
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
                image = new Image(Openfile.FileName);
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
        }

        private void btnTransformInGrayImage_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.ConvertToGray();
                pictureBox2.Image = image.GrayImage.ToBitmap();
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

    }
}
