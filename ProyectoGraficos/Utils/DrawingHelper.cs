using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Utils
{
    public static class DrawingHelper
    {
        public static void DrawPoints(Graphics g, List<Point> points, Brush brush = null)
        {
            if (brush == null) brush = Brushes.Black;
            foreach (var p in points)
            {
                g.FillRectangle(brush, p.X, p.Y, 2, 2);
            }
        }
    }
}
