using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectPaint.Algorithms
{
    /// <summary>
    /// Implementación del algoritmo de Bresenham para dibujo de líneas
    /// </summary>
    public static class BresenhamLineAlgorithm
    {
        /// <summary>
        /// Genera una lista de puntos que forman una línea usando el algoritmo de Bresenham
        /// </summary>
        /// <param name="start">Punto inicial</param>
        /// <param name="end">Punto final</param>
        /// <returns>Lista de puntos que forman la línea</returns>
        public static List<Point> GetLine(Point start, Point end)
        {
            var points = new List<Point>();

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

                // Si llegamos al punto final, terminar
                if (x0 == x1 && y0 == y1)
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }

            return points;
        }
    }
}