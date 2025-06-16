using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectPaint.Algorithms
{
    /// <summary>
    /// Implementación del algoritmo de Bresenham para dibujo de círculos
    /// </summary>
    public static class BresenhamCircleAlgorithm
    {
        /// <summary>
        /// Genera una lista de puntos que forman un círculo usando el algoritmo de Bresenham
        /// </summary>
        /// <param name="center">Centro del círculo</param>
        /// <param name="radius">Radio del círculo</param>
        /// <returns>Lista de puntos que forman el círculo</returns>
        public static List<Point> GetCircle(Point center, int radius)
        {
            var points = new List<Point>();

            if (radius <= 0)
                return points;

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            // Generar puntos usando simetría de 8 puntos
            while (y >= x)
            {
                AddSymmetricPoints(points, center, x, y);
                x++;

                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                {
                    d = d + 4 * x + 6;
                }
            }

            // Ordenar puntos para una animación más suave (opcional)
            points.Sort((p1, p2) =>
            {
                double angle1 = Math.Atan2(p1.Y - center.Y, p1.X - center.X);
                double angle2 = Math.Atan2(p2.Y - center.Y, p2.X - center.X);
                return angle1.CompareTo(angle2);
            });

            return points;
        }

        /// <summary>
        /// Añade los 8 puntos simétricos del círculo
        /// </summary>
        private static void AddSymmetricPoints(List<Point> points, Point center, int x, int y)
        {
            // Los 8 octantes del círculo
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