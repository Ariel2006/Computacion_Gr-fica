namespace FigurasGeometricas
{
     
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.Label lblLadoD;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtLadoD;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.lblLadoD = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtLadoD = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFigura.Location = new System.Drawing.Point(203, 49);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(200, 31);
            this.cmbFigura.TabIndex = 1;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeleccion.Location = new System.Drawing.Point(12, 49);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(199, 21);
            this.lblSeleccion.TabIndex = 0;
            this.lblSeleccion.Text = "Seleccione la figura:";
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoA.Location = new System.Drawing.Point(31, 86);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(73, 21);
            this.lblLadoA.TabIndex = 2;
            this.lblLadoA.Text = "Lado A:";
            this.lblLadoA.Visible = false;
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoB.Location = new System.Drawing.Point(30, 127);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(73, 21);
            this.lblLadoB.TabIndex = 4;
            this.lblLadoB.Text = "Lado B:";
            this.lblLadoB.Visible = false;
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoC.Location = new System.Drawing.Point(29, 167);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(73, 21);
            this.lblLadoC.TabIndex = 6;
            this.lblLadoC.Text = "Lado C:";
            this.lblLadoC.Visible = false;
            // 
            // lblLadoD
            // 
            this.lblLadoD.AutoSize = true;
            this.lblLadoD.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoD.Location = new System.Drawing.Point(30, 208);
            this.lblLadoD.Name = "lblLadoD";
            this.lblLadoD.Size = new System.Drawing.Size(73, 21);
            this.lblLadoD.TabIndex = 8;
            this.lblLadoD.Text = "Lado D:";
            this.lblLadoD.Visible = false;
            // 
            // txtLadoA
            // 
            this.txtLadoA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLadoA.Location = new System.Drawing.Point(180, 83);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(150, 30);
            this.txtLadoA.TabIndex = 3;
            this.txtLadoA.Visible = false;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLadoB.Location = new System.Drawing.Point(180, 127);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(150, 30);
            this.txtLadoB.TabIndex = 5;
            this.txtLadoB.Visible = false;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLadoC.Location = new System.Drawing.Point(180, 169);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(150, 30);
            this.txtLadoC.TabIndex = 7;
            this.txtLadoC.Visible = false;
            // 
            // txtLadoD
            // 
            this.txtLadoD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLadoD.Location = new System.Drawing.Point(180, 205);
            this.txtLadoD.Name = "txtLadoD";
            this.txtLadoD.Size = new System.Drawing.Size(150, 30);
            this.txtLadoD.TabIndex = 9;
            this.txtLadoD.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcular.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(117, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(300, 35);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Área y Perímetro";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(31, 305);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 22);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Font = new System.Drawing.Font("Victor Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(175, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 21);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Calculadora de Área y Perimetro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(583, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.cmbFigura);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblLadoD);
            this.Controls.Add(this.txtLadoD);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Font = new System.Drawing.Font("Victor Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Cálculo Geométrico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
