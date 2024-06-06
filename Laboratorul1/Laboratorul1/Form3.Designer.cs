namespace Laboratorul1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.btnConvertMp3ToWav = new System.Windows.Forms.Button();
            this.btnMixAudio = new System.Windows.Forms.Button();
            this.btnPitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPlayAudio.Location = new System.Drawing.Point(23, 29);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(145, 52);
            this.btnPlayAudio.TabIndex = 0;
            this.btnPlayAudio.Text = "PLAY AUDIO";
            this.btnPlayAudio.UseVisualStyleBackColor = false;
            this.btnPlayAudio.Click += new System.EventHandler(this.btnPlayAudio_Click);
            // 
            // btnConvertMp3ToWav
            // 
            this.btnConvertMp3ToWav.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConvertMp3ToWav.Location = new System.Drawing.Point(23, 87);
            this.btnConvertMp3ToWav.Name = "btnConvertMp3ToWav";
            this.btnConvertMp3ToWav.Size = new System.Drawing.Size(236, 52);
            this.btnConvertMp3ToWav.TabIndex = 1;
            this.btnConvertMp3ToWav.Text = "CONVERT  MP3 TO WAV";
            this.btnConvertMp3ToWav.UseVisualStyleBackColor = false;
            this.btnConvertMp3ToWav.Click += new System.EventHandler(this.btnConvertMp3ToWav_Click);
            // 
            // btnMixAudio
            // 
            this.btnMixAudio.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMixAudio.Location = new System.Drawing.Point(23, 145);
            this.btnMixAudio.Name = "btnMixAudio";
            this.btnMixAudio.Size = new System.Drawing.Size(236, 52);
            this.btnMixAudio.TabIndex = 2;
            this.btnMixAudio.Text = "MIX TWO AUDIO FILE";
            this.btnMixAudio.UseVisualStyleBackColor = false;
            this.btnMixAudio.Click += new System.EventHandler(this.btnMixAudio_Click);
            // 
            // btnPitch
            // 
            this.btnPitch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPitch.Location = new System.Drawing.Point(23, 203);
            this.btnPitch.Name = "btnPitch";
            this.btnPitch.Size = new System.Drawing.Size(180, 52);
            this.btnPitch.TabIndex = 4;
            this.btnPitch.Text = "PITCH";
            this.btnPitch.UseVisualStyleBackColor = false;
            this.btnPitch.Click += new System.EventHandler(this.btnPitch_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(347, 265);
            this.Controls.Add(this.btnPitch);
            this.Controls.Add(this.btnMixAudio);
            this.Controls.Add(this.btnConvertMp3ToWav);
            this.Controls.Add(this.btnPlayAudio);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAudio;
        private System.Windows.Forms.Button btnConvertMp3ToWav;
        private System.Windows.Forms.Button btnMixAudio;
        private System.Windows.Forms.Button btnPitch;
    }
}