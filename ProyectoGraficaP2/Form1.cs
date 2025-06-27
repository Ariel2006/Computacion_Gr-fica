using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    public partial class Form1 : Form
    {
        private List<Point3D> vertices;
        private List<(int, int)> edges;

        private float angleX = 0;
        private float angleY = 0;
        private float angleZ = 0;

        private float scale = 1;
        private float translateX = 0;
        private float translateY = 0;
        private float translateZ = 0;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.FromArgb(28, 28, 38);

            comboBoxFigures.SelectedIndexChanged += (s, e) => { SetFigure(comboBoxFigures.SelectedItem.ToString()); Invalidate(); };
            sliderTranslateX.Scroll += SliderTranslate_Scroll;
            sliderTranslateY.Scroll += SliderTranslate_Scroll;
            sliderTranslateZ.Scroll += SliderTranslate_Scroll;
            sliderRotateX.Scroll += SliderRotate_Scroll;
            sliderRotateY.Scroll += SliderRotate_Scroll;
            sliderRotateZ.Scroll += SliderRotate_Scroll;
            sliderScale.Scroll += SliderScale_Scroll;

            comboBoxFigures.Items.AddRange(new object[] { "Cubo", "Piramide", "Esfera", "Cono", "Cilindro" });
            comboBoxFigures.SelectedIndex = 0;

            comboBoxFigures.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFigures.FlatStyle = FlatStyle.Flat;
            comboBoxFigures.BackColor = Color.FromArgb(60, 60, 80);
            comboBoxFigures.ForeColor = Color.White;

            foreach (Control ctrl in panelControls.Controls)
            {
                if (ctrl is TrackBar slider)
                {
                    slider.BackColor = Color.FromArgb(28, 28, 38);
                }
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.LightCyan;
                }
            }
        }

        private void SetFigure(string figure)
        {
            vertices = new List<Point3D>();
            edges = new List<(int, int)>();

            switch (figure)
            {
                case "Cubo":
                    vertices.AddRange(new[] {
                        new Point3D(-1,-1,-1), new Point3D(1,-1,-1), new Point3D(1,1,-1), new Point3D(-1,1,-1),
                        new Point3D(-1,-1,1),  new Point3D(1,-1,1),  new Point3D(1,1,1),  new Point3D(-1,1,1)
                    });
                    edges.AddRange(new[] {
                        (0,1),(1,2),(2,3),(3,0),(4,5),(5,6),(6,7),(7,4),(0,4),(1,5),(2,6),(3,7)
                    });
                    break;
                case "Piramide":
                    vertices.AddRange(new[] {
                        new Point3D(-1, -1, -1), new Point3D(1, -1, -1), new Point3D(1, -1, 1), new Point3D(-1, -1, 1),
                        new Point3D(0, 1.5f, 0)
                    });
                    edges.AddRange(new[] {
                        (0,1),(1,2),(2,3),(3,0),(0,4),(1,4),(2,4),(3,4)
                    });
                    break;
                case "Esfera":
                    int latitudes = 10, longitudes = 10;
                    for (int lat = 0; lat <= latitudes; lat++)
                    {
                        double theta = lat * Math.PI / latitudes;
                        for (int lon = 0; lon <= longitudes; lon++)
                        {
                            double phi = lon * 2 * Math.PI / longitudes;
                            float x = (float)(Math.Sin(theta) * Math.Cos(phi));
                            float y = (float)Math.Cos(theta);
                            float z = (float)(Math.Sin(theta) * Math.Sin(phi));
                            vertices.Add(new Point3D(x, y, z));
                        }
                    }
                    for (int lat = 0; lat < latitudes; lat++)
                    {
                        for (int lon = 0; lon < longitudes; lon++)
                        {
                            int current = lat * (longitudes + 1) + lon;
                            int next = current + longitudes + 1;
                            edges.Add((current, current + 1));
                            edges.Add((current, next));
                        }
                    }
                    break;
                case "Cono":
                    int coneSegments = 20;
                    for (int i = 0; i < coneSegments; i++)
                    {
                        double angle = 2 * Math.PI * i / coneSegments;
                        vertices.Add(new Point3D((float)Math.Cos(angle), -1, (float)Math.Sin(angle)));
                    }
                    vertices.Add(new Point3D(0, 1.5f, 0));
                    for (int i = 0; i < coneSegments; i++)
                    {
                        edges.Add((i, (i + 1) % coneSegments));
                        edges.Add((i, coneSegments));
                    }
                    break;
                case "Cilindro":
                    int cylSegments = 20;
                    for (int i = 0; i < cylSegments; i++)
                    {
                        double angle = 2 * Math.PI * i / cylSegments;
                        vertices.Add(new Point3D((float)Math.Cos(angle), -1, (float)Math.Sin(angle)));
                        vertices.Add(new Point3D((float)Math.Cos(angle), 1, (float)Math.Sin(angle)));
                    }
                    for (int i = 0; i < cylSegments; i++)
                    {
                        int base1 = i * 2;
                        int base2 = (i * 2 + 2) % (cylSegments * 2);
                        edges.Add((base1, base2));
                        edges.Add((base1 + 1, (base2 + 1) % (cylSegments * 2)));
                        edges.Add((base1, base1 + 1));
                    }
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.FromArgb(28, 28, 38));

            float centerX = (this.ClientSize.Width - panelControls.Width) / 2 + panelControls.Width / 2;
            float centerY = this.ClientSize.Height / 2;

            List<PointF> points2D = new List<PointF>();
            foreach (var v in vertices)
            {
                Point3D rotated = RotatePoint(new Point3D(v.X, v.Y, v.Z), angleX, angleY, angleZ);
                Point3D translated = new Point3D(rotated.X + translateX / 50, rotated.Y + translateY / 50, rotated.Z + translateZ / 50);
                float distance = 4f;
                float z = 1 / (distance - translated.Z);
                float x2d = translated.X * z * scale * 120 + centerX;
                float y2d = translated.Y * z * scale * 120 + centerY;
                points2D.Add(new PointF(x2d, y2d));
            }

            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0), new Point(0, this.ClientSize.Height),
                Color.Cyan, Color.Blue))
            using (Pen pen = new Pen(brush, 2))
            {
                foreach (var (i1, i2) in edges)
                    g.DrawLine(pen, points2D[i1], points2D[i2]);
            }

            using (SolidBrush brush = new SolidBrush(Color.LightCyan))
            {
                foreach (var pt in points2D)
                {
                    g.FillEllipse(brush, pt.X - 3, pt.Y - 3, 6, 6);
                    g.DrawEllipse(Pens.Cyan, pt.X - 4, pt.Y - 4, 8, 8);
                }
            }
        }

        private Point3D RotatePoint(Point3D p, float angleXDeg, float angleYDeg, float angleZDeg)
        {
            double radX = angleXDeg * Math.PI / 180;
            double radY = angleYDeg * Math.PI / 180;
            double radZ = angleZDeg * Math.PI / 180;

            double cosa = Math.Cos(radX), sina = Math.Sin(radX);
            double y = p.Y * cosa - p.Z * sina;
            double z = p.Y * sina + p.Z * cosa;
            p.Y = (float)y; p.Z = (float)z;

            cosa = Math.Cos(radY); sina = Math.Sin(radY);
            double x = p.X * cosa + p.Z * sina;
            z = -p.X * sina + p.Z * cosa;
            p.X = (float)x; p.Z = (float)z;

            cosa = Math.Cos(radZ); sina = Math.Sin(radZ);
            x = p.X * cosa - p.Y * sina;
            y = p.X * sina + p.Y * cosa;
            p.X = (float)x; p.Y = (float)y;

            return p;
        }

        private void SliderTranslate_Scroll(object sender, EventArgs e)
        {
            translateX = sliderTranslateX.Value;
            translateY = sliderTranslateY.Value;
            translateZ = sliderTranslateZ.Value;
            UpdateTranslateLabels();
            Invalidate();
        }

        private void SliderRotate_Scroll(object sender, EventArgs e)
        {
            angleX = sliderRotateX.Value;
            angleY = sliderRotateY.Value;
            angleZ = sliderRotateZ.Value;
            UpdateRotateLabels();
            Invalidate();
        }

        private void SliderScale_Scroll(object sender, EventArgs e)
        {
            scale = sliderScale.Value / 100f;
            UpdateScaleLabel();
            Invalidate();
        }

        private void UpdateTranslateLabels()
        {
            labelTranslateXValue.Text = translateX.ToString();
            labelTranslateYValue.Text = translateY.ToString();
            labelTranslateZValue.Text = translateZ.ToString();
        }

        private void UpdateRotateLabels()
        {
            labelRotateXValue.Text = angleX.ToString();
            labelRotateYValue.Text = angleY.ToString();
            labelRotateZValue.Text = angleZ.ToString();
        }

        private void UpdateScaleLabel()
        {
            labelScaleValue.Text = scale.ToString("F2");
        }
    }

    public class Point3D
    {
        public float X, Y, Z;
        public Point3D(float x, float y, float z) { X = x; Y = y; Z = z; }
    }
}