namespace diseños_ptc_6
{
    partial class frmListaPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPacientes));
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarPaciente = new System.Windows.Forms.Button();
            this.btnBorrarPaciente = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new diseños_ptc_6.textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(376, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pacientes ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnActualizarPaciente
            // 
            this.btnActualizarPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnActualizarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarPaciente.Location = new System.Drawing.Point(591, 97);
            this.btnActualizarPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarPaciente.Name = "btnActualizarPaciente";
            this.btnActualizarPaciente.Size = new System.Drawing.Size(289, 60);
            this.btnActualizarPaciente.TabIndex = 11;
            this.btnActualizarPaciente.Text = "Actualizar";
            this.btnActualizarPaciente.UseVisualStyleBackColor = true;
            this.btnActualizarPaciente.Click += new System.EventHandler(this.btnActualizarPaciente_Click);
            // 
            // btnBorrarPaciente
            // 
            this.btnBorrarPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrarPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnBorrarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarPaciente.Location = new System.Drawing.Point(145, 97);
            this.btnBorrarPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarPaciente.Name = "btnBorrarPaciente";
            this.btnBorrarPaciente.Size = new System.Drawing.Size(289, 60);
            this.btnBorrarPaciente.TabIndex = 10;
            this.btnBorrarPaciente.Text = "Eliminar";
            this.btnBorrarPaciente.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(44, 238);
            this.dgvPacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.Size = new System.Drawing.Size(865, 452);
            this.dgvPacientes.TabIndex = 9;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = global::diseños_ptc_6.Properties.Resources.x;
            this.pbCerrar.Location = new System.Drawing.Point(892, 4);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(57, 49);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 13;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(278, 194);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(101, 35);
            this.lbBuscar.TabIndex = 15;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(405, 191);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(9);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.Size = new System.Drawing.Size(389, 38);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.Texto = "";
            this.txtBuscar.UnderlinedStyle = true;
            // 
            // frmListaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(951, 704);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizarPaciente);
            this.Controls.Add(this.btnBorrarPaciente);
            this.Controls.Add(this.dgvPacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaPacientes";
            this.Text = "Lista de pacientes";
            this.Load += new System.EventHandler(this.frmListaPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarPaciente;
        private System.Windows.Forms.Button btnBorrarPaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lbBuscar;
        private textbox txtBuscar;
    }
}