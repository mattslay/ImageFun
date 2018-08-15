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
    public partial class ChooseImage : Form
    {
        public enum ImageChoices { SelectImage, SampleImage, Cancel }
        public ImageChoices ImageChoice;

        public ChooseImage()
        {
            InitializeComponent();
            this.ImageChoice = ImageChoices.Cancel;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.ImageChoice = ImageChoices.Cancel;
            this.Close();
        }

        private void useSample_Click(object sender, EventArgs e)
        {
            this.ImageChoice = ImageChoices.SampleImage;
            this.Close();
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            this.ImageChoice = ImageChoices.SelectImage;
            this.Close();
        }
    }
}
