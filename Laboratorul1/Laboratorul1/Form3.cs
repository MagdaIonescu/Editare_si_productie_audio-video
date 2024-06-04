using System;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Laboratorul1
{
    public partial class Form3 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPlayAudio_Click(object sender, EventArgs e)
        {
            string audioPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.mp3";

            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(audioPath);
                outputDevice.Init(audioFile);
            }

            outputDevice.Play();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        private void btnConvertMp3ToWav_Click(object sender, EventArgs e)
        {
            string mp3Path = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.mp3";
            string wavPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.wav";

            try
            {
                using (var reader = new Mp3FileReader(mp3Path))
                {
                    WaveFileWriter.CreateWaveFile(wavPath, reader);
                }

                MessageBox.Show("Conversia MP3 în WAV s-a realizat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la conversie: {ex.Message}");
            }
        }

        private void btnMixAudio_Click(object sender, EventArgs e)
        {
            string wavPath1 = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.wav";
            string wavPath2 = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\File2.wav";
            string mixedWavPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\mixed.wav";

            try
            {
                using (var reader1 = new AudioFileReader(wavPath1))
                using (var reader2 = new AudioFileReader(wavPath2))
                {
                    reader1.Volume = 0.75f; 
                    reader2.Volume = 0.75f;

                    var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
                    WaveFileWriter.CreateWaveFile16(mixedWavPath, mixer);
                }

                MessageBox.Show("Mixarea fisierelor WAV s-a realizat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la mixare: {ex.Message}");
            }
        }

        private void btnTrimming_Click(object sender, EventArgs e)
        {
            string inputPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Hollidays.wav";
            string outputPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\HollidaysTrimm.wav";
            TimeSpan cutFromStart = TimeSpan.FromSeconds(5); 
            TimeSpan cutFromEnd = TimeSpan.FromSeconds(5);   

            try
            {
                TrimWavFile(inputPath, outputPath, cutFromStart, cutFromEnd);
                MessageBox.Show("Taierea fisierului WAV s-a realizat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la taiere: {ex.Message}");
            }
        }

        public static void TrimWavFile(string inPath, string outPath, TimeSpan cutFromStart, TimeSpan cutFromEnd)
        {
            using (WaveFileReader reader = new WaveFileReader(inPath))
            {
                using (WaveFileWriter writer = new WaveFileWriter(outPath, reader.WaveFormat))
                {
                    int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;

                    int startPos = (int)cutFromStart.TotalMilliseconds * bytesPerMillisecond;
                    startPos = startPos - startPos % reader.WaveFormat.BlockAlign;

                    int endBytes = (int)cutFromEnd.TotalMilliseconds * bytesPerMillisecond;
                    endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;
                    int endPos = (int)reader.Length - endBytes;

                    TrimWavFile(reader, writer, startPos, endPos);
                }
            }
        }

        private static void TrimWavFile(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
        {
            reader.Position = startPos;
            byte[] buffer = new byte[1024];
            while (reader.Position < endPos)
            {
                int bytesRequired = (int)(endPos - reader.Position);
                if (bytesRequired > 0)
                {
                    int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                    int bytesRead = reader.Read(buffer, 0, bytesToRead);
                    if (bytesRead > 0)
                    {
                        writer.WriteData(buffer, 0, bytesRead);
                    }
                }
            }
        }

        private void btnPitch_Click(object sender, EventArgs e)
        {
            string inputPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.mp3";
            float semitone = (float)Math.Pow(2, 1.0 / 12.0); 
            float upOneTone = semitone * semitone;
            float downOneTone = 1.0f / upOneTone;

            try
            {
                using (var reader = new MediaFoundationReader(inputPath))
                {
                    var pitch = new SmbPitchShiftingSampleProvider(reader.ToSampleProvider());
                    using (var outputDevice = new WaveOutEvent())
                    {
                        pitch.PitchFactor = upOneTone; 
                        outputDevice.Init(pitch.Take(TimeSpan.FromSeconds(5))); 
                        outputDevice.Play();

                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(500);
                        }
                    }
                }

                MessageBox.Show("Pitch shifting-ul s-a realizat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la pitch shifting: {ex.Message}");
            }
        }
    }
}
