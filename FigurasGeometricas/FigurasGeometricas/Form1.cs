using System;
using System.Windows.Forms;
using System.Drawing;

namespace FigurasGeometricas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            
            cmbFigura.Items.AddRange(new string[]
            {
                "Triángulo", "Cuadrado", "Rectángulo", "Círculo", "Semicírculo",
                "Trapecio", "Trapezoide", "Rombo", "Romboide", "Deltoide", "Estrella"
            });

            cmbFigura.SelectedIndexChanged += cmbFigura_SelectedIndexChanged;
            btnCalcular.Click += btnCalcular_Click;
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLadoA.Visible = txtLadoA.Visible = false;
            lblLadoB.Visible = txtLadoB.Visible = false;
            lblLadoC.Visible = txtLadoC.Visible = false;
            lblLadoD.Visible = txtLadoD.Visible = false;

            txtLadoA.Text = txtLadoB.Text = txtLadoC.Text = txtLadoD.Text = "";

            string figura = cmbFigura.SelectedItem.ToString();

            switch (figura)
            {
                case "Triángulo":
                    lblLadoA.Text = "Base:";
                    lblLadoB.Text = "Altura:";
                    lblLadoC.Text = "Hipotenusa";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    lblLadoC.Visible = txtLadoC.Visible = true;
                    break;

                case "Cuadrado":
                    lblLadoA.Text = "Lado A:";
                    lblLadoB.Text = "Lado B:";
                    lblLadoC.Text = "Lado C";
                    lblLadoD.Text = "Lado D";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    lblLadoC.Visible = txtLadoC.Visible = true;
                    lblLadoD.Visible = txtLadoD.Visible = true;
                    break;

                case "Rectángulo":
                    lblLadoA.Text = "Base:";
                    lblLadoB.Text = "Altura:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    break;

                case "Círculo":
                    lblLadoA.Text = "Radio:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    break;

                case "Semicírculo":
                    lblLadoA.Text = "Radio:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    break;

                case "Trapecio":
                    lblLadoA.Text = "Base mayor:";
                    lblLadoB.Text = "Base menor:";
                    lblLadoC.Text = "Altura:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    lblLadoC.Visible = txtLadoC.Visible = true;
                    break;

                case "Trapezoide":
                    lblLadoA.Text = "Lado A:";
                    lblLadoB.Text = "Lado B:";
                    lblLadoC.Text = "Lado C:";
                    lblLadoD.Text = "Lado D:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    lblLadoC.Visible = txtLadoC.Visible = true;
                    lblLadoD.Visible = txtLadoD.Visible = true;
                    break;

                case "Rombo":
                    lblLadoA.Text = "Diagonal mayor:";
                    lblLadoB.Text = "Diagonal menor:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    break;

                case "Romboide":
                    lblLadoA.Text = "Base:";
                    lblLadoB.Text = "Altura:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    break;

                case "Deltoide":
                    lblLadoA.Text = "Diagonal mayor:";
                    lblLadoB.Text = "Diagonal menor:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    break;

                case "Estrella":
                    lblLadoA.Text = "Radio exterior:";
                    lblLadoB.Text = "Número de puntas:";
                    lblLadoA.Visible = txtLadoA.Visible = true;
                    lblLadoB.Visible = txtLadoB.Visible = true;
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string figura = cmbFigura.SelectedItem.ToString();
                double a = string.IsNullOrWhiteSpace(txtLadoA.Text) ? 0 : Convert.ToDouble(txtLadoA.Text);
                double b = string.IsNullOrWhiteSpace(txtLadoB.Text) ? 0 : Convert.ToDouble(txtLadoB.Text);
                double c = string.IsNullOrWhiteSpace(txtLadoC.Text) ? 0 : Convert.ToDouble(txtLadoC.Text);
                double d = string.IsNullOrWhiteSpace(txtLadoD.Text) ? 0 : Convert.ToDouble(txtLadoD.Text);
                double area = 0, perimetro = 0;

                switch (figura)
                {
                    case "Triángulo":
                        area = (a * b) / 2;
                        perimetro = a + b + c;
                        break;

                    case "Cuadrado":
                        area = a * a;
                        perimetro = 4 * a;
                        break;

                    case "Rectángulo":
                        area = a * b;
                        perimetro = 2 * (a + b);
                        break;

                    case "Círculo":
                        area = Math.PI * a * a;
                        perimetro = 2 * Math.PI * a;
                        break;

                    case "Semicírculo":
                        area = (Math.PI * a * a) / 2;
                        perimetro = Math.PI * a + 2 * a;
                        break;

                    case "Trapecio":
                        area = ((a + b) * c) / 2;
                        perimetro = a + b + 2 * Math.Sqrt(Math.Pow((a - b) / 2, 2) + c * c);
                        break;

                    case "Trapezoide":
                        perimetro = a + b + c + d;
                        area = 0; 
                        break;

                    case "Rombo":
                        area = (a * b) / 2;
                        perimetro = 4 * Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(b / 2, 2));
                        break;

                    case "Romboide":
                        area = a * b;
                        perimetro = 2 * (a + b);
                        break;

                    case "Deltoide":
                        area = (a * b) / 2;
                        perimetro = 2 * Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(b / 2, 2));
                        break;

                    case "Estrella":
                        area = 0.5 * a * a * Math.Sin(2 * Math.PI / b) * b;
                        perimetro = 2 * b * a * Math.Sin(Math.PI / b); 
                        break;
                }

                lblResultado.Text = $"Área = {area:F2}, Perímetro = {perimetro:F2}";
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Ingrese todos los valores necesarios correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
