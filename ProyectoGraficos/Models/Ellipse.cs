using System.Drawing;

namespace ProyectoGraficos.Models
{
    public class Ellipse : Figura
    {
        public Point Center { get; set; }
        public int RX { get; set; }
        public int RY { get; set; }

        public Ellipse(Point center, int rx, int ry, Color color)
        {
            Center = center;
            RX = rx;
            RY = ry;
            ContourColor = color;
        }

        public override void Draw(Graphics g)
        {
            if (!IsVisible) return;
            using (Pen pen = new Pen(ContourColor))
            {
                g.DrawEllipse(pen, Center.X - RX, Center.Y - RY, RX * 2, RY * 2);
            }

            if (IsFilled)
            {
                using (Brush brush = new SolidBrush(FillColor))
                {
                    g.FillEllipse(brush, Center.X - RX, Center.Y - RY, RX * 2, RY * 2);
                }
            }
        }

        public override bool Contains(Point point)
        {
            double dx = point.X - Center.X;
            double dy = point.Y - Center.Y;
            return (dx * dx) / (RX * RX) + (dy * dy) / (RY * RY) <= 1;
        }

        public override void Move(int dx, int dy)
        {
            Center = new Point(Center.X + dx, Center.Y + dy);
        }

        public override void DrawSelection(Graphics g)
        {
            if (!IsVisible) return;
            using (Pen pen = new Pen(Color.Blue) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                g.DrawEllipse(pen, Center.X - RX, Center.Y - RY, RX * 2, RY * 2);
            }
        }

        public Rectangle Bounds => new Rectangle(
            Center.X - RX,
            Center.Y - RY,
            RX * 2,
            RY * 2);
    }
}