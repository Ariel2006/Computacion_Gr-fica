using System;
using System.Threading;
using System.Windows.Forms;

namespace ProgresoProyectoScrum
{
    public partial class MainForm : Form
    {
        private int sprintIndex;
        private Sprint[] sprints;
        private ProgressBar progressBarGeneral;
        private ProgressBar[] sprintProgressBars;

        public MainForm()
        {
            InitializeComponent();

            sprints = new Sprint[]
            {
                new Sprint("Sprint 1", 1, 10, 1),
                new Sprint("Sprint 2", 3, 25, 3),
                new Sprint("Sprint 3", 3, 25, 3),
                new Sprint("Sprint 4", 2, 20, 2),
                new Sprint("Sprint 5", 2, 20, 2)
            };

            progressBarGeneral = new ProgressBar
            {
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(400, 30),
                Maximum = 100
            };

            sprintProgressBars = new ProgressBar[sprints.Length];
            for (int i = 0; i < sprints.Length; i++)
            {
                sprintProgressBars[i] = new ProgressBar
                {
                    Location = new System.Drawing.Point(12, 60 + i * 40),
                    Size = new System.Drawing.Size(400, 30),
                    Maximum = 100
                };
            }

            Controls.Add(progressBarGeneral);
            Controls.AddRange(sprintProgressBars);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(MostrarProgreso);
            thread.Start();
        }

        private void MostrarProgreso()
        {
            for (sprintIndex = 0; sprintIndex < sprints.Length; sprintIndex++)
            {
                Sprint sprint = sprints[sprintIndex];
                for (int porcentaje = 0; porcentaje <= sprint.Aporte; porcentaje++)
                {
                    MostrarAvanceSprint(sprintIndex, porcentaje, sprint.Duracion);
                    Thread.Sleep(sprint.Duracion * 1000 / sprint.Aporte);
                }
            }
        }

        private void MostrarAvanceSprint(int sprint, int porcentaje, int duracion)
        {
            MethodInvoker updateProgressBar = delegate
            {
                progressBarGeneral.Value = CalcularProgresoGeneral();
                sprintProgressBars[sprint].Value = porcentaje;
            };

            if (InvokeRequired)
                Invoke(updateProgressBar);
            else
                updateProgressBar();

            Thread.Sleep(duracion);
        }

        private int CalcularProgresoGeneral()
        {
            int progresoGeneral = 0;
            for (int i = 0; i <= sprintIndex; i++)
            {
                progresoGeneral += sprints[i].Aporte;
            }
            return progresoGeneral;
        }
    }

    public class Sprint
    {
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public int Aporte { get; set; }

        public Sprint(string nombre, int duracion, int aporte, int semanas)
        {
            Nombre = nombre;
            Duracion = duracion * semanas;
            Aporte = aporte;
        }
    }
}