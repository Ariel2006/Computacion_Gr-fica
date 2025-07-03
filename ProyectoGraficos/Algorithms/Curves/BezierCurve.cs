using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Curves
{
    public static class BezierCurve
    {
        public static List<Point> Generate(List<Point> controlPoints, int segments = 100)
        {
            List<Point> curve = new List<Point>();

            for (int i = 0; i <= segments; i++)
            {
                double t = i / (double)segments;
                Point p = CalculatePoint(controlPoints, t);
                curve.Add(p);
            }

            return curve;
        }

        private static Point CalculatePoint(List<Point> points, double t)
        {
            if (points.Count == 1)
                return points[0];

            List<Point> newPoints = new List<Point>();
            for (int i = 0; i < points.Count - 1; i++)
            {
                int x = (int)((1 - t) * points[i].X + t * points[i + 1].X);
                int y = (int)((1 - t) * points[i].Y + t * points[i + 1].Y);
                newPoints.Add(new Point(x, y));
            }

            return CalculatePoint(newPoints, t);
        }
    }
}