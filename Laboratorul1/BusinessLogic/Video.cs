using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Video
    {
        public delegate void FrameProcessedEventHandler(object sender, Bitmap frame);
        public event FrameProcessedEventHandler FrameProcessed;

        public VideoCapture capture;
        public VideoCapture capture1, capture2;
        public Image<Bgr, byte> newBackgroundImage;
        public IBackgroundSubtractor fgDetector;
        public Mat blackImage;
        public Mat whiteImage;
        public int totalFrames;
        public double fps;
        public int frameNo;
        public bool isReadingFrame;

        public void LoadVideo(string filePath)
        {
            capture = new VideoCapture(filePath);
            totalFrames = (int)capture.Get(CapProp.FrameCount);
            fps = capture.Get(CapProp.Fps);
            frameNo = 1;
        }

        public void LoadBackgroundImage(string filePath)
        {
            newBackgroundImage = new Image<Bgr, byte>(filePath);
        }

        public void LoadBlackWhiteImages(string blackImagePath, string whiteImagePath)
        {
            blackImage = new Image<Bgr, byte>(blackImagePath).Mat;
            whiteImage = new Image<Bgr, byte>(whiteImagePath).Mat;
        }

        public async Task PlayVideo()
        {
            if (capture == null)
                return;

            isReadingFrame = true;
            Mat m = new Mat();
            while (isReadingFrame && frameNo < totalFrames)
            {
                frameNo++;
                capture.Read(m);
                FrameProcessed?.Invoke(this, m.ToBitmap());
                await Task.Delay(1000 / Convert.ToInt32(fps));
            }
        }
        public void WriteVideo(string inputFilePath, string outputFilePath, string logoPath)
        {
            using (VideoCapture capture = new VideoCapture(inputFilePath))
            {
                int fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
                int width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
                int height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
                double fps = capture.Get(CapProp.Fps);
                int totalFrames = Convert.ToInt32(capture.Get(CapProp.FrameCount));

                using (VideoWriter writer = new VideoWriter(outputFilePath, fourcc, fps, new Size(width, height), true))
                {
                    Image<Bgr, byte> logo = new Image<Bgr, byte>(logoPath);
                    Mat m = new Mat();

                    for (int frameNo = 0; frameNo < totalFrames; frameNo++)
                    {
                        capture.Read(m);
                        if (m.IsEmpty)
                            break;

                        Image<Bgr, byte> img = m.ToImage<Bgr, byte>();
                        img.ROI = new Rectangle(width - logo.Width - 30, 10, logo.Width, logo.Height);
                        logo.CopyTo(img);
                        img.ROI = Rectangle.Empty;

                        writer.Write(img.Mat);
                    }
                }
            }
        }
            public void StopVideo()
        {
            isReadingFrame = false;
        }

        public void ProcessFrame()
        {
            if (capture == null)
                return;

            Mat frame = capture.QueryFrame();
            Image<Bgr, byte> frameImage = frame.ToImage<Bgr, byte>();
            Mat foregroundMask = new Mat();
            fgDetector.Apply(frame, foregroundMask);
            var foregroundMaskImage = foregroundMask.ToImage<Gray, byte>().Not();

            if (newBackgroundImage != null)
            {
                var copyOfNewBackgroundImage = newBackgroundImage.Resize(foregroundMaskImage.Width, foregroundMaskImage.Height, Inter.Lanczos4);
                copyOfNewBackgroundImage = copyOfNewBackgroundImage.Copy(foregroundMaskImage);
                foregroundMaskImage = foregroundMaskImage.Not();
                frameImage = frameImage.Copy(foregroundMaskImage);
                frameImage = frameImage.Or(copyOfNewBackgroundImage);
            }

            FrameProcessed?.Invoke(this, frameImage.ToBitmap());
        }

        public void ApplyTransition(string transition, VideoCapture capture1, VideoCapture capture2, double durationInSeconds)
        {
            switch (transition)
            {
                case "Abrupt":
                    DisplayVideo(capture1, durationInSeconds);
                    DisplayVideo(capture2, durationInSeconds);
                    break;
                case "Cross-Dissolve":
                    ApplyCrossDissolveTransition(capture1, capture2, durationInSeconds);
                    break;
                case "Fade to Black/White":
                    ApplyFadeToBlackTransition(capture1, capture2, durationInSeconds);
                    break;
                default:
                    throw new ArgumentException("Invalid transition type");
            }
        }

        private void DisplayVideo(VideoCapture capture, double durationInSeconds)
        {
            Mat m = new Mat();
            double fps = capture.Get(CapProp.Fps);
            int totalFrames = (int)(fps * durationInSeconds);

            for (int i = 0; i < totalFrames; i++)
            {
                capture.Read(m);
                if (m.IsEmpty)
                    break;

                FrameProcessed?.Invoke(this, m.ToBitmap());
                Task.Delay(1000 / Convert.ToInt32(fps)).Wait();
            }
        }

        private void ApplyCrossDissolveTransition(VideoCapture capture1, VideoCapture capture2, double durationInSeconds)
        {
            int transitionFrames = 10;
            Mat m = new Mat();
            Mat nextMat = new Mat();
            double fps = capture1.Get(CapProp.Fps);

            DisplayVideo(capture1, 10 - transitionFrames / fps);

            capture1.Set(CapProp.PosFrames, (int)(fps * 10) - transitionFrames);

            for (int i = 0; i < transitionFrames; i++)
            {
                capture1.Read(m);
                capture2.Read(nextMat);
                var blendedMat = new Mat();
                CvInvoke.AddWeighted(m, 1.0 - i / (double)transitionFrames, nextMat, i / (double)transitionFrames, 0, blendedMat);
                FrameProcessed?.Invoke(this, blendedMat.ToBitmap());
                Task.Delay(1000 / Convert.ToInt32(fps)).Wait();
            }

            DisplayVideo(capture2, 10 - transitionFrames / fps);
        }

        private void ApplyFadeToBlackTransition(VideoCapture capture1, VideoCapture capture2, double durationInSeconds)
        {
            int transitionFrames = 10;
            Mat m = new Mat();
            double fps1 = capture1.Get(CapProp.Fps);
            double fps2 = capture2.Get(CapProp.Fps);

            DisplayVideo(capture1, 10 - transitionFrames / fps1);

            capture1.Set(CapProp.PosFrames, (int)(fps1 * 10) - transitionFrames);

            for (int i = 0; i < transitionFrames; i++)
            {
                capture1.Read(m);
                var blendedMat = new Mat();
                CvInvoke.AddWeighted(m, 1.0 - i / (double)transitionFrames, blackImage, i / (double)transitionFrames, 0, blendedMat);
                FrameProcessed?.Invoke(this, blendedMat.ToBitmap());
                Task.Delay(1000 / Convert.ToInt32(fps1)).Wait();
            }

            for (int i = 0; i < transitionFrames; i++)
            {
                capture2.Read(m);
                var blendedMat = new Mat();
                CvInvoke.AddWeighted(whiteImage, 1.0 - i / (double)transitionFrames, m, i / (double)transitionFrames, 0, blendedMat);
                FrameProcessed?.Invoke(this, blendedMat.ToBitmap());
                Task.Delay(1000 / Convert.ToInt32(fps2)).Wait();
            }

            DisplayVideo(capture2, 10 - transitionFrames / fps2);
        }
    }
}
