using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canva
{
    public class Canvas
    {
        Bitmap bitmap;
        public int Width, Height;

        public Canvas(Bitmap bitmap)
        {
            this.bitmap = bitmap;
            Width= bitmap.Width;
            Height= bitmap.Height;
        }

        public void Clear()
        {
            Graphics.FromImage(bitmap).Clear(Color.Black);
            
        }

        public void PutPixel(int x, int y, Color c) 
        {
            bitmap.SetPixel(x, y, c);
        }
    }
}
