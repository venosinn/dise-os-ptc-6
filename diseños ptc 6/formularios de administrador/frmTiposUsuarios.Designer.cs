namespace diseños_ptc_6
{
    partial class frmTiposUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposUsuarios));
            this.dgvTipoUsu = new System.Windows.Forms.DataGridView();
            this.txtNombreUsuario = new diseños_ptc_6.textbox();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.btnBorrarTipoUs = new System.Windows.Forms.Button();
            this.btnAgregarTipoUs = new System.Windows.Forms.Button();
            this.btnUpdateTipoUs = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new diseños_ptc_6.textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoUsu
            // 
            this.dgvTipoUsu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoUsu.Location = new System.Drawing.Point(180, 293);
            this.dgvTipoUsu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTipoUsu.Name = "dgvTipoUsu";
            this.dgvTipoUsu.RowHeadersWidth = 51;
            this.dgvTipoUsu.Size = new System.Drawing.Size(625, 347);
            this.dgvTipoUsu.TabIndex = 0;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombreUsuario.BorderSize = 2;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNombreUsuario.Location = new System.Drawing.Point(364, 58);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreUsuario.MaxLength = 32767;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(9);
            this.txtNombreUsuario.PasswordChar = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(389, 38);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.Texto = "";
            this.txtNombreUsuario.UnderlinedStyle = true;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(149, 63);
            this.lbNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(210, 35);
            this.lbNombreUsuario.TabIndex = 2;
            this.lbNombreUsuario.Text = "Tipo de usuario:";
            // 
            // btnBorrarTipoUs
            // 
            this.btnBorrarTipoUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrarTipoUs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnBorrarTipoUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarTipoUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarTipoUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTipoUs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTipoUs.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarTipoUs.Location = new System.Drawing.Point(364, 137);
            this.btnBorrarTipoUs.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarTipoUs.Name = "btnBorrarTipoUs";
            this.btnBorrarTipoUs.Size = new System.Drawing.Size(224, 60);
            this.btnBorrarTipoUs.TabIndex = 6;
            this.btnBorrarTipoUs.Text = "Eliminar";
            this.btnBorrarTipoUs.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTipoUs
            // 
            this.btnAgregarTipoUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarTipoUs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarTipoUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarTipoUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarTipoUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoUs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoUs.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarTipoUs.Location = new System.Drawing.Point(90, 137);
            this.btnAgregarTipoUs.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTipoUs.Name = "btnAgregarTipoUs";
            this.btnAgregarTipoUs.Size = new System.Drawing.Size(224, 60);
            this.btnAgregarTipoUs.TabIndex = 7;
            this.btnAgregarTipoUs.Text = "Agregar";
            this.btnAgregarTipoUs.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTipoUs
            // 
            this.btnUpdateTipoUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateTipoUs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnUpdateTipoUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnUpdateTipoUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnUpdateTipoUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTipoUs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTipoUs.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateTipoUs.Location = new System.Drawing.Point(646, 137);
            this.btnUpdateTipoUs.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTipoUs.Name = "btnUpdateTipoUs";
            this.btnUpdateTipoUs.Size = new System.Drawing.Size(224, 60);
            this.btnUpdateTipoUs.TabIndex = 8;
            this.btnUpdateTipoUs.Text = "Actualizar";
            this.btnUpdateTipoUs.UseVisualStyleBackColor = true;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(276, 232);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(101, 35);
            this.lbBuscar.TabIndex = 10;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(403, 229);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(9);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.Size = new System.Drawing.Size(389, 38);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.Texto = "";
            this.txtBuscar.UnderlinedStyle = true;
            // 
            // frmTiposUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(948, 694);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnUpdateTipoUs);
            this.Controls.Add(this.btnAgregarTipoUs);
            this.Controls.Add(this.btnBorrarTipoUs);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.dgvTipoUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(966, 741);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(966, 741);
            this.Name = "frmTiposUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoUsu;
        private textbox txtNombreUsuario;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Button btnBorrarTipoUs;
        private System.Windows.Forms.Button btnAgregarTipoUs;
        private System.Windows.Forms.Button btnUpdateTipoUs;
        private System.Windows.Forms.Label lbBuscar;
        private textbox txtBuscar;
    }
}