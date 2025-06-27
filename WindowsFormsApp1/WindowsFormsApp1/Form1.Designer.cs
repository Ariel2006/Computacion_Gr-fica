using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbFigura;
        private TextBox txtLadoA, txtLadoB, txtLadoC, txtLadoD;
        private Button btnCalcular;
        private Label lblResultado, lblLadoA, lblLadoB, lblLadoC, lblLadoD;
        private PictureBox pictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Calculadora de Figuras Geométricas";
            this.Size = new System.Drawing.Size(700, 550);

            cmbFigura = new ComboBox()
            {
                Location = new System.Drawing.Point(40, 30),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFigura.Items.AddRange(new string[] {
                "Cuadrado", "Rectángulo", "Triángulo", "Círculo",
                "Rombo", "Romboide", "Trapecio", "Elipse"
            });

            lblLadoA = new Label() { Text = "Lado A / Radio:", Location = new System.Drawing.Point(40, 80) };
            txtLadoA = new TextBox() { Location = new System.Drawing.Point(160, 80), Width = 100 };

            lblLadoB = new Label() { Text = "Lado B / Altura:", Location = new System.Drawing.Point(40, 120) };
            txtLadoB = new TextBox() { Location = new System.Drawing.Point(160, 120), Width = 100 };

            lblLadoC = new Label() { Text = "Lado C:", Location = new System.Drawing.Point(40, 160) };
            txtLadoC = new TextBox() { Location = new System.Drawing.Point(160, 160), Width = 100 };

            lblLadoD = new Label() { Text = "Lado D:", Location = new System.Drawing.Point(40, 200) };
            txtLadoD = new TextBox() { Location = new System.Drawing.Point(160, 200), Width = 100 };

            btnCalcular = new Button()
            {
                Text = "Calcular",
                Location = new System.Drawing.Point(40, 250),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White,
                Width = 150,
                Height = 40
            };
            btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            lblResultado = new Label()
            {
                Location = new System.Drawing.Point(40, 310),
                Width = 500,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateBlue
            };

            pictureBox = new PictureBox()
            {
                Location = new System.Drawing.Point(350, 50),
                Size = new System.Drawing.Size(300, 300),
                Image = Image.FromFile("C:\\Users\\Ariel\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\figurasgeo.png"),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            this.Controls.AddRange(new Control[] {
                cmbFigura, lblLadoA, txtLadoA, lblLadoB, txtLadoB,
                lblLadoC, txtLadoC, lblLadoD, txtLadoD,
                btnCalcular, lblResultado, pictureBox
            });
        }
    }
}
