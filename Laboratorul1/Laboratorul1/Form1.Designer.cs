﻿namespace Laboratorul1
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
            this.btnResize = new System.Windows.Forms.Button();
            this.numericUpDownScaleFactor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.btnRotate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 293);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadImage.Location = new System.Drawing.Point(5, 10);
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
            this.btnGenerateHistogram.Location = new System.Drawing.Point(5, 54);
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
            this.btnTransformInGrayImage.Location = new System.Drawing.Point(5, 99);
            this.btnTransformInGrayImage.Name = "btnTransformInGrayImage";
            this.btnTransformInGrayImage.Size = new System.Drawing.Size(118, 38);
            this.btnTransformInGrayImage.TabIndex = 4;
            this.btnTransformInGrayImage.Text = "Gray Image";
            this.btnTransformInGrayImage.UseVisualStyleBackColor = false;
            this.btnTransformInGrayImage.Click += new System.EventHandler(this.btnTransformInGrayImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 293);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.panel1.Location = new System.Drawing.Point(784, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 151);
            this.panel1.TabIndex = 13;
            // 
            // btnApplyGamma
            // 
            this.btnApplyGamma.BackColor = System.Drawing.SystemColors.Control;
            this.btnApplyGamma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplyGamma.Location = new System.Drawing.Point(89, 66);
            this.btnApplyGamma.Name = "btnApplyGamma";
            this.btnApplyGamma.Size = new System.Drawing.Size(104, 41);
            this.btnApplyGamma.TabIndex = 14;
            this.btnApplyGamma.Text = "Gamma";
            this.btnApplyGamma.UseVisualStyleBackColor = false;
            this.btnApplyGamma.Click += new System.EventHandler(this.btnApplyGamma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
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
            this.numericUpDownGamma.Location = new System.Drawing.Point(133, 18);
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
            this.comboBoxFilter.Location = new System.Drawing.Point(8, 27);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(147, 28);
            this.comboBoxFilter.TabIndex = 22;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(117, 43);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(106, 36);
            this.btnResize.TabIndex = 24;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // numericUpDownScaleFactor
            // 
            this.numericUpDownScaleFactor.DecimalPlaces = 2;
            this.numericUpDownScaleFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownScaleFactor.Location = new System.Drawing.Point(163, 14);
            this.numericUpDownScaleFactor.Name = "numericUpDownScaleFactor";
            this.numericUpDownScaleFactor.Size = new System.Drawing.Size(67, 26);
            this.numericUpDownScaleFactor.TabIndex = 26;
            this.numericUpDownScaleFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(161, 103);
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(69, 26);
            this.numericUpDownAngle.TabIndex = 27;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(123, 135);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(100, 34);
            this.btnRotate.TabIndex = 25;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericUpDownScaleFactor);
            this.panel2.Controls.Add(this.numericUpDownAngle);
            this.panel2.Controls.Add(this.btnResize);
            this.panel2.Controls.Add(this.btnRotate);
            this.panel2.Location = new System.Drawing.Point(819, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 178);
            this.panel2.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Value of angle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Value of scale factor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Filter:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBoxFilter);
            this.panel3.Location = new System.Drawing.Point(890, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 63);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.numericUpDownGamma);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnApplyGamma);
            this.panel4.Location = new System.Drawing.Point(858, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 110);
            this.panel4.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.btnTransformInGrayImage);
            this.panel5.Controls.Add(this.btnGenerateHistogram);
            this.panel5.Controls.Add(this.btnLoadImage);
            this.panel5.Location = new System.Drawing.Point(406, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 146);
            this.panel5.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1058, 647);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.NumericUpDown numericUpDownScaleFactor;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

