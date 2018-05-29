using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ImageMapDataPoint
    {
        public int x;
        public int y;
        public Color color;

        public ImageMapDataPoint(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}
