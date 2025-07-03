using ProyectoGraficos.Algorithms.Fill;
using ProyectoGraficos.Models;
using System.Drawing;

namespace ProyectoGraficos.Services
{
    public static class FillService
    {
        public static void FillFigure(Figura figure, Color fillColor, Graphics g)
        {
            if (figure == null) return;

            figure.FillColor = fillColor;
            figure.IsFilled = true;

            if (figure is Polygon polygon)
            {
                ScanlineFill.Fill(g, polygon.Points, fillColor);
            }
            else
            {
                // Para otras figuras, simplemente marcamos que deben rellenarse
                // y se manejará en su método Draw
            }
        }
    }
}