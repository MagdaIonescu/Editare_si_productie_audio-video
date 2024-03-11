namespace Laboratorul1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnGenerateHistogram = new System.Windows.Forms.Button();
            this.btnTransformInGrayImage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBrightnessContrast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAlpha = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBeta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(45, 32);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(136, 38);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnGenerateHistogram
            // 
            this.btnGenerateHistogram.Location = new System.Drawing.Point(45, 76);
            this.btnGenerateHistogram.Name = "btnGenerateHistogram";
            this.btnGenerateHistogram.Size = new System.Drawing.Size(106, 39);
            this.btnGenerateHistogram.TabIndex = 3;
            this.btnGenerateHistogram.Text = "Histogram";
            this.btnGenerateHistogram.UseVisualStyleBackColor = true;
            this.btnGenerateHistogram.Click += new System.EventHandler(this.btnGenerateHistogram_Click);
            // 
            // btnTransformInGrayImage
            // 
            this.btnTransformInGrayImage.Location = new System.Drawing.Point(45, 121);
            this.btnTransformInGrayImage.Name = "btnTransformInGrayImage";
            this.btnTransformInGrayImage.Size = new System.Drawing.Size(118, 38);
            this.btnTransformInGrayImage.TabIndex = 4;
            this.btnTransformInGrayImage.Text = "Gray Image";
            this.btnTransformInGrayImage.UseVisualStyleBackColor = true;
            this.btnTransformInGrayImage.Click += new System.EventHandler(this.btnTransformInGrayImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(488, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 280);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnBrightnessContrast
            // 
            this.btnBrightnessContrast.Location = new System.Drawing.Point(45, 165);
            this.btnBrightnessContrast.Name = "btnBrightnessContrast";
            this.btnBrightnessContrast.Size = new System.Drawing.Size(118, 38);
            this.btnBrightnessContrast.TabIndex = 8;
            this.btnBrightnessContrast.Text = "Contrast";
            this.btnBrightnessContrast.UseVisualStyleBackColor = true;
            this.btnBrightnessContrast.Click += new System.EventHandler(this.btnBrightnessContrast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Value of alpha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Value of beta:";
            // 
            // numericUpDownAlpha
            // 
            this.numericUpDownAlpha.DecimalPlaces = 1;
            this.numericUpDownAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAlpha.Location = new System.Drawing.Point(840, 48);
            this.numericUpDownAlpha.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(107, 26);
            this.numericUpDownAlpha.TabIndex = 11;
            // 
            // numericUpDownBeta
            // 
            this.numericUpDownBeta.Location = new System.Drawing.Point(841, 93);
            this.numericUpDownBeta.Name = "numericUpDownBeta";
            this.numericUpDownBeta.Size = new System.Drawing.Size(106, 26);
            this.numericUpDownBeta.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1058, 596);
            this.Controls.Add(this.numericUpDownBeta);
            this.Controls.Add(this.numericUpDownAlpha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrightnessContrast);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTransformInGrayImage);
            this.Controls.Add(this.btnGenerateHistogram);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnGenerateHistogram;
        private System.Windows.Forms.Button btnTransformInGrayImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBrightnessContrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAlpha;
        private System.Windows.Forms.NumericUpDown numericUpDownBeta;
    }
}

