using ProyectoGraficos.Algorithms.Rasterization;
using ProyectoGraficos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Services
{
    public static class DrawingService
    {
        public static Figura CreateFigure(string algorithm, Point start, Point end, Color color)
        {
            switch (algorithm)
            {
                case "DDA (Línea)":
                case "Bresenham (Línea)":
                    return new Line(start, end, color);
                case "Bresenham (Círculo)":
                    int radius = (int)Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
                    return new Circle(start, radius, color);
                case "Bresenham (Elipse)":
                    int rx = Math.Abs(end.X - start.X);
                    int ry = Math.Abs(end.Y - start.Y);
                    return new Ellipse(start, rx, ry, color);
                default:
                    return null;
            }
        }

        public static List<Point> GetRasterizedPoints(Figura figure)
        {
            if (figure is Line line)
            {
                return DDA.DrawLine(line.StartPoint, line.EndPoint);
            }
            else if (figure is Circle circle)
            {
                return BresenhamCircle.DrawCircle(circle.Center, circle.Radius);
            }
            else if (figure is Ellipse ellipse)
            {
                return BresenhamEllipse.DrawEllipse(ellipse.Center, ellipse.RX, ellipse.RY);
            }
            return new List<Point>();
        }
    }
}