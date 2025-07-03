using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double num1, out double num2))
            {
            double resultado = num1 + num2;
            lblResultado.Text = $"Resultado: {resultado}";
            }
        }
        private bool TryGetInputs(out double num1, out double num2)
        {
            throw new NotImplementedException();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double num1, out double num2))
            {
                double resultado = num1 - num2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double num1, out double num2))
            {
                double resultado = num1 * num2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double num1, out double num2))
            {
                double resultado = num1 / num2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
        }



        private bool TryGetInputs(out double num1, out double num2)
        {
            bool isValid1 = double.TryParse(txtNombre2.Text, out num1);
            bool isValid2 = double.TryParse(txtNombre1.Text, out num2);

            if (!isValid1 || !isValid2)
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
                return false;
            }
            return true;
        }
    }
}
