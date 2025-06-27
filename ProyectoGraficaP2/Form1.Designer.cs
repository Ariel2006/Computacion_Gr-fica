using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.ComboBox comboBoxFigures;
        private System.Windows.Forms.Label labelTranslateX;
        private System.Windows.Forms.TrackBar sliderTranslateX;
        private System.Windows.Forms.Label labelTranslateXValue;
        private System.Windows.Forms.Label labelTranslateY;
        private System.Windows.Forms.TrackBar sliderTranslateY;
        private System.Windows.Forms.Label labelTranslateYValue;
        private System.Windows.Forms.Label labelTranslateZ;
        private System.Windows.Forms.TrackBar sliderTranslateZ;
        private System.Windows.Forms.Label labelTranslateZValue;
        private System.Windows.Forms.Label labelRotateX;
        private System.Windows.Forms.TrackBar sliderRotateX;
        private System.Windows.Forms.Label labelRotateXValue;
        private System.Windows.Forms.Label labelRotateY;
        private System.Windows.Forms.TrackBar sliderRotateY;
        private System.Windows.Forms.Label labelRotateYValue;
        private System.Windows.Forms.Label labelRotateZ;
        private System.Windows.Forms.TrackBar sliderRotateZ;
        private System.Windows.Forms.Label labelRotateZValue;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TrackBar sliderScale;
        private System.Windows.Forms.Label labelScaleValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControls = new System.Windows.Forms.Panel();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();

            this.labelTranslateX = new System.Windows.Forms.Label();
            this.sliderTranslateX = new System.Windows.Forms.TrackBar();
            this.labelTranslateXValue = new System.Windows.Forms.Label();
            this.labelTranslateY = new System.Windows.Forms.Label();
            this.sliderTranslateY = new System.Windows.Forms.TrackBar();
            this.labelTranslateYValue = new System.Windows.Forms.Label();
            this.labelTranslateZ = new System.Windows.Forms.Label();
            this.sliderTranslateZ = new System.Windows.Forms.TrackBar();
            this.labelTranslateZValue = new System.Windows.Forms.Label();

            this.labelRotateX = new System.Windows.Forms.Label();
            this.sliderRotateX = new System.Windows.Forms.TrackBar();
            this.labelRotateXValue = new System.Windows.Forms.Label();
            this.labelRotateY = new System.Windows.Forms.Label();
            this.sliderRotateY = new System.Windows.Forms.TrackBar();
            this.labelRotateYValue = new System.Windows.Forms.Label();
            this.labelRotateZ = new System.Windows.Forms.Label();
            this.sliderRotateZ = new System.Windows.Forms.TrackBar();
            this.labelRotateZValue = new System.Windows.Forms.Label();

            this.labelScale = new System.Windows.Forms.Label();
            this.sliderScale = new System.Windows.Forms.TrackBar();
            this.labelScaleValue = new System.Windows.Forms.Label();

            // Panel Controls
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls.Width = 250;

            // ComboBox for figure selection
            this.comboBoxFigures.Items.AddRange(new object[] { "Cubo", "Piramide" });
            this.comboBoxFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigures.Location = new System.Drawing.Point(20, 20);
            this.comboBoxFigures.Width = 200;

            // Setup sliders and labels
            int top = 60;
            int spacing = 60;

            void SetupSlider(Control label, Control slider, Control value, string text)
            {
                label.Text = text;
                label.ForeColor = System.Drawing.Color.White;
                label.Location = new System.Drawing.Point(20, top);

                slider.Location = new System.Drawing.Point(20, top + 20);
                slider.Width = 150;
                if (slider is TrackBar tb)
                {
                    tb.Minimum = -100;
                    tb.Maximum = 100;
                    tb.TickStyle = System.Windows.Forms.TickStyle.None;
                }

                value.Location = new System.Drawing.Point(180, top);
                value.ForeColor = System.Drawing.Color.LightCyan;
                top += spacing;
            }

            SetupSlider(labelTranslateX, sliderTranslateX, labelTranslateXValue, "Traslación X");
            SetupSlider(labelTranslateY, sliderTranslateY, labelTranslateYValue, "Traslación Y");
            SetupSlider(labelTranslateZ, sliderTranslateZ, labelTranslateZValue, "Traslación Z");
            SetupSlider(labelRotateX, sliderRotateX, labelRotateXValue, "Rotación X");
            SetupSlider(labelRotateY, sliderRotateY, labelRotateYValue, "Rotación Y");
            SetupSlider(labelRotateZ, sliderRotateZ, labelRotateZValue, "Rotación Z");

            labelScale.Text = "Escala";
            labelScale.ForeColor = System.Drawing.Color.White;
            labelScale.Location = new System.Drawing.Point(20, top);

            sliderScale.Location = new System.Drawing.Point(20, top + 20);
            sliderScale.Width = 150;
            sliderScale.Minimum = 1;
            sliderScale.Maximum = 200;
            sliderScale.Value = 100;
            sliderScale.TickStyle = System.Windows.Forms.TickStyle.None;

            labelScaleValue.Location = new System.Drawing.Point(180, top);
            labelScaleValue.ForeColor = System.Drawing.Color.LightCyan;

            // Add all to panelControls
            this.panelControls.Controls.Add(comboBoxFigures);
            this.panelControls.Controls.Add(labelTranslateX);
            this.panelControls.Controls.Add(sliderTranslateX);
            this.panelControls.Controls.Add(labelTranslateXValue);
            this.panelControls.Controls.Add(labelTranslateY);
            this.panelControls.Controls.Add(sliderTranslateY);
            this.panelControls.Controls.Add(labelTranslateYValue);
            this.panelControls.Controls.Add(labelTranslateZ);
            this.panelControls.Controls.Add(sliderTranslateZ);
            this.panelControls.Controls.Add(labelTranslateZValue);
            this.panelControls.Controls.Add(labelRotateX);
            this.panelControls.Controls.Add(sliderRotateX);
            this.panelControls.Controls.Add(labelRotateXValue);
            this.panelControls.Controls.Add(labelRotateY);
            this.panelControls.Controls.Add(sliderRotateY);
            this.panelControls.Controls.Add(labelRotateYValue);
            this.panelControls.Controls.Add(labelRotateZ);
            this.panelControls.Controls.Add(sliderRotateZ);
            this.panelControls.Controls.Add(labelRotateZValue);
            this.panelControls.Controls.Add(labelScale);
            this.panelControls.Controls.Add(sliderScale);
            this.panelControls.Controls.Add(labelScaleValue);

            this.Controls.Add(panelControls);
            this.Text = "Explorador de Figuras 3D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
