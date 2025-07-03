using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Fill
{
    public static class FloodFill
    {
        public static void Fill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            if (targetColor.ToArgb() == replacementColor.ToArgb())
                return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(pt);
            int width = bmp.Width;
            int height = bmp.Height;

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();

                if (a.X <= 0 || a.X >= width - 1 || a.Y <= 0 || a.Y >= height - 1)
                    continue;

                if (bmp.GetPixel(a.X, a.Y).ToArgb() != targetColor.ToArgb())
                    continue;

                bmp.SetPixel(a.X, a.Y, replacementColor);

                pixels.Push(new Point(a.X - 1, a.Y));
                pixels.Push(new Point(a.X + 1, a.Y));
                pixels.Push(new Point(a.X, a.Y - 1));
                pixels.Push(new Point(a.X, a.Y + 1));
            }
        }
    }
}