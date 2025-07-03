using ProyectoGraficos.Algorithms.Clipping;
using ProyectoGraficos.Models;
using System.Drawing;

namespace ProyectoGraficos.Services
{
    public static class ClippingService
    {
        public static void ApplyClipping(Figura figure, Rectangle clipArea)
        {
            if (figure is Line line)
            {
                Point p1 = line.StartPoint;
                Point p2 = line.EndPoint;
                if (CohenSutherland.ClipLine(clipArea, ref p1, ref p2))
                {
                    line.StartPoint = p1;
                    line.EndPoint = p2;
                    line.IsVisible = true;
                }
                else
                {
                    line.IsVisible = false;
                }
            }
            else if (figure is Polygon polygon)
            {
                polygon.Points = SutherlandHodgman.ClipPolygon(polygon.Points, clipArea);
                polygon.IsVisible = polygon.Points.Count > 0;
            }
            // Otras figuras pueden manejarse según sea necesario
        }
    }
}