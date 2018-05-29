namespace WindowsFormsApp1
{
    partial class ImagePlay
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.spinnerHorizontalTileCount = new System.Windows.Forms.NumericUpDown();
            this.labelHorizontalTileCount = new System.Windows.Forms.Label();
            this.lableVerticalTileCount = new System.Windows.Forms.Label();
            this.spinnerVerticalTileCount = new System.Windows.Forms.NumericUpDown();
            this.labelVerticalTileSpacing = new System.Windows.Forms.Label();
            this.spinnerVerticalTileSpacing = new System.Windows.Forms.NumericUpDown();
            this.labelHorizontalTileSpacing = new System.Windows.Forms.Label();
            this.spinnerHorizontalTileSpacing = new System.Windows.Forms.NumericUpDown();
            this.buttonPatch = new System.Windows.Forms.Button();
            this.lblImageWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageProcessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileSpacing)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProcessorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(25, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(524, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(16, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Draw Image with Gaps";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spinnerHorizontalTileCount
            // 
            this.spinnerHorizontalTileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerHorizontalTileCount.Location = new System.Drawing.Point(704, 505);
            this.spinnerHorizontalTileCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinnerHorizontalTileCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerHorizontalTileCount.Name = "spinnerHorizontalTileCount";
            this.spinnerHorizontalTileCount.Size = new System.Drawing.Size(85, 20);
            this.spinnerHorizontalTileCount.TabIndex = 4;
            this.spinnerHorizontalTileCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerHorizontalTileCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelHorizontalTileCount
            // 
            this.labelHorizontalTileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHorizontalTileCount.AutoSize = true;
            this.labelHorizontalTileCount.Location = new System.Drawing.Point(701, 489);
            this.labelHorizontalTileCount.Name = "labelHorizontalTileCount";
            this.labelHorizontalTileCount.Size = new System.Drawing.Size(103, 13);
            this.labelHorizontalTileCount.TabIndex = 5;
            this.labelHorizontalTileCount.Text = "Horitontal Tile Count";
            // 
            // lableVerticalTileCount
            // 
            this.lableVerticalTileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lableVerticalTileCount.AutoSize = true;
            this.lableVerticalTileCount.Location = new System.Drawing.Point(826, 489);
            this.lableVerticalTileCount.Name = "lableVerticalTileCount";
            this.lableVerticalTileCount.Size = new System.Drawing.Size(93, 13);
            this.lableVerticalTileCount.TabIndex = 7;
            this.lableVerticalTileCount.Text = "Vertical Tile Count";
            // 
            // spinnerVerticalTileCount
            // 
            this.spinnerVerticalTileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerVerticalTileCount.Location = new System.Drawing.Point(829, 505);
            this.spinnerVerticalTileCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinnerVerticalTileCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerVerticalTileCount.Name = "spinnerVerticalTileCount";
            this.spinnerVerticalTileCount.Size = new System.Drawing.Size(85, 20);
            this.spinnerVerticalTileCount.TabIndex = 6;
            this.spinnerVerticalTileCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelVerticalTileSpacing
            // 
            this.labelVerticalTileSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVerticalTileSpacing.AutoSize = true;
            this.labelVerticalTileSpacing.Location = new System.Drawing.Point(313, 3);
            this.labelVerticalTileSpacing.Name = "labelVerticalTileSpacing";
            this.labelVerticalTileSpacing.Size = new System.Drawing.Size(104, 13);
            this.labelVerticalTileSpacing.TabIndex = 11;
            this.labelVerticalTileSpacing.Text = "Vertical Tile Spacing";
            // 
            // spinnerVerticalTileSpacing
            // 
            this.spinnerVerticalTileSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerVerticalTileSpacing.Location = new System.Drawing.Point(316, 19);
            this.spinnerVerticalTileSpacing.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinnerVerticalTileSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerVerticalTileSpacing.Name = "spinnerVerticalTileSpacing";
            this.spinnerVerticalTileSpacing.Size = new System.Drawing.Size(85, 20);
            this.spinnerVerticalTileSpacing.TabIndex = 10;
            this.spinnerVerticalTileSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHorizontalTileSpacing
            // 
            this.labelHorizontalTileSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHorizontalTileSpacing.AutoSize = true;
            this.labelHorizontalTileSpacing.Location = new System.Drawing.Point(188, 3);
            this.labelHorizontalTileSpacing.Name = "labelHorizontalTileSpacing";
            this.labelHorizontalTileSpacing.Size = new System.Drawing.Size(114, 13);
            this.labelHorizontalTileSpacing.TabIndex = 9;
            this.labelHorizontalTileSpacing.Text = "Horitontal Tile Spacing";
            // 
            // spinnerHorizontalTileSpacing
            // 
            this.spinnerHorizontalTileSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerHorizontalTileSpacing.Location = new System.Drawing.Point(191, 19);
            this.spinnerHorizontalTileSpacing.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinnerHorizontalTileSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerHorizontalTileSpacing.Name = "spinnerHorizontalTileSpacing";
            this.spinnerHorizontalTileSpacing.Size = new System.Drawing.Size(85, 20);
            this.spinnerHorizontalTileSpacing.TabIndex = 8;
            this.spinnerHorizontalTileSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPatch
            // 
            this.buttonPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPatch.Location = new System.Drawing.Point(11, 11);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(149, 27);
            this.buttonPatch.TabIndex = 12;
            this.buttonPatch.Text = "Draw Image with Patches";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.buttonPatch_Click);
            // 
            // lblImageWidth
            // 
            this.lblImageWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImageWidth.AutoSize = true;
            this.lblImageWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageProcessorBindingSource, "ImageWidth", true));
            this.lblImageWidth.Location = new System.Drawing.Point(293, 604);
            this.lblImageWidth.Name = "lblImageWidth";
            this.lblImageWidth.Size = new System.Drawing.Size(35, 13);
            this.lblImageWidth.TabIndex = 13;
            this.lblImageWidth.Text = "label1";
            this.lblImageWidth.Click += new System.EventHandler(this.lblImageWidth_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageProcessorBindingSource, "ImageHeight", true));
            this.label2.Location = new System.Drawing.Point(296, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Image Width";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Image Height";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPatch);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(513, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 53);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Patch Size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.imageProcessorBindingSource, "PatchSize", true));
            this.numericUpDown1.Location = new System.Drawing.Point(191, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.spinnerHorizontalTileSpacing);
            this.panel2.Controls.Add(this.labelHorizontalTileSpacing);
            this.panel2.Controls.Add(this.spinnerVerticalTileSpacing);
            this.panel2.Controls.Add(this.labelVerticalTileSpacing);
            this.panel2.Location = new System.Drawing.Point(513, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 60);
            this.panel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Original Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rendered Image";
            // 
            // imageProcessorBindingSource
            // 
            this.imageProcessorBindingSource.DataSource = typeof(WindowsFormsApp1.ImagePlayProcessor);
            // 
            // ImagePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 658);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblImageWidth);
            this.Controls.Add(this.lableVerticalTileCount);
            this.Controls.Add(this.spinnerVerticalTileCount);
            this.Controls.Add(this.labelHorizontalTileCount);
            this.Controls.Add(this.spinnerHorizontalTileCount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImagePlay";
            this.Text = "ImagePlayForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileSpacing)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProcessorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown spinnerHorizontalTileCount;
        private System.Windows.Forms.Label labelHorizontalTileCount;
        private System.Windows.Forms.Label lableVerticalTileCount;
        private System.Windows.Forms.NumericUpDown spinnerVerticalTileCount;
        private System.Windows.Forms.Label labelVerticalTileSpacing;
        private System.Windows.Forms.NumericUpDown spinnerVerticalTileSpacing;
        private System.Windows.Forms.Label labelHorizontalTileSpacing;
        private System.Windows.Forms.NumericUpDown spinnerHorizontalTileSpacing;
        private System.Windows.Forms.Button buttonPatch;
        private System.Windows.Forms.Label lblImageWidth;
        private System.Windows.Forms.BindingSource imageProcessorBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

