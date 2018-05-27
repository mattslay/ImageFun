using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ImageProcessor
    {
        public Image OriginalImage = null;
        public Bitmap ProcessedImage = null;

        public int HorizontalTileCount { get; set; } = 1;
        public int VerticalTileCount { get; set; } = 1;
        public int HorizontalTileSpacing { get; set; } = 10;
        public int VerticalTileSpacing { get; set; } = 10;

        public ImageProcessor()
        {
        }

        public bool LoadImage(string filename)
        {
            bool imageLoaded = false;

            try
            {
                OriginalImage = Image.FromFile(filename);
                imageLoaded = true;
            }
            catch
            {
                imageLoaded = false;
            }

            // Set image rotate by reading orientation data from image
            // https://www.codeproject.com/Tips/724303/Image-Orientation-of-Images-Uploaded-via-ASP-NET-f
            if (OriginalImage.PropertyIdList.Contains(0x0112))
            {
                int rotationValue = OriginalImage.GetPropertyItem(0x0112).Value[0];
                switch (rotationValue)
                {
                    case 1: // landscape, do nothing
                        break;

                    case 8: // rotated 90 right
                            // de-rotate:
                        OriginalImage.RotateFlip(rotateFlipType: RotateFlipType.Rotate270FlipNone);
                        break;

                    case 3: // bottoms up
                        OriginalImage.RotateFlip(rotateFlipType: RotateFlipType.Rotate180FlipNone);
                        break;

                    case 6: // rotated 90 left
                        OriginalImage.RotateFlip(rotateFlipType: RotateFlipType.Rotate90FlipNone);
                        break;
                }
            }

            if (imageLoaded)
                ResetProcessedImage();

            return imageLoaded;
        }


        public void ResetProcessedImage()
        {
            ProcessedImage = new Bitmap(OriginalImage.Width, OriginalImage.Height);
        }

        // https://stackoverflow.com/questions/10210134/using-a-matrix-to-rotate-rectangles-individually
        public void RotateRectangle(Graphics g, Rectangle r, float angle, Brush brush)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                g.Transform = m;
                Pen pen = new Pen(brush);
                //g.DrawRectangle(pen, r);
                g.FillRectangle(brush, r);
                g.ResetTransform();
            }
        }

        // Call this somewhere
        //public void DrawSquare()
        //{
        //    m_Canvas = new Bitmap(100, 100); // Doesn't have to be initialized here

        //    for (int x = 0; x < 100; x += 1)
        //    {
        //        for (int y = 0; y < 100; y += 1)
        //        {
        //            m_Canvas.SetPixel(x, y, Color.Blue);
        //        }
        //    }

        //    SetImage(this.pictureBox1, m_Canvas);
        //}


        //private void CopyImage(Bitmap image)
        //{

        //    for (int x = 0; x < image.Width; x += 2)
        //    {
        //        for (int y = 0; y < image.Height; y += 2)
        //        {
        //            var sourcePixelColor = image.GetPixel(x, y);
        //            Color newPixelColor = ColorExtensions.Darken(sourcePixelColor, (float)(x) / 40);
        //            newImage.SetPixel(x, y, newPixelColor);
        //        }

        //    }

        //    SetImage(pictureBox2, newImage);

        //}

        public void PatchImage()
        {
            var originalBitmap = new Bitmap(OriginalImage);
            Graphics graphics = Graphics.FromImage(ProcessedImage);

            int horizontalTileCount = HorizontalTileCount;
            int verticalTileCount = VerticalTileCount;
            int patchSize = HorizontalTileSpacing;

            //int horizontalTileCount = 100;
            //int verticalTileCount = 100;
            //int patchSize = 20  ;

            double xSampleSpacing = (double) originalBitmap.Width / horizontalTileCount;
            double ySampleSpacing = (double) originalBitmap.Height / verticalTileCount;

            int xStartingOffset = (int)(xSampleSpacing / 2.0);
            int yStartingOffset = (int)(ySampleSpacing / 2.0);

            var random = new Random(6);

            for (int x = 0; x < horizontalTileCount ; x++)
            {
                for (int y = 0; y < verticalTileCount; y++)
                {
                    int xSample = (int) (xStartingOffset + x * xSampleSpacing);
                    int ySample = (int) (yStartingOffset + y * ySampleSpacing);

                    //Color sourcePixelcColor = originalBitmap.GetPixel(xSample, ySample);
                    //Color newPixelColor = sourcePixelcColor.Darken(25);
                    //Color newPixelColor = sourcePixelcColor;

                    var dominantColor = getDominantColor(originalBitmap, xSample, ySample, 10);
                    int patchX = (int) (x * xSampleSpacing);
                    int patchY = (int) (y * ySampleSpacing);

                    SolidBrush brush = new SolidBrush(dominantColor);
                    Rectangle patch = new Rectangle(patchX, patchY, patchSize, patchSize);
                    int rotaionAngle = random.Next();
                    RotateRectangle(graphics, patch, rotaionAngle, brush);
                    //graphics.FillRectangle(brush, patch);
                }
            }

        }

        public void CreateImageWithSpread(int? horizontalTileCount = null,
                                          int? verticalTileCount = null,
                                          int? horizontalTileSpacing = null,
                                          int? verticalTileSpacing = null)
        {
            if (horizontalTileCount != null)
                HorizontalTileCount = (int)horizontalTileCount;

            if (horizontalTileSpacing != null)
                HorizontalTileSpacing = (int)horizontalTileSpacing;

            if (verticalTileCount != null)
                VerticalTileCount = (int)verticalTileCount;

            if (verticalTileSpacing != null)
                VerticalTileSpacing = (int)verticalTileSpacing;

            int newImageWidth = OriginalImage.Width + (HorizontalTileCount - 1) * HorizontalTileSpacing;
            int newImageHeight = OriginalImage.Height + (VerticalTileCount - 1) * VerticalTileSpacing;

            Bitmap newImage = new Bitmap(newImageWidth, newImageHeight);

            Graphics g = Graphics.FromImage(newImage);

            ProcessedImage = newImage;
            int tileWidth = OriginalImage.Width / HorizontalTileCount;
            int tileHeight = OriginalImage.Height / VerticalTileCount;

            int xLoc = 0;
            int yLoc = 0;

            for (int x = 0; x <= HorizontalTileCount; x++)
            {
                for (int y = 0; y <= VerticalTileCount; y++)
                {
                    int xSource = x * tileWidth;
                    int ySource = y * tileHeight;

                    xLoc = xSource + x * HorizontalTileSpacing;
                    yLoc = ySource + y * VerticalTileSpacing;

                    Rectangle sourceRectangle = new Rectangle(xSource, ySource, tileWidth, tileHeight);
                    Rectangle destRectangle = new Rectangle(xLoc, yLoc, tileWidth, tileHeight);

                    g.DrawImage(OriginalImage, destRectangle, sourceRectangle, GraphicsUnit.Pixel);


                }

            }

         

        }

        // https://stackoverflow.com/questions/1068373/how-to-calculate-the-average-rgb-color-values-of-a-bitmap
        public static Color getDominantColor(Bitmap bmp, int xStart, int yStart, int sampleSize)
        {

            //Used for tally
            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            for (int x = xStart; x < xStart + sampleSize; x++)
            {
                for (int y = yStart; y < yStart + sampleSize; y++)
                {
                    Color clr = bmp.GetPixel(Math.Min(x, bmp.Width - 1) , Math.Min(y, bmp.Height - 1));

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    total++;
                }
            }

            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            return Color.FromArgb(r, g, b);
        }


    }
}
