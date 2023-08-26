namespace diseños_ptc_6
{
    partial class frmActualizarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarUsuarios));
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreoUsuario = new diseños_ptc_6.textbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new diseños_ptc_6.textbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new diseños_ptc_6.textbox();
            this.SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(139, 446);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(289, 60);
            this.btnAgregarUsuario.TabIndex = 18;
            this.btnAgregarUsuario.Text = "Actualizar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Médico",
            "Enfermera/o",
            "Secretaria/o"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(325, 336);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(131, 24);
            this.cmbTipoUsuario.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo de usuario";
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtCorreoUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtCorreoUsuario.BorderSize = 2;
            this.txtCorreoUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtCorreoUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoUsuario.Location = new System.Drawing.Point(187, 235);
            this.txtCorreoUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCorreoUsuario.MaxLength = 32767;
            this.txtCorreoUsuario.Multiline = false;
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtCorreoUsuario.PasswordChar = false;
            this.txtCorreoUsuario.Size = new System.Drawing.Size(389, 38);
            this.txtCorreoUsuario.TabIndex = 15;
            this.txtCorreoUsuario.Texto = "";
            this.txtCorreoUsuario.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Correo:";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtClaveUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtClaveUsuario.BorderSize = 2;
            this.txtClaveUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtClaveUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtClaveUsuario.Location = new System.Drawing.Point(233, 146);
            this.txtClaveUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClaveUsuario.MaxLength = 32767;
            this.txtClaveUsuario.Multiline = false;
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtClaveUsuario.PasswordChar = false;
            this.txtClaveUsuario.Size = new System.Drawing.Size(343, 38);
            this.txtClaveUsuario.TabIndex = 13;
            this.txtClaveUsuario.Texto = "";
            this.txtClaveUsuario.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraseña:";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(81, 82);
            this.lbNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(113, 35);
            this.lbNombreUsuario.TabIndex = 11;
            this.lbNombreUsuario.Text = "Usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombreUsuario.BorderSize = 2;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNombreUsuario.Location = new System.Drawing.Point(209, 78);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombreUsuario.MaxLength = 32767;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtNombreUsuario.PasswordChar = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(389, 38);
            this.txtNombreUsuario.TabIndex = 10;
            this.txtNombreUsuario.Texto = "";
            this.txtNombreUsuario.UnderlinedStyle = true;
            // 
            // frmActualizarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(645, 690);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActualizarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label label3;
        private textbox txtCorreoUsuario;
        private System.Windows.Forms.Label label2;
        private textbox txtClaveUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombreUsuario;
        private textbox txtNombreUsuario;
    }
}