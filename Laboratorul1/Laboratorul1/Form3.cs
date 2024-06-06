using System;
using System.Windows.Forms;
using BusinessLogic;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Laboratorul1
{
    public partial class Form3 : Form
    {
        private Audio audio;
        public Form3()
        {
            InitializeComponent();
            audio = new Audio();
            audio.PlaybackStopped += OnPlaybackStopped;
        }
       
        private void btnPlayAudio_Click(object sender, EventArgs e)
        {
            string audioPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.mp3";
            audio.PlayAudio(audioPath);
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            MessageBox.Show("Playback stopped");
        }

        private void btnConvertMp3ToWav_Click(object sender, EventArgs e)
        {
            string mp3Path = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.mp3";
            string wavPath = @"C:\Users\Magda\Desktop\An3-sem2\Editare_AudioVideo-laborator\Stuff.wav";
            try
            {
                audio.ConvertMp3ToWav(mp3Path, wavPath);
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
                audio.MixAudio(wavPath1, wavPath2, mixedWavPath);
                MessageBox.Show("Mixarea fisierelor WAV s-a realizat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la mixare: {ex.Message}");
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
                audio.ChangePitch(inputPath, upOneTone, TimeSpan.FromSeconds(5));
                MessageBox.Show("Pitch shifting-ul s-a realizat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la pitch shifting: {ex.Message}");
            }
        }
    }
}
