namespace diseños_ptc_6
{
    partial class FrmPrincipalDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalDoctores));
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlSubCita = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.pnlSubHistoriales = new System.Windows.Forms.Panel();
            this.btnAgregarHistoriales = new System.Windows.Forms.Button();
            this.btnListaHistoriales = new System.Windows.Forms.Button();
            this.btnHistoriales = new FontAwesome.Sharp.IconButton();
            this.pnlSubTratamientos = new System.Windows.Forms.Panel();
            this.btnAgregarTratamientos = new System.Windows.Forms.Button();
            this.btnListaTratamientos = new System.Windows.Forms.Button();
            this.btnTratamientos = new FontAwesome.Sharp.IconButton();
            this.pnlSubDiagnosticos = new System.Windows.Forms.Panel();
            this.btnAgregarDiagnosticos = new System.Windows.Forms.Button();
            this.btnListaDiagnosticos = new System.Windows.Forms.Button();
            this.btnDiagnosticos = new FontAwesome.Sharp.IconButton();
            this.btnExpedientes = new FontAwesome.Sharp.IconButton();
            this.pnlSubPacientes = new System.Windows.Forms.Panel();
            this.btnAgregarPacientes = new System.Windows.Forms.Button();
            this.btnListaPacientes = new System.Windows.Forms.Button();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.pnlSubCitas = new System.Windows.Forms.Panel();
            this.btnAgregarCitas = new System.Windows.Forms.Button();
            this.btnListaCitas = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbConfig = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.pnlSubCita.SuspendLayout();
            this.pnlSubHistoriales.SuspendLayout();
            this.pnlSubTratamientos.SuspendLayout();
            this.pnlSubDiagnosticos.SuspendLayout();
            this.pnlSubPacientes.SuspendLayout();
            this.pnlSubCitas.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChildForm.Controls.Add(this.pictureBox1);
            this.pnlChildForm.Location = new System.Drawing.Point(339, 2);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1105, 814);
            this.pnlChildForm.TabIndex = 2;
            this.pnlChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::diseños_ptc_6.Properties.Resources.logo_normal;
            this.pictureBox1.Location = new System.Drawing.Point(379, 260);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlLateral
            // 
            this.pnlLateral.AutoScroll = true;
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.pnlLateral.Controls.Add(this.btnCerrarSesion);
            this.pnlLateral.Controls.Add(this.pnlSubCita);
            this.pnlLateral.Controls.Add(this.btnCitas);
            this.pnlLateral.Controls.Add(this.pnlSubHistoriales);
            this.pnlLateral.Controls.Add(this.btnHistoriales);
            this.pnlLateral.Controls.Add(this.pnlSubTratamientos);
            this.pnlLateral.Controls.Add(this.btnTratamientos);
            this.pnlLateral.Controls.Add(this.pnlSubDiagnosticos);
            this.pnlLateral.Controls.Add(this.btnDiagnosticos);
            this.pnlLateral.Controls.Add(this.btnExpedientes);
            this.pnlLateral.Controls.Add(this.pnlSubPacientes);
            this.pnlLateral.Controls.Add(this.btnPacientes);
            this.pnlLateral.Controls.Add(this.pnlSubCitas);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(343, 814);
            this.pnlLateral.TabIndex = 3;
            // 
            // pnlSubCita
            // 
            this.pnlSubCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.pnlSubCita.Controls.Add(this.button1);
            this.pnlSubCita.Controls.Add(this.button2);
            this.pnlSubCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubCita.Location = new System.Drawing.Point(0, 846);
            this.pnlSubCita.Name = "pnlSubCita";
            this.pnlSubCita.Size = new System.Drawing.Size(322, 100);
            this.pnlSubCita.TabIndex = 36;
            this.pnlSubCita.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSubCita_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(322, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar cita";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(322, 49);
            this.button2.TabIndex = 12;
            this.button2.Text = "Lista de citas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.btnCitas.IconColor = System.Drawing.Color.Black;
            this.btnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(0, 791);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(322, 55);
            this.btnCitas.TabIndex = 32;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click_1);
            // 
            // pnlSubHistoriales
            // 
            this.pnlSubHistoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.pnlSubHistoriales.Controls.Add(this.btnAgregarHistoriales);
            this.pnlSubHistoriales.Controls.Add(this.btnListaHistoriales);
            this.pnlSubHistoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubHistoriales.Location = new System.Drawing.Point(0, 691);
            this.pnlSubHistoriales.Name = "pnlSubHistoriales";
            this.pnlSubHistoriales.Size = new System.Drawing.Size(322, 100);
            this.pnlSubHistoriales.TabIndex = 35;
            // 
            // btnAgregarHistoriales
            // 
            this.btnAgregarHistoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarHistoriales.FlatAppearance.BorderSize = 0;
            this.btnAgregarHistoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHistoriales.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHistoriales.Location = new System.Drawing.Point(0, 49);
            this.btnAgregarHistoriales.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarHistoriales.Name = "btnAgregarHistoriales";
            this.btnAgregarHistoriales.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAgregarHistoriales.Size = new System.Drawing.Size(322, 49);
            this.btnAgregarHistoriales.TabIndex = 13;
            this.btnAgregarHistoriales.Text = "Agregar historial";
            this.btnAgregarHistoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHistoriales.UseVisualStyleBackColor = true;
            this.btnAgregarHistoriales.Click += new System.EventHandler(this.btnAgregarHistoriales_Click_1);
            // 
            // btnListaHistoriales
            // 
            this.btnListaHistoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaHistoriales.FlatAppearance.BorderSize = 0;
            this.btnListaHistoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaHistoriales.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaHistoriales.Location = new System.Drawing.Point(0, 0);
            this.btnListaHistoriales.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaHistoriales.Name = "btnListaHistoriales";
            this.btnListaHistoriales.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnListaHistoriales.Size = new System.Drawing.Size(322, 49);
            this.btnListaHistoriales.TabIndex = 12;
            this.btnListaHistoriales.Text = "Lista de historiales";
            this.btnListaHistoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaHistoriales.UseVisualStyleBackColor = true;
            this.btnListaHistoriales.Click += new System.EventHandler(this.btnListaHistoriales_Click_1);
            // 
            // btnHistoriales
            // 
            this.btnHistoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnHistoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoriales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnHistoriales.FlatAppearance.BorderSize = 0;
            this.btnHistoriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnHistoriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnHistoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoriales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnHistoriales.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnHistoriales.IconColor = System.Drawing.Color.Black;
            this.btnHistoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistoriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoriales.Location = new System.Drawing.Point(0, 636);
            this.btnHistoriales.Name = "btnHistoriales";
            this.btnHistoriales.Size = new System.Drawing.Size(322, 55);
            this.btnHistoriales.TabIndex = 31;
            this.btnHistoriales.Text = "Historiales";
            this.btnHistoriales.UseVisualStyleBackColor = false;
            this.btnHistoriales.Click += new System.EventHandler(this.btnHistoriales_Click_1);
            // 
            // pnlSubTratamientos
            // 
            this.pnlSubTratamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.pnlSubTratamientos.Controls.Add(this.btnAgregarTratamientos);
            this.pnlSubTratamientos.Controls.Add(this.btnListaTratamientos);
            this.pnlSubTratamientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubTratamientos.Location = new System.Drawing.Point(0, 536);
            this.pnlSubTratamientos.Name = "pnlSubTratamientos";
            this.pnlSubTratamientos.Size = new System.Drawing.Size(322, 100);
            this.pnlSubTratamientos.TabIndex = 34;
            // 
            // btnAgregarTratamientos
            // 
            this.btnAgregarTratamientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarTratamientos.FlatAppearance.BorderSize = 0;
            this.btnAgregarTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTratamientos.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTratamientos.Location = new System.Drawing.Point(0, 49);
            this.btnAgregarTratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTratamientos.Name = "btnAgregarTratamientos";
            this.btnAgregarTratamientos.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAgregarTratamientos.Size = new System.Drawing.Size(322, 49);
            this.btnAgregarTratamientos.TabIndex = 13;
            this.btnAgregarTratamientos.Text = "Agregar tratamiento";
            this.btnAgregarTratamientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTratamientos.UseVisualStyleBackColor = true;
            this.btnAgregarTratamientos.Click += new System.EventHandler(this.btnAgregarTratamientos_Click_1);
            // 
            // btnListaTratamientos
            // 
            this.btnListaTratamientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaTratamientos.FlatAppearance.BorderSize = 0;
            this.btnListaTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaTratamientos.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaTratamientos.Location = new System.Drawing.Point(0, 0);
            this.btnListaTratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaTratamientos.Name = "btnListaTratamientos";
            this.btnListaTratamientos.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnListaTratamientos.Size = new System.Drawing.Size(322, 49);
            this.btnListaTratamientos.TabIndex = 12;
            this.btnListaTratamientos.Text = "Lista de tratamientos";
            this.btnListaTratamientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaTratamientos.UseVisualStyleBackColor = true;
            this.btnListaTratamientos.Click += new System.EventHandler(this.btnListaTratamientos_Click_1);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnTratamientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTratamientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnTratamientos.FlatAppearance.BorderSize = 0;
            this.btnTratamientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnTratamientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTratamientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnTratamientos.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.btnTratamientos.IconColor = System.Drawing.Color.Black;
            this.btnTratamientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTratamientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTratamientos.Location = new System.Drawing.Point(0, 481);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(322, 55);
            this.btnTratamientos.TabIndex = 30;
            this.btnTratamientos.Text = "Tratamientos";
            this.btnTratamientos.UseVisualStyleBackColor = false;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click_1);
            // 
            // pnlSubDiagnosticos
            // 
            this.pnlSubDiagnosticos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.pnlSubDiagnosticos.Controls.Add(this.btnAgregarDiagnosticos);
            this.pnlSubDiagnosticos.Controls.Add(this.btnListaDiagnosticos);
            this.pnlSubDiagnosticos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubDiagnosticos.Location = new System.Drawing.Point(0, 381);
            this.pnlSubDiagnosticos.Name = "pnlSubDiagnosticos";
            this.pnlSubDiagnosticos.Size = new System.Drawing.Size(322, 100);
            this.pnlSubDiagnosticos.TabIndex = 33;
            // 
            // btnAgregarDiagnosticos
            // 
            this.btnAgregarDiagnosticos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDiagnosticos.FlatAppearance.BorderSize = 0;
            this.btnAgregarDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDiagnosticos.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDiagnosticos.Location = new System.Drawing.Point(0, 49);
            this.btnAgregarDiagnosticos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDiagnosticos.Name = "btnAgregarDiagnosticos";
            this.btnAgregarDiagnosticos.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAgregarDiagnosticos.Size = new System.Drawing.Size(322, 49);
            this.btnAgregarDiagnosticos.TabIndex = 13;
            this.btnAgregarDiagnosticos.Text = "Agregar diagnóstico";
            this.btnAgregarDiagnosticos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDiagnosticos.UseVisualStyleBackColor = true;
            this.btnAgregarDiagnosticos.Click += new System.EventHandler(this.btnAgregarDiagnosticos_Click_1);
            // 
            // btnListaDiagnosticos
            // 
            this.btnListaDiagnosticos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaDiagnosticos.FlatAppearance.BorderSize = 0;
            this.btnListaDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDiagnosticos.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaDiagnosticos.Location = new System.Drawing.Point(0, 0);
            this.btnListaDiagnosticos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaDiagnosticos.Name = "btnListaDiagnosticos";
            this.btnListaDiagnosticos.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnListaDiagnosticos.Size = new System.Drawing.Size(322, 49);
            this.btnListaDiagnosticos.TabIndex = 12;
            this.btnListaDiagnosticos.Text = "Lista de diagnósticos";
            this.btnListaDiagnosticos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaDiagnosticos.UseVisualStyleBackColor = true;
            this.btnListaDiagnosticos.Click += new System.EventHandler(this.btnListaDiagnosticos_Click_1);
            // 
            // btnDiagnosticos
            // 
            this.btnDiagnosticos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnDiagnosticos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnosticos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnDiagnosticos.FlatAppearance.BorderSize = 0;
            this.btnDiagnosticos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnDiagnosticos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosticos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnDiagnosticos.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            this.btnDiagnosticos.IconColor = System.Drawing.Color.Black;
            this.btnDiagnosticos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiagnosticos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosticos.Location = new System.Drawing.Point(0, 326);
            this.btnDiagnosticos.Name = "btnDiagnosticos";
            this.btnDiagnosticos.Size = new System.Drawing.Size(322, 55);
            this.btnDiagnosticos.TabIndex = 29;
            this.btnDiagnosticos.Text = "Diagnósticos";
            this.btnDiagnosticos.UseVisualStyleBackColor = false;
            this.btnDiagnosticos.Click += new System.EventHandler(this.btnDiagnosticos_Click_1);
            // 
            // btnExpedientes
            // 
            this.btnExpedientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnExpedientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpedientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnExpedientes.FlatAppearance.BorderSize = 0;
            this.btnExpedientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnExpedientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnExpedientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpedientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnExpedientes.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnExpedientes.IconColor = System.Drawing.Color.Black;
            this.btnExpedientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpedientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpedientes.Location = new System.Drawing.Point(0, 271);
            this.btnExpedientes.Name = "btnExpedientes";
            this.btnExpedientes.Size = new System.Drawing.Size(322, 55);
            this.btnExpedientes.TabIndex = 28;
            this.btnExpedientes.Text = "Expedientes";
            this.btnExpedientes.UseVisualStyleBackColor = false;
            this.btnExpedientes.Click += new System.EventHandler(this.btnExpedientes_Click_1);
            // 
            // pnlSubPacientes
            // 
            this.pnlSubPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.pnlSubPacientes.Controls.Add(this.btnAgregarPacientes);
            this.pnlSubPacientes.Controls.Add(this.btnListaPacientes);
            this.pnlSubPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubPacientes.Location = new System.Drawing.Point(0, 171);
            this.pnlSubPacientes.Name = "pnlSubPacientes";
            this.pnlSubPacientes.Size = new System.Drawing.Size(322, 100);
            this.pnlSubPacientes.TabIndex = 32;
            // 
            // btnAgregarPacientes
            // 
            this.btnAgregarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPacientes.FlatAppearance.BorderSize = 0;
            this.btnAgregarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPacientes.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPacientes.Location = new System.Drawing.Point(0, 49);
            this.btnAgregarPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPacientes.Name = "btnAgregarPacientes";
            this.btnAgregarPacientes.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAgregarPacientes.Size = new System.Drawing.Size(322, 49);
            this.btnAgregarPacientes.TabIndex = 13;
            this.btnAgregarPacientes.Text = "Agregar paciente";
            this.btnAgregarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPacientes.UseVisualStyleBackColor = true;
            this.btnAgregarPacientes.Click += new System.EventHandler(this.btnAgregarPacientes_Click_1);
            // 
            // btnListaPacientes
            // 
            this.btnListaPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaPacientes.FlatAppearance.BorderSize = 0;
            this.btnListaPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaPacientes.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnListaPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaPacientes.Name = "btnListaPacientes";
            this.btnListaPacientes.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnListaPacientes.Size = new System.Drawing.Size(322, 49);
            this.btnListaPacientes.TabIndex = 12;
            this.btnListaPacientes.Text = "Lista de pacientes";
            this.btnListaPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPacientes.UseVisualStyleBackColor = true;
            this.btnListaPacientes.Click += new System.EventHandler(this.btnListaPacientes_Click_1);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.btnPacientes.IconColor = System.Drawing.Color.Black;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 116);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(322, 55);
            this.btnPacientes.TabIndex = 1;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pnlSubCitas
            // 
            this.pnlSubCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.pnlSubCitas.Controls.Add(this.btnAgregarCitas);
            this.pnlSubCitas.Controls.Add(this.btnListaCitas);
            this.pnlSubCitas.Location = new System.Drawing.Point(0, 693);
            this.pnlSubCitas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubCitas.Name = "pnlSubCitas";
            this.pnlSubCitas.Size = new System.Drawing.Size(322, 98);
            this.pnlSubCitas.TabIndex = 26;
            // 
            // btnAgregarCitas
            // 
            this.btnAgregarCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCitas.FlatAppearance.BorderSize = 0;
            this.btnAgregarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCitas.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCitas.Location = new System.Drawing.Point(0, 49);
            this.btnAgregarCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCitas.Name = "btnAgregarCitas";
            this.btnAgregarCitas.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAgregarCitas.Size = new System.Drawing.Size(322, 26);
            this.btnAgregarCitas.TabIndex = 12;
            this.btnAgregarCitas.Text = "Agregar cita";
            this.btnAgregarCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCitas.UseVisualStyleBackColor = true;
            this.btnAgregarCitas.Click += new System.EventHandler(this.btnAgregarCitas_Click);
            // 
            // btnListaCitas
            // 
            this.btnListaCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaCitas.FlatAppearance.BorderSize = 0;
            this.btnListaCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCitas.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCitas.Location = new System.Drawing.Point(0, 0);
            this.btnListaCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaCitas.Name = "btnListaCitas";
            this.btnListaCitas.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnListaCitas.Size = new System.Drawing.Size(322, 49);
            this.btnListaCitas.TabIndex = 11;
            this.btnListaCitas.Text = "Lista de citas";
            this.btnListaCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaCitas.UseVisualStyleBackColor = true;
            this.btnListaCitas.Click += new System.EventHandler(this.btnListaCitas_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbConfig);
            this.pnlLogo.Controls.Add(this.pbUser);
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(322, 116);
            this.pnlLogo.TabIndex = 1;
            // 
            // pbConfig
            // 
            this.pbConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbConfig.Image = global::diseños_ptc_6.Properties.Resources.config;
            this.pbConfig.Location = new System.Drawing.Point(133, 0);
            this.pbConfig.Margin = new System.Windows.Forms.Padding(4);
            this.pbConfig.Name = "pbConfig";
            this.pbConfig.Size = new System.Drawing.Size(189, 52);
            this.pbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfig.TabIndex = 3;
            this.pbConfig.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbUser.Image = global::diseños_ptc_6.Properties.Resources.Imagen4;
            this.pbUser.Location = new System.Drawing.Point(133, 52);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(189, 64);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::diseños_ptc_6.Properties.Resources.logo_normal;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(133, 116);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 946);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(322, 92);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // FrmPrincipalDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1445, 814);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlChildForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipalDoctores";
            this.Text = "SIGMA";
            this.Load += new System.EventHandler(this.FrmPrincipalDoctores_Load);
            this.pnlChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlSubCita.ResumeLayout(false);
            this.pnlSubHistoriales.ResumeLayout(false);
            this.pnlSubTratamientos.ResumeLayout(false);
            this.pnlSubDiagnosticos.ResumeLayout(false);
            this.pnlSubPacientes.ResumeLayout(false);
            this.pnlSubCitas.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlSubCitas;
        private System.Windows.Forms.Button btnAgregarCitas;
        private System.Windows.Forms.Button btnListaCitas;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbConfig;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlSubPacientes;
        private System.Windows.Forms.Button btnAgregarPacientes;
        private System.Windows.Forms.Button btnListaPacientes;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnCitas;
        private System.Windows.Forms.Panel pnlSubHistoriales;
        private System.Windows.Forms.Button btnAgregarHistoriales;
        private System.Windows.Forms.Button btnListaHistoriales;
        private FontAwesome.Sharp.IconButton btnHistoriales;
        private System.Windows.Forms.Panel pnlSubTratamientos;
        private System.Windows.Forms.Button btnAgregarTratamientos;
        private System.Windows.Forms.Button btnListaTratamientos;
        private FontAwesome.Sharp.IconButton btnTratamientos;
        private System.Windows.Forms.Panel pnlSubDiagnosticos;
        private System.Windows.Forms.Button btnAgregarDiagnosticos;
        private System.Windows.Forms.Button btnListaDiagnosticos;
        private FontAwesome.Sharp.IconButton btnDiagnosticos;
        private FontAwesome.Sharp.IconButton btnExpedientes;
        private System.Windows.Forms.Panel pnlSubCita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}