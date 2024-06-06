using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;

namespace BusinessLogic
{
    public class Audio
    {
        private WaveOutEvent outputDevice; // pentru redare audio
        private AudioFileReader audioFile;

        public event EventHandler<StoppedEventArgs> PlaybackStopped;

        public void PlayAudio(string audioPath)
        {
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
            PlaybackStopped?.Invoke(this, args);
        }

        public void ConvertMp3ToWav(string mp3Path, string wavPath)
        {
            using (var reader = new Mp3FileReader(mp3Path))
            {
                WaveFileWriter.CreateWaveFile(wavPath, reader);
            }
        }

        public void MixAudio(string wavPath1, string wavPath2, string mixedWavPath)
        {
            using (var reader1 = new AudioFileReader(wavPath1))
            using (var reader2 = new AudioFileReader(wavPath2))
            {
                reader1.Volume = 0.75f;
                reader2.Volume = 0.75f;

                var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
                WaveFileWriter.CreateWaveFile16(mixedWavPath, mixer);
            }
        }
        public void ChangePitch(string inputPath, float pitchFactor, TimeSpan duration)
        {
            using (var reader = new MediaFoundationReader(inputPath))
            {
                var pitch = new SmbPitchShiftingSampleProvider(reader.ToSampleProvider());
                using (var outputDevice = new WaveOutEvent())
                {
                    pitch.PitchFactor = pitchFactor;
                    outputDevice.Init(pitch.Take(duration));
                    outputDevice.Play();

                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }
        }
    }
}
