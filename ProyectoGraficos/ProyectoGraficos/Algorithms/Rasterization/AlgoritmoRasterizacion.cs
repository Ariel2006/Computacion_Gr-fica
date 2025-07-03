using System.Collections.Generic;
using System.Drawing;
using ProyectoGraficos.Algorithms.Rasterization;

namespace ProyectoGraficos
{
    public class AlgoritmoRasterizacion
    {
        private List<Point> pasos = new List<Point>();
        private int pasoActual = 0;

        // Exponer solo lectura de puntos dibujados
        public IReadOnlyList<Point> PuntosDibujados { get; private set; } = new List<Point>();

        public int TotalPasos => pasos.Count;

        // Ejecutar algoritmo DDA para línea
        public void EjecutarDDA(Point start, Point end)
        {
            pasos = DDA.DrawLine(start, end);
            pasoActual = 0;
            PuntosDibujados = new List<Point>();
        }

        // Avanzar un paso y agregar punto dibujado
        public bool SiguientePaso()
        {
            if (pasoActual >= pasos.Count)
                return false;

            var listaActual = new List<Point>(PuntosDibujados) { pasos[pasoActual] };
            PuntosDibujados = listaActual;
            pasoActual++;
            return true;
        }
    }
}
