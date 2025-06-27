namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.bntSumar = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicación = new System.Windows.Forms.Button();
            this.btnDivisión = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(164, 172);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(140, 22);
            this.txtNombre2.TabIndex = 0;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(404, 172);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(140, 22);
            this.txtNombre1.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(159, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(430, 25);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Bienvenido al mundo de las matématicas";
            this.txtNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntSumar
            // 
            this.bntSumar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bntSumar.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSumar.Location = new System.Drawing.Point(90, 265);
            this.bntSumar.Name = "bntSumar";
            this.bntSumar.Size = new System.Drawing.Size(88, 36);
            this.bntSumar.TabIndex = 3;
            this.bntSumar.Text = "Suma";
            this.bntSumar.UseVisualStyleBackColor = false;
            this.bntSumar.Click += new System.EventHandler(this.btnSumar);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(229, 266);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 35);
            this.btnResta.TabIndex = 4;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnRestar);
            // 
            // btnMultiplicación
            // 
            this.btnMultiplicación.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicación.Location = new System.Drawing.Point(350, 266);
            this.btnMultiplicación.Name = "btnMultiplicación";
            this.btnMultiplicación.Size = new System.Drawing.Size(174, 36);
            this.btnMultiplicación.TabIndex = 5;
            this.btnMultiplicación.Text = "Multiplicación";
            this.btnMultiplicación.UseVisualStyleBackColor = true;
            this.btnMultiplicación.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDivisión
            // 
            this.btnDivisión.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisión.Location = new System.Drawing.Point(557, 266);
            this.btnDivisión.Name = "btnDivisión";
            this.btnDivisión.Size = new System.Drawing.Size(111, 36);
            this.btnDivisión.TabIndex = 6;
            this.btnDivisión.Text = "División";
            this.btnDivisión.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(286, 365);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDivisión);
            this.Controls.Add(this.btnMultiplicación);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.bntSumar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.txtNombre2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button bntSumar;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicación;
        private System.Windows.Forms.Button btnDivisión;
        private System.Windows.Forms.Label lblResultado;
    }
}

