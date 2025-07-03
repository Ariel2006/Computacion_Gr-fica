using System;
using System.Drawing;

namespace ProyectoGraficos.Models
{
    public class Line : Figura
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Line(Point start, Point end, Color color)
        {
            StartPoint = start;
            EndPoint = end;
            ContourColor = color;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(ContourColor, 2))
            {
                g.DrawLine(pen, StartPoint, EndPoint);
            }
        }

        public override void DrawSelection(Graphics g)
        {
            using (Pen pen = new Pen(Color.Red, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen,
                    Math.Min(StartPoint.X, EndPoint.X),
                    Math.Min(StartPoint.Y, EndPoint.Y),
                    Math.Abs(EndPoint.X - StartPoint.X),
                    Math.Abs(EndPoint.Y - StartPoint.Y));
            }
        }

        public override bool Contains(Point point)
        {
            // Simplificación: considerar un área alrededor de la línea
            Rectangle bounds = new Rectangle(
                Math.Min(StartPoint.X, EndPoint.X),
                Math.Min(StartPoint.Y, EndPoint.Y),
                Math.Abs(EndPoint.X - StartPoint.X),
                Math.Abs(EndPoint.Y - StartPoint.Y));
            return bounds.Contains(point);
        }

        public override void Move(int dx, int dy)
        {
            StartPoint = new Point(StartPoint.X + dx, StartPoint.Y + dy);
            EndPoint = new Point(EndPoint.X + dx, EndPoint.Y + dy);
        }
    }
}