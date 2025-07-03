using System;
using System.Drawing;

namespace ProyectoGraficos.Models
{
    public class Circle : Figura
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            ContourColor = color;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(ContourColor, 2))
            {
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius,
                             Radius * 2, Radius * 2);
            }

            if (IsFilled)
            {
                using (Brush brush = new SolidBrush(FillColor))
                {
                    g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius,
                                 Radius * 2, Radius * 2);
                }
            }
        }

        public override void DrawSelection(Graphics g)
        {
            using (Pen pen = new Pen(Color.Red, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, Center.X - Radius, Center.Y - Radius,
                              Radius * 2, Radius * 2);
            }
        }

        public override bool Contains(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - Center.X, 2) +
                                       Math.Pow(point.Y - Center.Y, 2));
            return distance <= Radius;
        }

        public override void Move(int dx, int dy)
        {
            Center = new Point(Center.X + dx, Center.Y + dy);
        }
    }
}