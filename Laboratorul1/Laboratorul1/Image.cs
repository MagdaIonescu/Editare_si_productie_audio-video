using Emgu.CV.Structure;
using Emgu.CV;
using System;

namespace Laboratorul1
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
    }
}
