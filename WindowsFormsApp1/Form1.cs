using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ImageProcessor Processor = null;

        public Form1()
        {

            InitializeComponent();

            Processor = new ImageProcessor();
            imageProcessorBindingSource.DataSource = Processor;

            spinnerHorizontalTileCount.DataBindings.Add("Value", Processor, nameof(Processor.HorizontalTileCount));
            spinnerHorizontalTileSpacing.DataBindings.Add("Value", Processor, nameof(Processor.HorizontalTileSpacing));
            spinnerVerticalTileCount.DataBindings.Add("Value", Processor, nameof(Processor.VerticalTileCount));
            spinnerVerticalTileSpacing.DataBindings.Add("Value", Processor, nameof(Processor.VerticalTileSpacing));

        }

        private void SetImage(PictureBox pictureBox, Bitmap image)
        {
            pictureBox.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Processor.LoadImage("C:\\Temp\\TestIris.jpg"))
                pictureBox1.Image = Processor.OriginalImage;

            this.imageProcessorBindingSource.ResetBindings(false);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (Processor.OriginalImage != null)
            {

                Processor.ResetProcessedImage();
                Processor.CreateImageWithSpread();
                pictureBox2.Image = Processor.ProcessedImage;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonPatch_Click(object sender, EventArgs e)
        {
            if (Processor.OriginalImage != null)
            {
                //pictureBox2.Image = null;
                Processor.ResetProcessedImage();
                Processor.MapImage();
                Processor.DrawNewImage();
                pictureBox2.Image = Processor.ProcessedImage;
            }
        }

        private void lblImageWidth_Click(object sender, EventArgs e)
        {

        }

    }


}
