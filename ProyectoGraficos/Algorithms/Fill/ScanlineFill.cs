using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Fill
{
    public static class ScanlineFill
    {
        public static void Fill(Graphics g, List<Point> polygon, Color fillColor)
        {
            if (polygon.Count < 3) return;

            // Encontrar límites del polígono
            int minY = polygon[0].Y, maxY = polygon[0].Y;
            foreach (Point p in polygon)
            {
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }

            // Procesar cada línea de escaneo
            for (int y = minY; y <= maxY; y++)
            {
                List<int> intersections = new List<int>();

                // Encontrar intersecciones
                for (int i = 0; i < polygon.Count; i++)
                {
                    Point p1 = polygon[i];
                    Point p2 = polygon[(i + 1) % polygon.Count];

                    if ((p1.Y <= y && p2.Y > y) || (p2.Y <= y && p1.Y > y))
                    {
                        int x = (int)(p1.X + (double)(y - p1.Y) / (p2.Y - p1.Y) * (p2.X - p1.X));
                        intersections.Add(x);
                    }
                }

                // Ordenar intersecciones
                intersections.Sort();

                // Rellenar entre pares de intersecciones
                for (int i = 0; i < intersections.Count; i += 2)
                {
                    if (i + 1 < intersections.Count)
                    {
                        using (Pen pen = new Pen(fillColor))
                        {
                            g.DrawLine(pen, intersections[i], y, intersections[i + 1], y);
                        }
                    }
                }
            }
        }
    }
}