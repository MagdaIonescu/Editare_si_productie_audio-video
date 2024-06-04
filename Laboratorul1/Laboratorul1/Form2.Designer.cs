namespace Laboratorul1
{
    partial class Form2
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
            this.btnLoadVideo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPlayVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApplyTransition = new System.Windows.Forms.Button();
            this.comboBoxTransitions = new System.Windows.Forms.ComboBox();
            this.btnWriteVideo = new System.Windows.Forms.Button();
            this.btnStopVideo = new System.Windows.Forms.Button();
            this.btnLoadBackgroundImage = new System.Windows.Forms.Button();
            this.btnBackgroundSubtraction = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadVideo
            // 
            this.btnLoadVideo.Location = new System.Drawing.Point(25, 47);
            this.btnLoadVideo.Name = "btnLoadVideo";
            this.btnLoadVideo.Size = new System.Drawing.Size(174, 52);
            this.btnLoadVideo.TabIndex = 0;
            this.btnLoadVideo.Text = "LOAD VIDEO";
            this.btnLoadVideo.UseVisualStyleBackColor = true;
            this.btnLoadVideo.Click += new System.EventHandler(this.btnLoadVideo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 594);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btnPlayVideo
            // 
            this.btnPlayVideo.Location = new System.Drawing.Point(25, 103);
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.Size = new System.Drawing.Size(84, 52);
            this.btnPlayVideo.TabIndex = 4;
            this.btnPlayVideo.Text = "PLAY VIDEO";
            this.btnPlayVideo.UseVisualStyleBackColor = true;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.btnApplyTransition);
            this.panel1.Controls.Add(this.comboBoxTransitions);
            this.panel1.Controls.Add(this.btnWriteVideo);
            this.panel1.Controls.Add(this.btnStopVideo);
            this.panel1.Controls.Add(this.btnLoadBackgroundImage);
            this.panel1.Controls.Add(this.btnBackgroundSubtraction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPlayVideo);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnLoadVideo);
            this.panel1.Location = new System.Drawing.Point(828, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 339);
            this.panel1.TabIndex = 6;
            // 
            // btnApplyTransition
            // 
            this.btnApplyTransition.Location = new System.Drawing.Point(205, 279);
            this.btnApplyTransition.Name = "btnApplyTransition";
            this.btnApplyTransition.Size = new System.Drawing.Size(119, 45);
            this.btnApplyTransition.TabIndex = 11;
            this.btnApplyTransition.Text = "Transition";
            this.btnApplyTransition.UseVisualStyleBackColor = true;
            this.btnApplyTransition.Click += new System.EventHandler(this.btnApplyTransition_Click);
            // 
            // comboBoxTransitions
            // 
            this.comboBoxTransitions.FormattingEnabled = true;
            this.comboBoxTransitions.Items.AddRange(new object[] {
            "Abrupt",
            "Cross-Dissolve",
            "Fade to Black/White"});
            this.comboBoxTransitions.Location = new System.Drawing.Point(25, 296);
            this.comboBoxTransitions.Name = "comboBoxTransitions";
            this.comboBoxTransitions.Size = new System.Drawing.Size(174, 28);
            this.comboBoxTransitions.TabIndex = 10;
            // 
            // btnWriteVideo
            // 
            this.btnWriteVideo.Location = new System.Drawing.Point(205, 104);
            this.btnWriteVideo.Name = "btnWriteVideo";
            this.btnWriteVideo.Size = new System.Drawing.Size(84, 51);
            this.btnWriteVideo.TabIndex = 7;
            this.btnWriteVideo.Text = "WRITE VIDEO";
            this.btnWriteVideo.UseVisualStyleBackColor = true;
            this.btnWriteVideo.Click += new System.EventHandler(this.btnWriteVideo_Click);
            // 
            // btnStopVideo
            // 
            this.btnStopVideo.Location = new System.Drawing.Point(115, 104);
            this.btnStopVideo.Name = "btnStopVideo";
            this.btnStopVideo.Size = new System.Drawing.Size(84, 51);
            this.btnStopVideo.TabIndex = 8;
            this.btnStopVideo.Text = "STOP VIDEO";
            this.btnStopVideo.UseVisualStyleBackColor = true;
            this.btnStopVideo.Click += new System.EventHandler(this.btnStopVideo_Click);
            // 
            // btnLoadBackgroundImage
            // 
            this.btnLoadBackgroundImage.Location = new System.Drawing.Point(25, 161);
            this.btnLoadBackgroundImage.Name = "btnLoadBackgroundImage";
            this.btnLoadBackgroundImage.Size = new System.Drawing.Size(299, 50);
            this.btnLoadBackgroundImage.TabIndex = 7;
            this.btnLoadBackgroundImage.Text = "LOAD BACKGROUND IMAGE";
            this.btnLoadBackgroundImage.UseVisualStyleBackColor = true;
            this.btnLoadBackgroundImage.Click += new System.EventHandler(this.btnLoadBackgroundImage_Click);
            // 
            // btnBackgroundSubtraction
            // 
            this.btnBackgroundSubtraction.Location = new System.Drawing.Point(25, 222);
            this.btnBackgroundSubtraction.Name = "btnBackgroundSubtraction";
            this.btnBackgroundSubtraction.Size = new System.Drawing.Size(299, 52);
            this.btnBackgroundSubtraction.TabIndex = 6;
            this.btnBackgroundSubtraction.Text = "BACKGROUND SUBTRACTION";
            this.btnBackgroundSubtraction.UseVisualStyleBackColor = true;
            this.btnBackgroundSubtraction.Click += new System.EventHandler(this.btnBackgroundSubtraction_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.Fuchsia;
            this.btnAudio.Location = new System.Drawing.Point(972, 467);
            this.btnAudio.Margin = new System.Windows.Forms.Padding(6);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Padding = new System.Windows.Forms.Padding(4);
            this.btnAudio.Size = new System.Drawing.Size(234, 59);
            this.btnAudio.TabIndex = 7;
            this.btnAudio.Text = "GO TO AUDIO FORM";
            this.btnAudio.UseVisualStyleBackColor = false;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 635);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "VIDEO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnPlayVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackgroundSubtraction;
        private System.Windows.Forms.Button btnLoadBackgroundImage;
        private System.Windows.Forms.Button btnStopVideo;
        private System.Windows.Forms.Button btnWriteVideo;
        private System.Windows.Forms.Button btnApplyTransition;
        private System.Windows.Forms.ComboBox comboBoxTransitions;
        private System.Windows.Forms.Button btnAudio;
    }
}