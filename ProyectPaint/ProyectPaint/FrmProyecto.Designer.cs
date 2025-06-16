namespace ProyectPaint
{
    partial class FrmProyecto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox panelCanvas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnDrawColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.ListBox listBoxPixels;
        private System.Windows.Forms.RadioButton RbLine;
        private System.Windows.Forms.RadioButton RbCircle;
        private System.Windows.Forms.RadioButton RbFill;
        private System.Windows.Forms.RadioButton RbDDA;
        private System.Windows.Forms.RadioButton RbBresenham;
        private System.Windows.Forms.GroupBox grpDrawingMode;
        private System.Windows.Forms.GroupBox grpAlgorithm;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.GroupBox grpPixels;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordinates;
        private System.Windows.Forms.ProgressBar btnProgress;
        private System.Windows.Forms.CheckBox chkAnimation;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label lblDrawColor;
        private System.Windows.Forms.Label lblFillColor;

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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.panelCanvas = new System.Windows.Forms.PictureBox();
            this.grpDrawingMode = new System.Windows.Forms.GroupBox();
            this.RbLine = new System.Windows.Forms.RadioButton();
            this.RbCircle = new System.Windows.Forms.RadioButton();
            this.RbFill = new System.Windows.Forms.RadioButton();
            this.grpAlgorithm = new System.Windows.Forms.GroupBox();
            this.RbDDA = new System.Windows.Forms.RadioButton();
            this.RbBresenham = new System.Windows.Forms.RadioButton();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.lblDrawColor = new System.Windows.Forms.Label();
            this.btnDrawColor = new System.Windows.Forms.Button();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.grpPixels = new System.Windows.Forms.GroupBox();
            this.listBoxPixels = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.chkAnimation = new System.Windows.Forms.CheckBox();
            this.btnProgress = new System.Windows.Forms.ProgressBar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCanvas)).BeginInit();
            this.grpDrawingMode.SuspendLayout();
            this.grpAlgorithm.SuspendLayout();
            this.grpColors.SuspendLayout();
            this.grpPixels.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCanvas.Controls.Add(this.panelCanvas);
            this.pnlCanvas.Location = new System.Drawing.Point(12, 11);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(804, 544);
            this.pnlCanvas.TabIndex = 0;
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 0);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(800, 540);
            this.panelCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.panelCanvas.TabIndex = 0;
            this.panelCanvas.TabStop = false;
            // 
            // grpDrawingMode
            // 
            this.grpDrawingMode.Controls.Add(this.RbLine);
            this.grpDrawingMode.Controls.Add(this.RbCircle);
            this.grpDrawingMode.Controls.Add(this.RbFill);
            this.grpDrawingMode.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDrawingMode.ForeColor = System.Drawing.Color.White;
            this.grpDrawingMode.Location = new System.Drawing.Point(830, 11);
            this.grpDrawingMode.Name = "grpDrawingMode";
            this.grpDrawingMode.Size = new System.Drawing.Size(200, 90);
            this.grpDrawingMode.TabIndex = 1;
            this.grpDrawingMode.TabStop = false;
            this.grpDrawingMode.Text = "Modo de Dibujo";
            this.grpDrawingMode.Enter += new System.EventHandler(this.grpDrawingMode_Enter);
            // 
            // RbLine
            // 
            this.RbLine.AutoSize = true;
            this.RbLine.Checked = true;
            this.RbLine.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbLine.Location = new System.Drawing.Point(15, 22);
            this.RbLine.Name = "RbLine";
            this.RbLine.Size = new System.Drawing.Size(69, 22);
            this.RbLine.TabIndex = 0;
            this.RbLine.TabStop = true;
            this.RbLine.Text = "Línea";
            this.RbLine.UseVisualStyleBackColor = true;
            this.RbLine.CheckedChanged += new System.EventHandler(this.RbLine_CheckedChanged);
            // 
            // RbCircle
            // 
            this.RbCircle.AutoSize = true;
            this.RbCircle.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCircle.Location = new System.Drawing.Point(15, 45);
            this.RbCircle.Name = "RbCircle";
            this.RbCircle.Size = new System.Drawing.Size(85, 22);
            this.RbCircle.TabIndex = 1;
            this.RbCircle.Text = "Círculo";
            this.RbCircle.UseVisualStyleBackColor = true;
            this.RbCircle.CheckedChanged += new System.EventHandler(this.RbCircle_CheckedChanged);
            // 
            // RbFill
            // 
            this.RbFill.AutoSize = true;
            this.RbFill.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFill.Location = new System.Drawing.Point(15, 68);
            this.RbFill.Name = "RbFill";
            this.RbFill.Size = new System.Drawing.Size(93, 22);
            this.RbFill.TabIndex = 2;
            this.RbFill.Text = "Rellenar";
            this.RbFill.UseVisualStyleBackColor = true;
            this.RbFill.CheckedChanged += new System.EventHandler(this.RbFill_CheckedChanged);
            // 
            // grpAlgorithm
            // 
            this.grpAlgorithm.Controls.Add(this.RbDDA);
            this.grpAlgorithm.Controls.Add(this.RbBresenham);
            this.grpAlgorithm.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlgorithm.ForeColor = System.Drawing.Color.White;
            this.grpAlgorithm.Location = new System.Drawing.Point(830, 112);
            this.grpAlgorithm.Name = "grpAlgorithm";
            this.grpAlgorithm.Size = new System.Drawing.Size(200, 72);
            this.grpAlgorithm.TabIndex = 2;
            this.grpAlgorithm.TabStop = false;
            this.grpAlgorithm.Text = "Algoritmo de Línea";
            // 
            // RbDDA
            // 
            this.RbDDA.AutoSize = true;
            this.RbDDA.Checked = true;
            this.RbDDA.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbDDA.Location = new System.Drawing.Point(15, 22);
            this.RbDDA.Name = "RbDDA";
            this.RbDDA.Size = new System.Drawing.Size(53, 22);
            this.RbDDA.TabIndex = 0;
            this.RbDDA.TabStop = true;
            this.RbDDA.Text = "DDA";
            this.RbDDA.UseVisualStyleBackColor = true;
            this.RbDDA.CheckedChanged += new System.EventHandler(this.RbDDA_CheckedChanged);
            // 
            // RbBresenham
            // 
            this.RbBresenham.AutoSize = true;
            this.RbBresenham.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbBresenham.Location = new System.Drawing.Point(15, 45);
            this.RbBresenham.Name = "RbBresenham";
            this.RbBresenham.Size = new System.Drawing.Size(101, 22);
            this.RbBresenham.TabIndex = 1;
            this.RbBresenham.Text = "Bresenham";
            this.RbBresenham.UseVisualStyleBackColor = true;
            this.RbBresenham.CheckedChanged += new System.EventHandler(this.RbBresenham_CheckedChanged);
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.lblDrawColor);
            this.grpColors.Controls.Add(this.btnDrawColor);
            this.grpColors.Controls.Add(this.lblFillColor);
            this.grpColors.Controls.Add(this.btnFillColor);
            this.grpColors.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColors.ForeColor = System.Drawing.Color.White;
            this.grpColors.Location = new System.Drawing.Point(830, 194);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(200, 90);
            this.grpColors.TabIndex = 3;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Colores";
            // 
            // lblDrawColor
            // 
            this.lblDrawColor.AutoSize = true;
            this.lblDrawColor.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawColor.Location = new System.Drawing.Point(15, 22);
            this.lblDrawColor.Name = "lblDrawColor";
            this.lblDrawColor.Size = new System.Drawing.Size(64, 18);
            this.lblDrawColor.TabIndex = 0;
            this.lblDrawColor.Text = "Dibujo:";
            // 
            // btnDrawColor
            // 
            this.btnDrawColor.BackColor = System.Drawing.Color.Black;
            this.btnDrawColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawColor.Location = new System.Drawing.Point(80, 20);
            this.btnDrawColor.Name = "btnDrawColor";
            this.btnDrawColor.Size = new System.Drawing.Size(50, 21);
            this.btnDrawColor.TabIndex = 1;
            this.btnDrawColor.UseVisualStyleBackColor = false;
            this.btnDrawColor.Click += new System.EventHandler(this.btnDrawColor_Click);
            // 
            // lblFillColor
            // 
            this.lblFillColor.AutoSize = true;
            this.lblFillColor.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillColor.Location = new System.Drawing.Point(15, 54);
            this.lblFillColor.Name = "lblFillColor";
            this.lblFillColor.Size = new System.Drawing.Size(72, 18);
            this.lblFillColor.TabIndex = 2;
            this.lblFillColor.Text = "Relleno:";
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.Red;
            this.btnFillColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillColor.Location = new System.Drawing.Point(80, 51);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(50, 21);
            this.btnFillColor.TabIndex = 3;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // grpPixels
            // 
            this.grpPixels.Controls.Add(this.listBoxPixels);
            this.grpPixels.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPixels.ForeColor = System.Drawing.Color.White;
            this.grpPixels.Location = new System.Drawing.Point(830, 342);
            this.grpPixels.Name = "grpPixels";
            this.grpPixels.Size = new System.Drawing.Size(200, 162);
            this.grpPixels.TabIndex = 4;
            this.grpPixels.TabStop = false;
            this.grpPixels.Text = "Píxeles Dibujados";
            // 
            // listBoxPixels
            // 
            this.listBoxPixels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPixels.Font = new System.Drawing.Font("Victor Mono SemiBold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPixels.FormattingEnabled = true;
            this.listBoxPixels.ItemHeight = 16;
            this.listBoxPixels.Location = new System.Drawing.Point(3, 25);
            this.listBoxPixels.Name = "listBoxPixels";
            this.listBoxPixels.Size = new System.Drawing.Size(194, 134);
            this.listBoxPixels.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(830, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "🗑️ Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveImage.FlatAppearance.BorderSize = 0;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveImage.Location = new System.Drawing.Point(935, 292);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(95, 32);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "💾 Guardar";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // chkAnimation
            // 
            this.chkAnimation.AutoSize = true;
            this.chkAnimation.Checked = true;
            this.chkAnimation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnimation.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnimation.ForeColor = System.Drawing.Color.White;
            this.chkAnimation.Location = new System.Drawing.Point(830, 513);
            this.chkAnimation.Name = "chkAnimation";
            this.chkAnimation.Size = new System.Drawing.Size(150, 22);
            this.chkAnimation.TabIndex = 7;
            this.chkAnimation.Text = "Animación suave";
            this.chkAnimation.UseVisualStyleBackColor = true;
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(830, 536);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(200, 14);
            this.btnProgress.TabIndex = 8;
            this.btnProgress.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCoordinates,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 559);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1050, 26);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 20);
            this.lblStatus.Text = "Listo";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(956, 20);
            this.lblCoordinates.Spring = true;
            this.lblCoordinates.Text = "X: 0, Y: 0";
            this.lblCoordinates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCoordinates.Click += new System.EventHandler(this.lblCoordinates_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // FrmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1050, 585);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.chkAnimation);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpPixels);
            this.Controls.Add(this.grpColors);
            this.Controls.Add(this.grpAlgorithm);
            this.Controls.Add(this.grpDrawingMode);
            this.Controls.Add(this.pnlCanvas);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Victor Mono SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProyectPaint - Editor Gráfico Mejorado";
            this.Load += new System.EventHandler(this.FrmProyecto_Load);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCanvas)).EndInit();
            this.grpDrawingMode.ResumeLayout(false);
            this.grpDrawingMode.PerformLayout();
            this.grpAlgorithm.ResumeLayout(false);
            this.grpAlgorithm.PerformLayout();
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.grpPixels.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}