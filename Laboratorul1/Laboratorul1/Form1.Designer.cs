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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApplyGamma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGamma = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).BeginInit();
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
            this.btnLoadImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadImage.Location = new System.Drawing.Point(45, 32);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(136, 38);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnGenerateHistogram
            // 
            this.btnGenerateHistogram.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerateHistogram.Location = new System.Drawing.Point(45, 76);
            this.btnGenerateHistogram.Name = "btnGenerateHistogram";
            this.btnGenerateHistogram.Size = new System.Drawing.Size(106, 39);
            this.btnGenerateHistogram.TabIndex = 3;
            this.btnGenerateHistogram.Text = "Histogram";
            this.btnGenerateHistogram.UseVisualStyleBackColor = false;
            this.btnGenerateHistogram.Click += new System.EventHandler(this.btnGenerateHistogram_Click);
            // 
            // btnTransformInGrayImage
            // 
            this.btnTransformInGrayImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransformInGrayImage.Location = new System.Drawing.Point(45, 121);
            this.btnTransformInGrayImage.Name = "btnTransformInGrayImage";
            this.btnTransformInGrayImage.Size = new System.Drawing.Size(118, 38);
            this.btnTransformInGrayImage.TabIndex = 4;
            this.btnTransformInGrayImage.Text = "Gray Image";
            this.btnTransformInGrayImage.UseVisualStyleBackColor = false;
            this.btnTransformInGrayImage.Click += new System.EventHandler(this.btnTransformInGrayImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(488, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 280);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnBrightnessContrast
            // 
            this.btnBrightnessContrast.Location = new System.Drawing.Point(141, 105);
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
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Value of alpha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
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
            this.numericUpDownAlpha.Location = new System.Drawing.Point(152, 18);
            this.numericUpDownAlpha.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(107, 26);
            this.numericUpDownAlpha.TabIndex = 11;
            // 
            // numericUpDownBeta
            // 
            this.numericUpDownBeta.Location = new System.Drawing.Point(153, 63);
            this.numericUpDownBeta.Name = "numericUpDownBeta";
            this.numericUpDownBeta.Size = new System.Drawing.Size(106, 26);
            this.numericUpDownBeta.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.numericUpDownBeta);
            this.panel1.Controls.Add(this.numericUpDownAlpha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBrightnessContrast);
            this.panel1.Location = new System.Drawing.Point(689, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 158);
            this.panel1.TabIndex = 13;
            // 
            // btnApplyGamma
            // 
            this.btnApplyGamma.BackColor = System.Drawing.SystemColors.Control;
            this.btnApplyGamma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplyGamma.Location = new System.Drawing.Point(928, 203);
            this.btnApplyGamma.Name = "btnApplyGamma";
            this.btnApplyGamma.Size = new System.Drawing.Size(118, 41);
            this.btnApplyGamma.TabIndex = 14;
            this.btnApplyGamma.Text = "Gamma";
            this.btnApplyGamma.UseVisualStyleBackColor = false;
            this.btnApplyGamma.Click += new System.EventHandler(this.btnApplyGamma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Value of gamma:";
            // 
            // numericUpDownGamma
            // 
            this.numericUpDownGamma.DecimalPlaces = 1;
            this.numericUpDownGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGamma.Location = new System.Drawing.Point(855, 211);
            this.numericUpDownGamma.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGamma.Name = "numericUpDownGamma";
            this.numericUpDownGamma.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownGamma.TabIndex = 17;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBoxFilter.Location = new System.Drawing.Point(488, 259);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(147, 28);
            this.comboBoxFilter.TabIndex = 22;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1058, 596);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.numericUpDownGamma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApplyGamma);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApplyGamma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownGamma;
        private System.Windows.Forms.ComboBox comboBoxFilter;
    }
}

