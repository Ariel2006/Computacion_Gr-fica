using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Models
{
    public class Polygon : Figura
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public Polygon(List<Point> points, Color color)
        {
            Points = new List<Point>(points);
            ContourColor = color;
        }

        public override void Draw(Graphics g)
        {
            if (Points.Count < 2) return;

            using (Pen pen = new Pen(ContourColor))
            {
                g.DrawPolygon(pen, Points.ToArray());
            }

            if (IsFilled)
            {
                using (Brush brush = new SolidBrush(FillColor))
                {
                    g.FillPolygon(brush, Points.ToArray());
                }
            }
        }

        public override bool Contains(Point point)
        {
            // Algoritmo del número de cruces (ray casting)
            bool inside = false;
            for (int i = 0, j = Points.Count - 1; i < Points.Count; j = i++)
            {
                if (((Points[i].Y > point.Y) != (Points[j].Y > point.Y)) &&
                    (point.X < (Points[j].X - Points[i].X) * (point.Y - Points[i].Y) / (Points[j].Y - Points[i].Y) + Points[i].X))
                {
                    inside = !inside;
                }
            }
            return inside;
        }

        public override void Move(int dx, int dy)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + dx, Points[i].Y + dy);
            }
        }

        // Removed the override keyword from the Bounds property
        // because the base class Figura does not define a Bounds property.
        public Rectangle Bounds
        {
            get
            {
                if (Points.Count == 0) return Rectangle.Empty;

                int minX = Points[0].X, maxX = Points[0].X;
                int minY = Points[0].Y, maxY = Points[0].Y;

                foreach (var p in Points)
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
            if (Points.Count < 2) return;

            using (Pen pen = new Pen(Color.Blue) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                g.DrawPolygon(pen, Points.ToArray());
            }
        }
    }
}