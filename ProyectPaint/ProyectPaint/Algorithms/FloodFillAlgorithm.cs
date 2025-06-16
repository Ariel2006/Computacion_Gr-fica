using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectPaint.Algorithms
{
    /// <summary>
    /// Implementación del algoritmo Flood Fill para relleno de áreas
    /// </summary>
    public static class FloodFillAlgorithm
    {
        /// <summary>
        /// Rellena un área usando el algoritmo Flood Fill
        /// </summary>
        /// <param name="bitmap">Bitmap a modificar</param>
        /// <param name="startPoint">Punto inicial del relleno</param>
        /// <param name="targetColor">Color objetivo a reemplazar</param>
        /// <param name="replacementColor">Color de reemplazo</param>
        public static void FloodFill(Bitmap bitmap, Point startPoint, Color targetColor, Color replacementColor)
        {
            // Validaciones
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            if (startPoint.X < 0 || startPoint.X >= bitmap.Width ||
                startPoint.Y < 0 || startPoint.Y >= bitmap.Height)
                return;

            // Si los colores son iguales, no hay nada que hacer
            if (targetColor.ToArgb() == replacementColor.ToArgb())
                return;

            // Usar algoritmo de relleno por líneas (más eficiente)
            FloodFillScanline(bitmap, startPoint, targetColor, replacementColor);
        }

        /// <summary>
        /// Implementación optimizada usando scanline
        /// </summary>
        private static void FloodFillScanline(Bitmap bitmap, Point start, Color targetColor, Color replacementColor)
        {
            var stack = new Stack<Point>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                Point point = stack.Pop();
                int x = point.X;
                int y = point.Y;

                // Buscar el extremo izquierdo de la línea
                while (x >= 0 && GetPixelSafe(bitmap, x, y) == targetColor)
                    x--;
                x++;

                bool spanAbove = false;
                bool spanBelow = false;

                // Rellenar la línea horizontal
                while (x < bitmap.Width && GetPixelSafe(bitmap, x, y) == targetColor)
                {
                    bitmap.SetPixel(x, y, replacementColor);

                    // Verificar píxel arriba
                    if (!spanAbove && y > 0 && GetPixelSafe(bitmap, x, y - 1) == targetColor)
                    {
                        stack.Push(new Point(x, y - 1));
                        spanAbove = true;
                    }
                    else if (spanAbove && y > 0 && GetPixelSafe(bitmap, x, y - 1) != targetColor)
                    {
                        spanAbove = false;
                    }

                    // Verificar píxel abajo
                    if (!spanBelow && y < bitmap.Height - 1 && GetPixelSafe(bitmap, x, y + 1) == targetColor)
                    {
                        stack.Push(new Point(x, y + 1));
                        spanBelow = true;
                    }
                    else if (spanBelow && y < bitmap.Height - 1 && GetPixelSafe(bitmap, x, y + 1) != targetColor)
                    {
                        spanBelow = false;
                    }

                    x++;
                }
            }
        }

        /// <summary>
        /// Obtiene un píxel de forma segura, manejando límites
        /// </summary>
        private static Color GetPixelSafe(Bitmap bitmap, int x, int y)
        {
            if (x < 0 || x >= bitmap.Width || y < 0 || y >= bitmap.Height)
                return Color.Empty;

            return bitmap.GetPixel(x, y);
        }
    }
}