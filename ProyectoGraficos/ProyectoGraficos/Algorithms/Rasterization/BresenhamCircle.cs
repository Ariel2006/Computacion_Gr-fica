using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Rasterization
{
    public static class BresenhamCircle
    {
        public static List<Point> DrawCircle(Point center, int radius)
        {
            List<Point> points = new List<Point>();
            int x = 0, y = radius;
            int d = 3 - 2 * radius;

            while (x <= y)
            {
                PlotCirclePoints(center, x, y, points);

                if (d < 0)
                    d = d + 4 * x + 6;
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            return points;
        }

        private static void PlotCirclePoints(Point center, int x, int y, List<Point> points)
        {
            points.Add(new Point(center.X + x, center.Y + y));
            points.Add(new Point(center.X - x, center.Y + y));
            points.Add(new Point(center.X + x, center.Y - y));
            points.Add(new Point(center.X - x, center.Y - y));
            points.Add(new Point(center.X + y, center.Y + x));
            points.Add(new Point(center.X - y, center.Y + x));
            points.Add(new Point(center.X + y, center.Y - x));
            points.Add(new Point(center.X - y, center.Y - x));
        }
    }
}