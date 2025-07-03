using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Clipping
{
    public static class SutherlandHodgman
    {
        public static List<Point> ClipPolygon(List<Point> polygon, Rectangle clipRect)
        {
            List<Point> output = new List<Point>(polygon);

            // Bordes del rectángulo: izquierdo, derecho, inferior, superior
            output = ClipAgainstEdge(output, new Point(clipRect.Left, clipRect.Top), new Point(clipRect.Left, clipRect.Bottom));
            output = ClipAgainstEdge(output, new Point(clipRect.Right, clipRect.Bottom), new Point(clipRect.Right, clipRect.Top));
            output = ClipAgainstEdge(output, new Point(clipRect.Right, clipRect.Bottom), new Point(clipRect.Left, clipRect.Bottom));
            output = ClipAgainstEdge(output, new Point(clipRect.Left, clipRect.Top), new Point(clipRect.Right, clipRect.Top));

            return output;
        }

        private static List<Point> ClipAgainstEdge(List<Point> input, Point edgeStart, Point edgeEnd)
        {
            List<Point> output = new List<Point>();

            for (int i = 0; i < input.Count; i++)
            {
                Point current = input[i];
                Point previous = input[(i + input.Count - 1) % input.Count];

                Point intersection = ComputeIntersection(edgeStart, edgeEnd, previous, current);

                if (IsInside(edgeStart, edgeEnd, current))
                {
                    if (!IsInside(edgeStart, edgeEnd, previous))
                        output.Add(intersection);
                    output.Add(current);
                }
                else if (IsInside(edgeStart, edgeEnd, previous))
                {
                    output.Add(intersection);
                }
            }

            return output;
        }

        private static bool IsInside(Point edgeStart, Point edgeEnd, Point p)
        {
            return (edgeEnd.X - edgeStart.X) * (p.Y - edgeStart.Y) >
                   (edgeEnd.Y - edgeStart.Y) * (p.X - edgeStart.X);
        }

        private static Point ComputeIntersection(Point edgeStart, Point edgeEnd, Point lineStart, Point lineEnd)
        {
            double x1 = edgeStart.X, y1 = edgeStart.Y;
            double x2 = edgeEnd.X, y2 = edgeEnd.Y;
            double x3 = lineStart.X, y3 = lineStart.Y;
            double x4 = lineEnd.X, y4 = lineEnd.Y;

            double denom = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
            if (denom == 0) return lineStart; // Paralelas

            double x = ((x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4)) / denom;
            double y = ((x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4)) / denom;

            return new Point((int)Math.Round(x), (int)Math.Round(y));
        }
    }
}