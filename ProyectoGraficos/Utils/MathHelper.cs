using System.Drawing;

namespace ProyectoGraficos.Utils
{
    public static class MathHelper
    {
        public static Point MidPoint(Point a, Point b) => new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2);
    }
}