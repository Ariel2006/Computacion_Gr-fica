using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProyectPaint.Algorithms;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProyectPaint
{
    public partial class FrmProyecto : Form
    {
        #region Private Fields
        private Bitmap canvasBitmap;
        private Graphics graphics;
        private DrawingMode currentMode = DrawingMode.Line;
        private LineAlgorithm selectedLineAlgorithm = LineAlgorithm.DDA;
        private Color currentDrawColor = Color.Black;
        private Color currentFillColor = Color.Red;
        private bool isDrawing = false;
        private Point startPoint, endPoint;
        private readonly int canvasWidth = 800;
        private readonly int canvasHeight = 600;
        #endregion

        #region Enums
        public enum DrawingMode
        {
            Line,
            Circle,
            Fill
        }

        public enum LineAlgorithm
        {
            DDA,
            Bresenham
        }
        #endregion

        #region Constructor
        public FrmProyecto()
        {
            InitializeComponent();
            InitializeCanvas();
            SetupEventHandlers();
            UpdateUI();
        }
        #endregion

        #region Initialization
        private void InitializeCanvas()
        {
            canvasBitmap = new Bitmap(canvasWidth, canvasHeight);
            graphics = Graphics.FromImage(canvasBitmap);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            panelCanvas.Image = canvasBitmap;
        }

        private void SetupEventHandlers()
        {
            panelCanvas.MouseDown += PanelCanvas_MouseDown;
            panelCanvas.MouseMove += PanelCanvas_MouseMove;
            panelCanvas.MouseUp += PanelCanvas_MouseUp;
            panelCanvas.Paint += PanelCanvas_Paint;
        }
        #endregion

        #region Mouse Events
        private void PanelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;

                if (currentMode == DrawingMode.Fill)
                {
                    PerformFloodFill(e.Location);
                }
            }
        }

        private void PanelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentMode != DrawingMode.Fill)
            {
                endPoint = e.Location;
                panelCanvas.Invalidate(); // Trigger repaint for preview
            }

            // Update status bar with mouse coordinates
            lblCoordinates.Text = $"X: {e.X}, Y: {e.Y}";
        }

        private void PanelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;
                isDrawing = false;

                switch (currentMode)
                {
                    case DrawingMode.Line:
                        DrawLine(startPoint, endPoint);
                        break;
                    case DrawingMode.Circle:
                        DrawCircle(startPoint, endPoint);
                        break;
                }

                panelCanvas.Invalidate();
            }
        }

        private void PanelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing && currentMode != DrawingMode.Fill)
            {
                using (Pen previewPen = new Pen(currentDrawColor, 1))
                {
                    previewPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    switch (currentMode)
                    {
                        case DrawingMode.Line:
                            e.Graphics.DrawLine(previewPen, startPoint, endPoint);
                            break;
                        case DrawingMode.Circle:
                            int radius = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
                            Rectangle rect = new Rectangle(startPoint.X - radius, startPoint.Y - radius, radius * 2, radius * 2);
                            e.Graphics.DrawEllipse(previewPen, rect);
                            break;
                    }
                }
            }
        }
        #endregion

        #region Drawing Methods
        private async void DrawLine(Point start, Point end)
        {
            try
            {
                btnProgress.Visible = true;
                btnProgress.Value = 0;

                List<Point> points = selectedLineAlgorithm == LineAlgorithm.DDA
                    ? DDAAlgorithm.GetLine(start, end)
                    : BresenhamLineAlgorithm.GetLine(start, end);

                await DrawPointsWithAnimation(points, currentDrawColor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dibujar línea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnProgress.Visible = false;
            }
        }

        private async void DrawCircle(Point center, Point edgePoint)
        {
            try
            {
                int radius = (int)Math.Sqrt(Math.Pow(edgePoint.X - center.X, 2) + Math.Pow(edgePoint.Y - center.Y, 2));

                if (radius <= 0) return;

                btnProgress.Visible = true;
                btnProgress.Value = 0;

                var points = BresenhamCircleAlgorithm.GetCircle(center, radius);
                await DrawPointsWithAnimation(points, currentDrawColor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dibujar círculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnProgress.Visible = false;
            }
        }

        private async Task DrawPointsWithAnimation(List<Point> points, Color color)
        {
            listBoxPixels.Items.Clear();

            for (int i = 0; i < points.Count; i++)
            {
                var point = points[i];

                if (IsPointInBounds(point))
                {
                    canvasBitmap.SetPixel(point.X, point.Y, color);
                    listBoxPixels.Items.Add($"({point.X},{point.Y})");

                    // Update progress
                    btnProgress.Value = (int)((double)(i + 1) / points.Count * 100);

                    panelCanvas.Invalidate();

                    if (chkAnimation.Checked)
                        await Task.Delay(10);
                }
            }

            // Scroll to last item
            if (listBoxPixels.Items.Count > 0)
                listBoxPixels.SelectedIndex = listBoxPixels.Items.Count - 1;
        }

        private void PerformFloodFill(Point point)
        {
            try
            {
                if (!IsPointInBounds(point)) return;

                Color targetColor = canvasBitmap.GetPixel(point.X, point.Y);

                if (targetColor.ToArgb() == currentFillColor.ToArgb()) return;

                FloodFillAlgorithm.FloodFill(canvasBitmap, point, targetColor, currentFillColor);
                panelCanvas.Invalidate();

                lblStatus.Text = $"Área rellenada en ({point.X},{point.Y})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al rellenar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Button Events
        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de que desea limpiar el lienzo?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                graphics.Clear(Color.White);
                panelCanvas.Invalidate();
                listBoxPixels.Items.Clear();
                lblStatus.Text = "Lienzo limpiado";
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp";
                    saveDialog.DefaultExt = "png";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        canvasBitmap.Save(saveDialog.FileName);
                        lblStatus.Text = $"Imagen guardada: {saveDialog.FileName}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDrawColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = currentDrawColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentDrawColor = colorDialog.Color;
                    btnDrawColor.BackColor = currentDrawColor;
                    UpdateUI();
                }
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = currentFillColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFillColor = colorDialog.Color;
                    btnFillColor.BackColor = currentFillColor;
                    UpdateUI();
                }
            }
        }
        #endregion

        #region Radio Button Events
        private void RbLine_CheckedChanged(object sender, EventArgs e)
        {
            if (RbLine.Checked)
            {
                currentMode = DrawingMode.Line;
                UpdateUI();
            }
        }

        private void RbCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCircle.Checked)
            {
                currentMode = DrawingMode.Circle;
                UpdateUI();
            }
        }

        private void RbFill_CheckedChanged(object sender, EventArgs e)
        {
            if (RbFill.Checked)
            {
                currentMode = DrawingMode.Fill;
                UpdateUI();
            }
        }

        private void RbDDA_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDDA.Checked)
            {
                selectedLineAlgorithm = LineAlgorithm.DDA;
                UpdateUI();
            }
        }

        private void RbBresenham_CheckedChanged(object sender, EventArgs e)
        {
            if (RbBresenham.Checked)
            {
                selectedLineAlgorithm = LineAlgorithm.Bresenham;
                UpdateUI();
            }
        }
        #endregion

        #region Helper Methods
        private bool IsPointInBounds(Point point)
        {
            return point.X >= 0 && point.X < canvasBitmap.Width &&
                   point.Y >= 0 && point.Y < canvasBitmap.Height;
        }

        private void UpdateUI()
        {
            // Update algorithm selection visibility
            grpAlgorithm.Enabled = currentMode == DrawingMode.Line;

            // Update status
            string modeText = currentMode.ToString();
            string algorithmText = currentMode == DrawingMode.Line ? selectedLineAlgorithm.ToString() : "";
            lblStatus.Text = $"Modo: {modeText} {algorithmText}";

            // Update cursor
            switch (currentMode)
            {
                case DrawingMode.Line:
                    panelCanvas.Cursor = Cursors.Cross;
                    break;
                case DrawingMode.Circle:
                    panelCanvas.Cursor = Cursors.Cross;
                    break;
                case DrawingMode.Fill:
                    panelCanvas.Cursor = Cursors.Hand;
                    break;
            }
        }

        private void FrmProyecto_Load(object sender, EventArgs e)
        {

        }

        private void grpDrawingMode_Enter(object sender, EventArgs e)
        {

        }

        private void lblCoordinates_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel6_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            graphics?.Dispose();
            canvasBitmap?.Dispose();
            base.OnFormClosing(e);
        }
        #endregion
    }
}