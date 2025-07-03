using System.Drawing;

namespace ProyectoGraficos.Models
{
    public abstract class Figura
    {
        public Color ContourColor { get; set; }
        public Color FillColor { get; set; }
        public bool IsFilled { get; set; }
        public bool IsVisible { get; set; } = true;

        public abstract void Draw(Graphics g);
        public abstract void DrawSelection(Graphics g);
        public abstract bool Contains(Point point);
        public abstract void Move(int dx, int dy);
    }
}