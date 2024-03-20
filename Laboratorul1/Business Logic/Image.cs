using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Windows.Forms;

namespace Business_Logic
{
    public class Image
    {
        public Image<Bgr, Byte> OriginalImage { get; private set; }
        public Image<Gray, Byte> GrayImage { get; private set; }

        public Image<Bgr, Byte> BrightnessImage { get; private set; }
        public Image(string filename)
        {
            OriginalImage = new Image<Bgr, Byte>(filename);
        }

        public void ConvertToGray()
        {
            GrayImage = OriginalImage.Convert<Gray, Byte>();
        }

        public void AdjustBrightnessContrast(double alpha, int beta)
        {
            BrightnessImage = OriginalImage.Mul(alpha).Add(new Bgr(beta, beta, beta));
        }

        public void ApplyGamma(double gamma)
        {
            OriginalImage._GammaCorrect(gamma);
        }

        public void ApplyColorFilter(ComboBox comboBox)
        {
            string selectedFilter = comboBox.SelectedItem.ToString();
            Image<Bgr, Byte> outputImage = new Image<Bgr, byte>(OriginalImage.Size);
            OriginalImage.CopyTo(outputImage);
            var data = outputImage.Data; // data - tabloul de pixel
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    switch(selectedFilter)
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
            }
            OriginalImage = outputImage;
        }
    }
}
