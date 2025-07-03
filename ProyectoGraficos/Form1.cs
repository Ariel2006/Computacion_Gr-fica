using ProyectoGraficos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGraficos
{
    public partial class Form1 : Form
    {
        private enum ToolMode { Draw, Fill, Select, Clip }
        private ToolMode currentMode = ToolMode.Draw;
        private List<Figura> figures = new List<Figura>();
        private Figura currentFigure = null;
        private Figura selectedFigure = null;
        private Color contourColor = Color.Black;
        private Color fillColor = Color.Blue;
        private Rectangle clipArea = new Rectangle(100, 100, 300, 200);
        private bool isDragging = false;
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetupUI();
            this.BackColor = Color.FromArgb(240, 240, 240);
            panelCanvas.BackColor = Color.White;
            panelCanvas.Paint += PanelCanvas_Paint;
        }

        private void PanelCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Dibujar área de recorte
            using (Pen clipPen = new Pen(Color.LightGray, 1))
            {
                clipPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(clipPen, clipArea);
            }

            // Dibujar todas las figuras
            foreach (var figure in figures)
            {
                if (figure.IsVisible)
                {
                    figure.Draw(g);
                }
            }

            // Dibujar figura actual en creación
            if (currentFigure != null)
            {
                currentFigure.Draw(g);
            }

            // Resaltar figura seleccionada
            if (selectedFigure != null)
            {
                selectedFigure.DrawSelection(g);
            }
        }

        private void SetupUI()
        {
            cmbAlgorithm.Items.AddRange(new object[] {
                "DDA (Línea)",
                "Bresenham (Línea)",
                "Bresenham (Círculo)",
                "Bresenham (Elipse)",
                "Bezier",
                "B-Spline"
            });
            cmbAlgorithm.SelectedIndex = 0;
            UpdateControls();
        }

        private void UpdateControls()
        {
            bool isCurve = cmbAlgorithm.SelectedIndex >= 4;
            bool isCircle = cmbAlgorithm.SelectedIndex == 2;
            bool isEllipse = cmbAlgorithm.SelectedIndex == 3;

            lblPoint2.Visible = !isCircle && !isEllipse;
            txtX2.Enabled = txtY2.Enabled = !isCircle && !isEllipse;
            lblRadius.Visible = numRadius.Visible = isCircle;
            lblRX.Visible = lblRY.Visible = numRX.Visible = numRY.Visible = isEllipse;
            btnAddPoint.Visible = isCurve;
            btnFinishCurve.Visible = isCurve && currentFigure != null;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            currentMode = ToolMode.Draw;
            if (currentFigure != null && currentFigure is Curve)
            {
                figures.Add(currentFigure);
                currentFigure = null;
            }
            panelCanvas.Invalidate();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            currentMode = ToolMode.Fill;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            currentMode = ToolMode.Select;
        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            currentMode = ToolMode.Clip;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;

            switch (currentMode)
            {
                case ToolMode.Draw:
                    StartNewFigure(e.Location);
                    break;

                case ToolMode.Fill:
                    ApplyFill(e.Location);
                    break;

                case ToolMode.Select:
                    SelectFigure(e.Location);
                    break;
            }

            panelCanvas.Invalidate();
        }

        private void StartNewFigure(Point location)
        {
            string algorithm = cmbAlgorithm.SelectedItem.ToString();

            switch (algorithm)
            {
                case "DDA (Línea)":
                case "Bresenham (Línea)":
                    currentFigure = new Line(location, location, contourColor);
                    break;

                case "Bresenham (Círculo)":
                    currentFigure = new Circle(location, 0, contourColor);
                    break;

                case "Bresenham (Elipse)":
                    currentFigure = new Ellipse(location, 0, 0, contourColor);
                    break;

                case "Bezier":
                case "B-Spline":
                    if (currentFigure == null || !(currentFigure is Curve))
                        currentFigure = new Curve(algorithm, contourColor);
                    ((Curve)currentFigure).AddPoint(location);
                    break;
            }
        }

        private void ApplyFill(Point location)
        {
            foreach (var figure in figures)
            {
                if (figure.Contains(location))
                {
                    figure.FillColor = fillColor;
                    figure.IsFilled = true;
                    break;
                }
            }
        }

        private void SelectFigure(Point location)
        {
            selectedFigure = null;
            for (int i = figures.Count - 1; i >= 0; i--)
            {
                if (figures[i].Contains(location))
                {
                    selectedFigure = figures[i];
                    isDragging = true;
                    break;
                }
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentMode == ToolMode.Draw && currentFigure != null)
            {
                if (currentFigure is Line line)
                    line.EndPoint = e.Location;
                else if (currentFigure is Circle circle)
                    circle.Radius = (int)Math.Sqrt(Math.Pow(e.X - circle.Center.X, 2) + Math.Pow(e.Y - circle.Center.Y, 2));
                else if (currentFigure is Ellipse ellipse)
                {
                    ellipse.RX = Math.Abs(e.X - ellipse.Center.X);
                    ellipse.RY = Math.Abs(e.Y - ellipse.Center.Y);
                }

                panelCanvas.Invalidate();
            }
            else if (currentMode == ToolMode.Select && isDragging && selectedFigure != null)
            {
                int dx = e.X - lastPoint.X;
                int dy = e.Y - lastPoint.Y;
                selectedFigure.Move(dx, dy);
                lastPoint = e.Location;
                panelCanvas.Invalidate();
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentMode == ToolMode.Draw && currentFigure != null &&
                !(currentFigure is Curve))
            {
                figures.Add(currentFigure);
                currentFigure = null;
                panelCanvas.Invalidate();
            }
            else if (currentMode == ToolMode.Select)
            {
                isDragging = false;
            }
        }

        private void btnColorContour_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                contourColor = colorDialog.Color;
        }

        private void btnColorFill_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                fillColor = colorDialog.Color;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            // Implementación para curvas
        }

        private void btnFinishCurve_Click(object sender, EventArgs e)
        {
            if (currentFigure != null && currentFigure is Curve)
            {
                figures.Add(currentFigure);
                currentFigure = null;
                panelCanvas.Invalidate();
            }
        }

        private void btnApplyClip_Click(object sender, EventArgs e)
        {
            // Implementación de recorte
            panelCanvas.Invalidate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFigure != null)
            {
                figures.Remove(selectedFigure);
                selectedFigure = null;
                panelCanvas.Invalidate();
            }
            else
            {
                MessageBox.Show("No hay ninguna figura seleccionada para borrar.",
                               "Advertencia",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
        }

        private void cmbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}