using System.Collections.Generic;
using System.Drawing;

namespace ProyectoGraficos.Algorithms.Curves
{
    public static class BSpline
    {
        public static List<Point> Generate(List<Point> controlPoints, int degree, int segments = 100)
        {
            List<Point> curve = new List<Point>();
            int n = controlPoints.Count - 1;
            int m = n + degree + 1;

            // Crear vector de nodos uniforme
            double[] knots = new double[m + 1];
            for (int i = 0; i <= m; i++)
                knots[i] = i;

            double tStart = knots[degree];
            double tEnd = knots[n + 1];
            double step = (tEnd - tStart) / segments;

            for (double t = tStart; t <= tEnd; t += step)
            {
                Point p = new Point(0, 0);
                for (int i = 0; i <= n; i++)
                {
                    double basis = BasisFunction(i, degree, t, knots);
                    p.X += (int)(controlPoints[i].X * basis);
                    p.Y += (int)(controlPoints[i].Y * basis);
                }
                curve.Add(p);
            }

            return curve;
        }

        private static double BasisFunction(int i, int k, double t, double[] knots)
        {
            if (k == 0)
                return (t >= knots[i] && t < knots[i + 1]) ? 1.0 : 0.0;

            double denom1 = knots[i + k] - knots[i];
            double denom2 = knots[i + k + 1] - knots[i + 1];

            double term1 = denom1 == 0 ? 0 : (t - knots[i]) / denom1 * BasisFunction(i, k - 1, t, knots);
            double term2 = denom2 == 0 ? 0 : (knots[i + k + 1] - t) / denom2 * BasisFunction(i + 1, k - 1, t, knots);

            return term1 + term2;
        }
    }
}