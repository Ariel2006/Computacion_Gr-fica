using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Rasterization
{
    public static class BresenhamLine
    {
        public static List<Point> DrawLine(Point start, Point end)
        {
            List<Point> points = new List<Point>();

            int x0 = start.X, y0 = start.Y;
            int x1 = end.X, y1 = end.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                points.Add(new Point(x0, y0));
                if (x0 == x1 && y0 == y1) break;

                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }

            return points;
        }
    }
}