using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(240, 248, 255); // Elegante azul claro
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(txtLadoA.Text);
            double ladoB = double.Parse(txtLadoB.Text);
            double ladoC = double.Parse(txtLadoC.Text);
            double ladoD = double.Parse(txtLadoD.Text);
            string figura = cmbFigura.SelectedItem?.ToString();

            double area = 0;
            double perimetro = 0;

            switch (figura)
            {
                case "Cuadrado":
                    Cuadrado cuadrado = new Cuadrado(ladoA);
                    area = cuadrado.CalcularArea();
                    perimetro = cuadrado.CalcularPerimetro();
                    break;

                case "Rectángulo":
                    Rectangulo rect = new Rectangulo(ladoA, ladoB);
                    area = rect.CalcularArea();
                    perimetro = rect.CalcularPerimetro();
                    break;

                case "Triángulo":
                    Triangulo tri = new Triangulo(ladoA, ladoB);
                    area = tri.CalcularArea();
                    perimetro = tri.CalcularPerimetro();
                    break;

                case "Círculo":
                    Circulo circ = new Circulo(ladoA);
                    area = circ.CalcularArea();
                    perimetro = circ.CalcularPerimetro();
                    break;

                case "Rombo":
                    Rombo rombo = new Rombo(ladoA, ladoB);
                    area = rombo.CalcularArea();
                    perimetro = rombo.CalcularPerimetro();
                    break;

                case "Romboide":
                    Romboide romboide = new Romboide(ladoA, ladoB);
                    area = romboide.CalcularArea();
                    perimetro = romboide.CalcularPerimetro();
                    break;

                case "Trapecio":
                    Trapecio trap = new Trapecio(ladoA, ladoB, ladoC, ladoD);
                    area = trap.CalcularArea();
                    perimetro = trap.CalcularPerimetro();
                    break;

                case "Elipse":
                    Elipse elipse = new Elipse(ladoA, ladoB);
                    area = elipse.CalcularArea();
                    perimetro = elipse.CalcularPerimetro();
                    break;
            }

            lblResultado.Text = $"Área: {area:F2} - Perímetro: {perimetro:F2}";
        }
    }

    class Cuadrado
    {
        double lado;
        public Cuadrado(double l) { lado = l; }
        public double CalcularArea() => lado * lado;
        public double CalcularPerimetro() => 4 * lado;
    }

    class Rectangulo
    {
        double base_, altura;
        public Rectangulo(double b, double h) { base_ = b; altura = h; }
        public double CalcularArea() => base_ * altura;
        public double CalcularPerimetro() => 2 * (base_ + altura);
    }

    class Triangulo
    {
        double base_, altura;
        public Triangulo(double b, double h) { base_ = b; altura = h; }
        public double CalcularArea() => (base_ * altura) / 2;
        public double CalcularPerimetro() => base_ * 3; // simplificado
    }

    class Circulo
    {
        double radio;
        public Circulo(double r) { radio = r; }
        public double CalcularArea() => Math.PI * radio * radio;
        public double CalcularPerimetro() => 2 * Math.PI * radio;
    }

    class Rombo
    {
        double d1, d2;
        public Rombo(double a, double b) { d1 = a; d2 = b; }
        public double CalcularArea() => (d1 * d2) / 2;
        public double CalcularPerimetro() => 4 * Math.Sqrt(Math.Pow(d1 / 2, 2) + Math.Pow(d2 / 2, 2));
    }

    class Romboide
    {
        double base_, altura;
        public Romboide(double b, double h) { base_ = b; altura = h; }
        public double CalcularArea() => base_ * altura;
        public double CalcularPerimetro() => 2 * (base_ + altura);
    }

    class Trapecio
    {
        double a, b, c, d;
        public Trapecio(double la, double lb, double lc, double ld) { a = la; b = lb; c = lc; d = ld; }
        public double CalcularArea() => ((a + b) * c) / 2; // a y b bases, c altura
        public double CalcularPerimetro() => a + b + c + d;
    }

    class Elipse
    {
        double a, b;
        public Elipse(double ejeMayor, double ejeMenor) { a = ejeMayor; b = ejeMenor; }
        public double CalcularArea() => Math.PI * a * b;
        public double CalcularPerimetro() => Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))); // Aproximación
    }
}
