using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Rasterization
{
    public static class BresenhamEllipse
    {
        public static List<Point> DrawEllipse(Point center, int rx, int ry)
        {
            List<Point> points = new List<Point>();
            int x = 0, y = ry;
            long rx2 = rx * rx;
            long ry2 = ry * ry;
            long twoRx2 = 2 * rx2;
            long twoRy2 = 2 * ry2;
            long p;
            long px = 0, py = twoRx2 * y;

            // Región 1
            p = (long)(ry2 - (rx2 * ry) + (0.25 * rx2));
            while (px < py)
            {
                PlotEllipsePoints(center, x, y, points);
                x++;
                px += twoRy2;
                if (p < 0)
                    p += ry2 + px;
                else
                {
                    y--;
                    py -= twoRx2;
                    p += ry2 + px - py;
                }
            }

            // Región 2
            p = (long)(ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2);
            while (y >= 0)
            {
                PlotEllipsePoints(center, x, y, points);
                y--;
                py -= twoRx2;
                if (p > 0)
                    p += rx2 - py;
                else
                {
                    x++;
                    px += twoRy2;
                    p += rx2 - py + px;
                }
            }

            return points;
        }

        private static void PlotEllipsePoints(Point center, int x, int y, List<Point> points)
        {
            points.Add(new Point(center.X + x, center.Y + y));
            points.Add(new Point(center.X - x, center.Y + y));
            points.Add(new Point(center.X + x, center.Y - y));
            points.Add(new Point(center.X - x, center.Y - y));
        }
    }
}