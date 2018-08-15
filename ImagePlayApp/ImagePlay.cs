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
    public partial class ImagePlay : Form
    {
        ImagePlayProcessor Processor = null;

        public ImagePlay()
        {
            InitializeComponent();

            Processor = new ImagePlayProcessor();
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
            ChooseImage chooseImage = new ChooseImage();
            chooseImage.ShowDialog();
            ChooseImage.ImageChoices imageChoice = chooseImage.ImageChoice;

            string imageRootPath = "";
            string imageFile = "";

            if (imageChoice == ChooseImage.ImageChoices.SampleImage)
            {
                imageRootPath = "C:\\Temp\\";
                imageFile = "TestIris.jpg";
                // imageFile = "Test_Lines.png";
            }
            else if(imageChoice == ChooseImage.ImageChoices.SelectImage)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.ShowDialog();
                imageRootPath = fileDialog.FileName;

                if (string.IsNullOrWhiteSpace(imageRootPath))
                    return;
            }
            else
                return;

            if (Processor.LoadImage(imageRootPath + imageFile))
                pictureBox1.Image = Processor.OriginalImage;

            this.imageProcessorBindingSource.ResetBindings(false);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (Processor.OriginalImage != null)
            {

                Processor.ResetProcessedImage();
                Processor.DrawImageWithSpread();
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
                Processor.DrawPatchedImage();
                pictureBox2.Image = Processor.ProcessedImage;
            }
        }

        private void lblImageWidth_Click(object sender, EventArgs e)
        {

        }
    }


}
