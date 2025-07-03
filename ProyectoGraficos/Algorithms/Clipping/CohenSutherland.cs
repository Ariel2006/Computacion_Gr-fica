using System;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Clipping
{
    public static class CohenSutherland
    {
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1;    // 0001
        private const int RIGHT = 2;   // 0010
        private const int BOTTOM = 4;  // 0100
        private const int TOP = 8;      // 1000

        private static int ComputeOutCode(Rectangle rect, Point p)
        {
            int code = INSIDE;

            if (p.X < rect.Left) code |= LEFT;
            else if (p.X > rect.Right) code |= RIGHT;
            if (p.Y < rect.Top) code |= TOP;
            else if (p.Y > rect.Bottom) code |= BOTTOM;

            return code;
        }

        public static bool ClipLine(Rectangle rect, ref Point p1, ref Point p2)
        {
            int outcode1 = ComputeOutCode(rect, p1);
            int outcode2 = ComputeOutCode(rect, p2);

            while (true)
            {
                if ((outcode1 | outcode2) == 0) // Ambos puntos dentro
                    return true;

                if ((outcode1 & outcode2) != 0) // Ambos puntos fuera en la misma región
                    return false;

                int outcodeOut = outcode1 != 0 ? outcode1 : outcode2;
                Point p = new Point();

                double x = 0, y = 0;
                if ((outcodeOut & TOP) != 0)
                {
                    x = p1.X + (p2.X - p1.X) * (rect.Top - p1.Y) / (double)(p2.Y - p1.Y);
                    y = rect.Top;
                }
                else if ((outcodeOut & BOTTOM) != 0)
                {
                    x = p1.X + (p2.X - p1.X) * (rect.Bottom - p1.Y) / (double)(p2.Y - p1.Y);
                    y = rect.Bottom;
                }
                else if ((outcodeOut & RIGHT) != 0)
                {
                    y = p1.Y + (p2.Y - p1.Y) * (rect.Right - p1.X) / (double)(p2.X - p1.X);
                    x = rect.Right;
                }
                else if ((outcodeOut & LEFT) != 0)
                {
                    y = p1.Y + (p2.Y - p1.Y) * (rect.Left - p1.X) / (double)(p2.X - p1.X);
                    x = rect.Left;
                }

                p.X = (int)Math.Round(x);
                p.Y = (int)Math.Round(y);

                if (outcodeOut == outcode1)
                {
                    p1 = p;
                    outcode1 = ComputeOutCode(rect, p1);
                }
                else
                {
                    p2 = p;
                    outcode2 = ComputeOutCode(rect, p2);
                }
            }
        }
    }
}