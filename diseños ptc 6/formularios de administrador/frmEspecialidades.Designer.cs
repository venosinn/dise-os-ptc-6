namespace diseños_ptc_6
{
    partial class frmEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialidades));
            this.dgvListaEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnBorrarEspecialidad = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.cbNotificar = new System.Windows.Forms.CheckBox();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreEspecialidad = new diseños_ptc_6.textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEspecialidades
            // 
            this.dgvListaEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEspecialidades.Location = new System.Drawing.Point(44, 283);
            this.dgvListaEspecialidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaEspecialidades.Name = "dgvListaEspecialidades";
            this.dgvListaEspecialidades.RowHeadersWidth = 51;
            this.dgvListaEspecialidades.Size = new System.Drawing.Size(865, 406);
            this.dgvListaEspecialidades.TabIndex = 5;
            // 
            // btnBorrarEspecialidad
            // 
            this.btnBorrarEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrarEspecialidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnBorrarEspecialidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarEspecialidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarEspecialidad.Location = new System.Drawing.Point(379, 169);
            this.btnBorrarEspecialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarEspecialidad.Name = "btnBorrarEspecialidad";
            this.btnBorrarEspecialidad.Size = new System.Drawing.Size(200, 60);
            this.btnBorrarEspecialidad.TabIndex = 9;
            this.btnBorrarEspecialidad.Text = "Eliminar";
            this.btnBorrarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnActualizarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(645, 169);
            this.btnActualizarEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(200, 60);
            this.btnActualizarEmpleado.TabIndex = 10;
            this.btnActualizarEmpleado.Text = "Actualizar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(335, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Especialidades";
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
            this.pbCerrar.TabIndex = 8;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarEspecialidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarEspecialidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarEspecialidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(101, 169);
            this.btnAgregarEspecialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(200, 60);
            this.btnAgregarEspecialidad.TabIndex = 12;
            this.btnAgregarEspecialidad.Text = "Agregar";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // cbNotificar
            // 
            this.cbNotificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNotificar.AutoSize = true;
            this.cbNotificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificar.Location = new System.Drawing.Point(101, 236);
            this.cbNotificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNotificar.Name = "cbNotificar";
            this.cbNotificar.Size = new System.Drawing.Size(231, 27);
            this.cbNotificar.TabIndex = 13;
            this.cbNotificar.Text = "Notificar adición exitosa";
            this.cbNotificar.UseVisualStyleBackColor = true;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(173, 101);
            this.lbNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(123, 35);
            this.lbNombreUsuario.TabIndex = 14;
            this.lbNombreUsuario.Text = "Nombre:";
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombreEspecialidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombreEspecialidad.BorderSize = 2;
            this.txtNombreEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(311, 96);
            this.txtNombreEspecialidad.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreEspecialidad.MaxLength = 32767;
            this.txtNombreEspecialidad.Multiline = false;
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Padding = new System.Windows.Forms.Padding(9);
            this.txtNombreEspecialidad.PasswordChar = false;
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(389, 38);
            this.txtNombreEspecialidad.TabIndex = 15;
            this.txtNombreEspecialidad.Texto = "";
            this.txtNombreEspecialidad.UnderlinedStyle = true;
            // 
            // frmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(951, 704);
            this.Controls.Add(this.txtNombreEspecialidad);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.cbNotificar);
            this.Controls.Add(this.btnAgregarEspecialidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.btnBorrarEspecialidad);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.dgvListaEspecialidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEspecialidades";
            this.Text = "frmListaEspecialidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEspecialidades;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Button btnBorrarEspecialidad;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.CheckBox cbNotificar;
        private System.Windows.Forms.Label lbNombreUsuario;
        private textbox txtNombreEspecialidad;
    }
}