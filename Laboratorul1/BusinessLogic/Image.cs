using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using System.Drawing;
using Emgu.CV.UI;

namespace BusinessLogic
{
    public class Image
    {
        public Image<Bgr, Byte> OriginalImage { get;  set; }
        private Image<Bgr, Byte> OriginalCopy { get; set; }
        public Image<Bgr, Byte> ModifiedImage { get; private set; }
        public Image(string filename)
        {
            OriginalImage = new Image<Bgr, Byte>(filename);
            OriginalCopy = OriginalImage.Clone();
        }
        public void GenerateHistogram(HistogramViewer histogramViewer, Rectangle rect = default)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("No image loaded!");
                return;
            }

            var sectionImage = (rect != Rectangle.Empty) ? OriginalImage.Clone() : OriginalImage;
            sectionImage.ROI = rect;
            histogramViewer.HistogramCtrl.GenerateHistograms(sectionImage, 255);
            histogramViewer.Show();
        }
        public void ConvertToGray(Rectangle rect=default)
        {
            
            if (OriginalImage == null)
            {
                MessageBox.Show("No image loaded!");
                return;
            }

            Image<Bgr, byte> modifiedImage = OriginalImage.Clone();

            if (rect != Rectangle.Empty)
            {
                modifiedImage.ROI = rect;
                Image<Bgr, byte> grayImage = modifiedImage.Copy();
                Image<Gray, byte> image = grayImage.Convert<Gray, byte>();
                grayImage=image.Convert<Bgr, byte>();
                modifiedImage.SetValue(new Bgr(1, 1, 1));
                modifiedImage._Mul(grayImage);
                modifiedImage.ROI = Rectangle.Empty; 
            }
            else
            {
                Image<Gray, byte> gray = modifiedImage.Convert<Gray, byte>();
                modifiedImage = gray.Convert<Bgr, byte>();
            }
            ModifiedImage = modifiedImage;
        }
        public void AdjustBrightnessContrast(double alpha, int beta, Rectangle rect=default)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("No image loaded!");
                return;
            }

            Image<Bgr, byte> modifiedImage = OriginalImage.Clone();

            if (rect != Rectangle.Empty)
            {
                modifiedImage.ROI = rect;
                modifiedImage._Mul(alpha);
                modifiedImage.Add(new Bgr(beta, beta, beta));
                modifiedImage.ROI = Rectangle.Empty;
            }
            else
            {
                modifiedImage._Mul(alpha);
                modifiedImage.Add(new Bgr(beta, beta, beta));
            }

            ModifiedImage= modifiedImage;
        }
        public void ApplyGamma(double gamma, Rectangle rect = default)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("No image loaded!");
                return;
            }

            var originalCopy = OriginalImage.Clone();
            if (rect != Rectangle.Empty)
            {
                originalCopy.ROI = rect;
                originalCopy._GammaCorrect(gamma);
                originalCopy.ROI = Rectangle.Empty;
            }
            else
            {
                originalCopy._GammaCorrect(gamma);
            }

            ModifiedImage = originalCopy;
        }
        public void ApplyColorFilter(ComboBox comboBox, Rectangle rect = default)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("No image loaded!");
                return;
            }

            string selectedFilter = comboBox.SelectedItem.ToString();
            Image<Bgr, Byte> outputImage = OriginalCopy.Clone();
            var data = outputImage.Data; // data - tabloul de pixel

            if (rect != Rectangle.Empty)
            {
                for (int i = rect.Left; i < rect.Right; i++)
                {
                    for (int j = rect.Top; j < rect.Bottom; j++)
                    {
                        ApplyColor(data, selectedFilter, i, j);
                    }
                }
            }
            else
            {
                for (int i = 0; i < outputImage.Width; i++)
                {
                    for (int j = 0; j < outputImage.Height; j++)
                    {
                        ApplyColor(data, selectedFilter,i,j);
                    }
                }
            }
            ModifiedImage = outputImage;
        }
        private void ApplyColor(byte[,,] data, string selectedFilter, int i, int j)
        {
            switch (selectedFilter)
            {
                // pozitia 0 - BLUE , pozitia 1 - VERDE , pozitia 2 - ROSU
                case "Red":
                    data[j, i, 0] = 0;
                    data[j, i, 1] = 0;
                    break;

                case "Blue":
                    data[j, i, 1] = 0;
                    data[j, i, 2] = 0;
                    break;

                case "Green":
                    data[j, i, 0] = 0;
                    data[j, i, 2] = 0;
                    break;
            }
        }
        public void Resize(double scaleFactor,Inter interpolationType)
        {
            ModifiedImage = OriginalImage.Resize(scaleFactor, interpolationType);
        }
        public void Rotate(double angle, Bgr color, bool crop, Rectangle rect = default)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("No image loaded!");
                return;
            }

            var originalCopy = OriginalImage.Clone();

            if (rect != Rectangle.Empty)
            {
                originalCopy.ROI = rect;
                var rotatedSelection = originalCopy.Copy();
                rotatedSelection = rotatedSelection.Rotate(angle, color, crop);
                originalCopy.SetValue(new Bgr(1, 1, 1));
                originalCopy._Mul(rotatedSelection);
                originalCopy.ROI = Rectangle.Empty;
            }
            else
            {
                originalCopy = originalCopy.Rotate(angle, color, crop);
            }

            ModifiedImage = originalCopy;
        }
    }
}
