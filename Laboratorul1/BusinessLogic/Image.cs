using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using System.Drawing;

namespace BusinessLogic
{
    public class Image
    {
        public Image<Bgr, Byte> OriginalImage { get;  set; }

        private Image<Bgr, Byte> OriginalCopy { get; set; }
        public Image<Gray, Byte> GrayImage { get;  set; }

        public Image<Bgr, Byte> BrightnessImage { get; private set; }
        public Image(string filename)
        {
            OriginalImage = new Image<Bgr, Byte>(filename);
            OriginalCopy = OriginalImage.Clone();
        }
        public void ConvertToGray()
        {
            GrayImage = OriginalImage.Convert<Gray, Byte>();
        }

        public void AdjustBrightnessContrast(double alpha, int beta)
        {
            BrightnessImage = OriginalImage.Mul(alpha).Add(new Bgr(beta, beta, beta));
        }

        public void ApplyColorFilter(ComboBox comboBox, Rectangle selection = default)
        {
            string selectedFilter = comboBox.SelectedItem.ToString();
            Image<Bgr, Byte> outputImage = OriginalCopy.Clone();
            var data = outputImage.Data; // data - tabloul de pixel

            if (selection != Rectangle.Empty)
            {
                for (int i = selection.Left; i < selection.Right; i++)
                {
                    for (int j = selection.Top; j < selection.Bottom; j++)
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
                }
            }
            else
            {
                for (int i = 0; i < outputImage.Width; i++)
                {
                    for (int j = 0; j < outputImage.Height; j++)
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
                }
            }

            OriginalImage = outputImage;
        }


        public void Rotate(double angle,Bgr color, bool crop)
        {
            OriginalImage =OriginalImage.Rotate(angle,color,crop);
        }
        public void Resize(double scaleFactor,Inter interpolationType)
        {
            OriginalImage = OriginalImage.Resize(scaleFactor, interpolationType);
        }
    }
}
