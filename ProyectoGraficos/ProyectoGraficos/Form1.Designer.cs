namespace ProyectoGraficos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.shapeGroup = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnApplyClip = new System.Windows.Forms.Button();
            this.btnFinishCurve = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnClip = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnColorFill = new System.Windows.Forms.Button();
            this.btnColorContour = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.ellipseGroup = new System.Windows.Forms.GroupBox();
            this.numRY = new System.Windows.Forms.NumericUpDown();
            this.lblRY = new System.Windows.Forms.Label();
            this.numRX = new System.Windows.Forms.NumericUpDown();
            this.lblRX = new System.Windows.Forms.Label();
            this.circleGroup = new System.Windows.Forms.GroupBox();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lineGroup = new System.Windows.Forms.GroupBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.algorithmGroup = new System.Windows.Forms.GroupBox();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.controlsPanel.SuspendLayout();
            this.shapeGroup.SuspendLayout();
            this.ellipseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRX)).BeginInit();
            this.circleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            this.lineGroup.SuspendLayout();
            this.algorithmGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Location = new System.Drawing.Point(16, 15);
            this.panelCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(799, 738);
            this.panelCanvas.TabIndex = 0;
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.controlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlsPanel.Controls.Add(this.shapeGroup);
            this.controlsPanel.Controls.Add(this.ellipseGroup);
            this.controlsPanel.Controls.Add(this.circleGroup);
            this.controlsPanel.Controls.Add(this.lineGroup);
            this.controlsPanel.Controls.Add(this.algorithmGroup);
            this.controlsPanel.Location = new System.Drawing.Point(824, 15);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(333, 738);
            this.controlsPanel.TabIndex = 1;
            // 
            // shapeGroup
            // 
            this.shapeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeGroup.Controls.Add(this.btnDelete);
            this.shapeGroup.Controls.Add(this.btnApplyClip);
            this.shapeGroup.Controls.Add(this.btnFinishCurve);
            this.shapeGroup.Controls.Add(this.btnAddPoint);
            this.shapeGroup.Controls.Add(this.btnClip);
            this.shapeGroup.Controls.Add(this.btnSelect);
            this.shapeGroup.Controls.Add(this.btnColorFill);
            this.shapeGroup.Controls.Add(this.btnColorContour);
            this.shapeGroup.Controls.Add(this.btnFill);
            this.shapeGroup.Controls.Add(this.btnDraw);
            this.shapeGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeGroup.Location = new System.Drawing.Point(13, 394);
            this.shapeGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shapeGroup.Name = "shapeGroup";
            this.shapeGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shapeGroup.Size = new System.Drawing.Size(307, 326);
            this.shapeGroup.TabIndex = 4;
            this.shapeGroup.TabStop = false;
            this.shapeGroup.Text = "Acciones";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(13, 277);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(280, 37);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Borrar Selección";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnApplyClip
            // 
            this.btnApplyClip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyClip.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApplyClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyClip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyClip.ForeColor = System.Drawing.Color.White;
            this.btnApplyClip.Location = new System.Drawing.Point(13, 326);
            this.btnApplyClip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApplyClip.Name = "btnApplyClip";
            this.btnApplyClip.Size = new System.Drawing.Size(280, 37);
            this.btnApplyClip.TabIndex = 23;
            this.btnApplyClip.Text = "Aplicar Recorte";
            this.btnApplyClip.UseVisualStyleBackColor = false;
            this.btnApplyClip.Click += new System.EventHandler(this.btnApplyClip_Click);
            // 
            // btnFinishCurve
            // 
            this.btnFinishCurve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishCurve.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinishCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishCurve.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishCurve.ForeColor = System.Drawing.Color.White;
            this.btnFinishCurve.Location = new System.Drawing.Point(160, 228);
            this.btnFinishCurve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinishCurve.Name = "btnFinishCurve";
            this.btnFinishCurve.Size = new System.Drawing.Size(133, 37);
            this.btnFinishCurve.TabIndex = 22;
            this.btnFinishCurve.Text = "Terminar Curva";
            this.btnFinishCurve.UseVisualStyleBackColor = false;
            this.btnFinishCurve.Visible = false;
            this.btnFinishCurve.Click += new System.EventHandler(this.btnFinishCurve_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPoint.ForeColor = System.Drawing.Color.White;
            this.btnAddPoint.Location = new System.Drawing.Point(13, 228);
            this.btnAddPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(133, 37);
            this.btnAddPoint.TabIndex = 21;
            this.btnAddPoint.Text = "Agregar Punto";
            this.btnAddPoint.UseVisualStyleBackColor = false;
            this.btnAddPoint.Visible = false;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnClip
            // 
            this.btnClip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClip.BackColor = System.Drawing.Color.IndianRed;
            this.btnClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClip.ForeColor = System.Drawing.Color.White;
            this.btnClip.Location = new System.Drawing.Point(160, 178);
            this.btnClip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(133, 37);
            this.btnClip.TabIndex = 20;
            this.btnClip.Text = "Recortar";
            this.btnClip.UseVisualStyleBackColor = false;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.SlateGray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(13, 178);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(133, 37);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnColorFill
            // 
            this.btnColorFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorFill.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnColorFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorFill.ForeColor = System.Drawing.Color.White;
            this.btnColorFill.Location = new System.Drawing.Point(160, 129);
            this.btnColorFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColorFill.Name = "btnColorFill";
            this.btnColorFill.Size = new System.Drawing.Size(133, 37);
            this.btnColorFill.TabIndex = 18;
            this.btnColorFill.Text = "Color Relleno";
            this.btnColorFill.UseVisualStyleBackColor = false;
            this.btnColorFill.Click += new System.EventHandler(this.btnColorFill_Click);
            // 
            // btnColorContour
            // 
            this.btnColorContour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorContour.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnColorContour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorContour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorContour.ForeColor = System.Drawing.Color.White;
            this.btnColorContour.Location = new System.Drawing.Point(13, 129);
            this.btnColorContour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColorContour.Name = "btnColorContour";
            this.btnColorContour.Size = new System.Drawing.Size(133, 37);
            this.btnColorContour.TabIndex = 17;
            this.btnColorContour.Text = "Color Contorno";
            this.btnColorContour.UseVisualStyleBackColor = false;
            this.btnColorContour.Click += new System.EventHandler(this.btnColorContour_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(13, 80);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(280, 37);
            this.btnFill.TabIndex = 16;
            this.btnFill.Text = "Rellenar";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraw.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.White;
            this.btnDraw.Location = new System.Drawing.Point(13, 31);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(280, 37);
            this.btnDraw.TabIndex = 15;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // ellipseGroup
            // 
            this.ellipseGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ellipseGroup.Controls.Add(this.numRY);
            this.ellipseGroup.Controls.Add(this.lblRY);
            this.ellipseGroup.Controls.Add(this.numRX);
            this.ellipseGroup.Controls.Add(this.lblRX);
            this.ellipseGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipseGroup.Location = new System.Drawing.Point(13, 295);
            this.ellipseGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ellipseGroup.Name = "ellipseGroup";
            this.ellipseGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ellipseGroup.Size = new System.Drawing.Size(307, 86);
            this.ellipseGroup.TabIndex = 3;
            this.ellipseGroup.TabStop = false;
            this.ellipseGroup.Text = "Elipse";
            this.ellipseGroup.Visible = false;
            // 
            // numRY
            // 
            this.numRY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRY.Location = new System.Drawing.Point(213, 37);
            this.numRY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numRY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numRY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRY.Name = "numRY";
            this.numRY.Size = new System.Drawing.Size(80, 27);
            this.numRY.TabIndex = 14;
            this.numRY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblRY
            // 
            this.lblRY.AutoSize = true;
            this.lblRY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRY.Location = new System.Drawing.Point(173, 43);
            this.lblRY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRY.Name = "lblRY";
            this.lblRY.Size = new System.Drawing.Size(29, 20);
            this.lblRY.TabIndex = 13;
            this.lblRY.Text = "RY:";
            // 
            // numRX
            // 
            this.numRX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRX.Location = new System.Drawing.Point(80, 37);
            this.numRX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numRX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numRX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRX.Name = "numRX";
            this.numRX.Size = new System.Drawing.Size(80, 27);
            this.numRX.TabIndex = 12;
            this.numRX.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // lblRX
            // 
            this.lblRX.AutoSize = true;
            this.lblRX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRX.Location = new System.Drawing.Point(40, 43);
            this.lblRX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRX.Name = "lblRX";
            this.lblRX.Size = new System.Drawing.Size(30, 20);
            this.lblRX.TabIndex = 11;
            this.lblRX.Text = "RX:";
            // 
            // circleGroup
            // 
            this.circleGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleGroup.Controls.Add(this.numRadius);
            this.circleGroup.Controls.Add(this.lblRadius);
            this.circleGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleGroup.Location = new System.Drawing.Point(13, 295);
            this.circleGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleGroup.Name = "circleGroup";
            this.circleGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleGroup.Size = new System.Drawing.Size(307, 86);
            this.circleGroup.TabIndex = 2;
            this.circleGroup.TabStop = false;
            this.circleGroup.Text = "Círculo";
            this.circleGroup.Visible = false;
            // 
            // numRadius
            // 
            this.numRadius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRadius.Location = new System.Drawing.Point(107, 37);
            this.numRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numRadius.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numRadius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(80, 27);
            this.numRadius.TabIndex = 10;
            this.numRadius.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(40, 43);
            this.lblRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(51, 20);
            this.lblRadius.TabIndex = 9;
            this.lblRadius.Text = "Radio:";
            // 
            // lineGroup
            // 
            this.lineGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineGroup.Controls.Add(this.txtY2);
            this.lineGroup.Controls.Add(this.txtX2);
            this.lineGroup.Controls.Add(this.lblPoint2);
            this.lineGroup.Controls.Add(this.txtY1);
            this.lineGroup.Controls.Add(this.txtX1);
            this.lineGroup.Controls.Add(this.lblPoint1);
            this.lineGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineGroup.Location = new System.Drawing.Point(13, 98);
            this.lineGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineGroup.Name = "lineGroup";
            this.lineGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineGroup.Size = new System.Drawing.Size(307, 185);
            this.lineGroup.TabIndex = 1;
            this.lineGroup.TabStop = false;
            this.lineGroup.Text = "Coordenadas";
            // 
            // txtY2
            // 
            this.txtY2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY2.Location = new System.Drawing.Point(213, 123);
            this.txtY2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(79, 27);
            this.txtY2.TabIndex = 8;
            this.txtY2.Text = "200";
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(107, 123);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(79, 27);
            this.txtX2.TabIndex = 7;
            this.txtX2.Text = "200";
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint2.Location = new System.Drawing.Point(27, 129);
            this.lblPoint2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(62, 20);
            this.lblPoint2.TabIndex = 6;
            this.lblPoint2.Text = "Punto 2:";
            // 
            // txtY1
            // 
            this.txtY1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY1.Location = new System.Drawing.Point(213, 62);
            this.txtY1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(79, 27);
            this.txtY1.TabIndex = 5;
            this.txtY1.Text = "100";
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(107, 62);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(79, 27);
            this.txtX1.TabIndex = 4;
            this.txtX1.Text = "100";
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint1.Location = new System.Drawing.Point(27, 68);
            this.lblPoint1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(62, 20);
            this.lblPoint1.TabIndex = 3;
            this.lblPoint1.Text = "Punto 1:";
            // 
            // algorithmGroup
            // 
            this.algorithmGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmGroup.Controls.Add(this.cmbAlgorithm);
            this.algorithmGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmGroup.Location = new System.Drawing.Point(13, 12);
            this.algorithmGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.algorithmGroup.Name = "algorithmGroup";
            this.algorithmGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.algorithmGroup.Size = new System.Drawing.Size(307, 74);
            this.algorithmGroup.TabIndex = 0;
            this.algorithmGroup.TabStop = false;
            this.algorithmGroup.Text = "Algoritmo";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(27, 31);
            this.cmbAlgorithm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(265, 28);
            this.cmbAlgorithm.TabIndex = 1;
            this.cmbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cmbAlgorithm_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 764);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.panelCanvas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1194, 801);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Gráfico Avanzado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlsPanel.ResumeLayout(false);
            this.shapeGroup.ResumeLayout(false);
            this.ellipseGroup.ResumeLayout(false);
            this.ellipseGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRX)).EndInit();
            this.circleGroup.ResumeLayout(false);
            this.circleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            this.lineGroup.ResumeLayout(false);
            this.lineGroup.PerformLayout();
            this.algorithmGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.GroupBox algorithmGroup;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.GroupBox lineGroup;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.GroupBox circleGroup;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.GroupBox ellipseGroup;
        private System.Windows.Forms.NumericUpDown numRY;
        private System.Windows.Forms.Label lblRY;
        private System.Windows.Forms.NumericUpDown numRX;
        private System.Windows.Forms.Label lblRX;
        private System.Windows.Forms.GroupBox shapeGroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnApplyClip;
        private System.Windows.Forms.Button btnFinishCurve;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnColorFill;
        private System.Windows.Forms.Button btnColorContour;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}