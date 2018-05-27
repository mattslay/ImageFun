namespace WindowsFormsApp1
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 500);
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
            this.pictureBox2.Location = new System.Drawing.Point(450, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(615, 511);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(547, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Gaps";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spinnerHorizontalTileCount
            // 
            this.spinnerHorizontalTileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerHorizontalTileCount.Location = new System.Drawing.Point(760, 563);
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
            this.labelHorizontalTileCount.Location = new System.Drawing.Point(757, 547);
            this.labelHorizontalTileCount.Name = "labelHorizontalTileCount";
            this.labelHorizontalTileCount.Size = new System.Drawing.Size(103, 13);
            this.labelHorizontalTileCount.TabIndex = 5;
            this.labelHorizontalTileCount.Text = "Horitontal Tile Count";
            // 
            // lableVerticalTileCount
            // 
            this.lableVerticalTileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lableVerticalTileCount.AutoSize = true;
            this.lableVerticalTileCount.Location = new System.Drawing.Point(882, 547);
            this.lableVerticalTileCount.Name = "lableVerticalTileCount";
            this.lableVerticalTileCount.Size = new System.Drawing.Size(93, 13);
            this.lableVerticalTileCount.TabIndex = 7;
            this.lableVerticalTileCount.Text = "Vertical Tile Count";
            // 
            // spinnerVerticalTileCount
            // 
            this.spinnerVerticalTileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerVerticalTileCount.Location = new System.Drawing.Point(885, 563);
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
            this.labelVerticalTileSpacing.Location = new System.Drawing.Point(882, 603);
            this.labelVerticalTileSpacing.Name = "labelVerticalTileSpacing";
            this.labelVerticalTileSpacing.Size = new System.Drawing.Size(104, 13);
            this.labelVerticalTileSpacing.TabIndex = 11;
            this.labelVerticalTileSpacing.Text = "Vertical Tile Spacing";
            // 
            // spinnerVerticalTileSpacing
            // 
            this.spinnerVerticalTileSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerVerticalTileSpacing.Location = new System.Drawing.Point(885, 619);
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
            this.labelHorizontalTileSpacing.Location = new System.Drawing.Point(757, 603);
            this.labelHorizontalTileSpacing.Name = "labelHorizontalTileSpacing";
            this.labelHorizontalTileSpacing.Size = new System.Drawing.Size(114, 13);
            this.labelHorizontalTileSpacing.TabIndex = 9;
            this.labelHorizontalTileSpacing.Text = "Horitontal Tile Spacing";
            // 
            // spinnerHorizontalTileSpacing
            // 
            this.spinnerHorizontalTileSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinnerHorizontalTileSpacing.Location = new System.Drawing.Point(760, 619);
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
            this.buttonPatch.Location = new System.Drawing.Point(547, 556);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(182, 39);
            this.buttonPatch.TabIndex = 12;
            this.buttonPatch.Text = "Patch Image";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.buttonPatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 658);
            this.Controls.Add(this.buttonPatch);
            this.Controls.Add(this.labelVerticalTileSpacing);
            this.Controls.Add(this.spinnerVerticalTileSpacing);
            this.Controls.Add(this.labelHorizontalTileSpacing);
            this.Controls.Add(this.spinnerHorizontalTileSpacing);
            this.Controls.Add(this.lableVerticalTileCount);
            this.Controls.Add(this.spinnerVerticalTileCount);
            this.Controls.Add(this.labelHorizontalTileCount);
            this.Controls.Add(this.spinnerHorizontalTileCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerVerticalTileSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHorizontalTileSpacing)).EndInit();
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
    }
}

