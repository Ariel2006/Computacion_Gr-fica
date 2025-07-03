using ProyectoGraficos.Algorithms.Curves;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Models
{
    public class Curve : Figura
    {
        public List<Point> ControlPoints { get; private set; } = new List<Point>();
        public string Algorithm { get; set; }

        public Curve(string algorithm, Color color)
        {
            Algorithm = algorithm;
            ContourColor = color;
        }

        public void AddPoint(Point point) => ControlPoints.Add(point);

        public override void Draw(Graphics g)
        {
            if (ControlPoints.Count < 2) return;

            List<Point> pointsToDraw;
            switch (Algorithm)
            {
                case "Bezier":
                    pointsToDraw = BezierCurve.Generate(ControlPoints);
                    break;
                case "B-Spline":
                    pointsToDraw = BSpline.Generate(ControlPoints, 3);
                    break;
                default:
                    return;
            }

            using (Pen pen = new Pen(ContourColor))
            {
                for (int i = 0; i < pointsToDraw.Count - 1; i++)
                {
                    g.DrawLine(pen, pointsToDraw[i], pointsToDraw[i + 1]);
                }
            }
        }

        public override bool Contains(Point point)
        {
            const int tolerance = 8;
            foreach (var p in ControlPoints)
            {
                if (Math.Abs(p.X - point.X) < tolerance && Math.Abs(p.Y - point.Y) < tolerance)
                    return true;
            }
            return false;
        }

        public override void Move(int dx, int dy)
        {
            for (int i = 0; i < ControlPoints.Count; i++)
            {
                ControlPoints[i] = new Point(ControlPoints[i].X + dx, ControlPoints[i].Y + dy);
            }
        }

        public Rectangle Bounds
        {
            get
            {
                if (ControlPoints.Count == 0) return Rectangle.Empty;

                int minX = ControlPoints[0].X, maxX = ControlPoints[0].X;
                int minY = ControlPoints[0].Y, maxY = ControlPoints[0].Y;

                foreach (var p in ControlPoints)
                {
                    if (p.X < minX) minX = p.X;
                    if (p.X > maxX) maxX = p.X;
                    if (p.Y < minY) minY = p.Y;
                    if (p.Y > maxY) maxY = p.Y;
                }

                return new Rectangle(minX, minY, maxX - minX, maxY - minY);
            }
        }

        public override void DrawSelection(Graphics g)
        {
            if (ControlPoints.Count == 0) return;

            using (Pen pen = new Pen(Color.Blue, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                g.DrawRectangle(pen, Bounds);
            }
        }
    }
}