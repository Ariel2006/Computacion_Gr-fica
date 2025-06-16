using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectPaint.Algorithms
{
    /// <summary>
    /// Implementación del algoritmo DDA (Digital Differential Analyzer) para dibujo de líneas
    /// </summary>
    public static class DDAAlgorithm
    {
        /// <summary>
        /// Genera una lista de puntos que forman una línea usando el algoritmo DDA
        /// </summary>
        /// <param name="start">Punto inicial</param>
        /// <param name="end">Punto final</param>
        /// <returns>Lista de puntos que forman la línea</returns>
        public static List<Point> GetLine(Point start, Point end)
        {
            var points = new List<Point>();

            if (start == end)
            {
                points.Add(start);
                return points;
            }

            int dx = end.X - start.X;
            int dy = end.Y - start.Y;

            // Determinar el número de pasos necesarios
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            if (steps == 0)
            {
                points.Add(start);
                return points;
            }

            // Calcular incrementos
            float xIncrement = (float)dx / steps;
            float yIncrement = (float)dy / steps;

            // Coordenadas flotantes para mayor precisión
            float x = start.X;
            float y = start.Y;

            // Generar puntos
            for (int i = 0; i <= steps; i++)
            {
                points.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                x += xIncrement;
                y += yIncrement;
            }

            return points;
        }
    }
}