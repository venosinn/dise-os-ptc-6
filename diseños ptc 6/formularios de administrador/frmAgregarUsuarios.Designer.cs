namespace diseños_ptc_6
{
    partial class frmAgregarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarUsuarios));
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cbNotificar = new System.Windows.Forms.CheckBox();
            this.txtCorreoUsuario = new diseños_ptc_6.textbox();
            this.txtClaveUsuario = new diseños_ptc_6.textbox();
            this.txtNombreUsuario = new diseños_ptc_6.textbox();
            this.SuspendLayout();
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(61, 67);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(89, 28);
            this.lbNombreUsuario.TabIndex = 1;
            this.lbNombreUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de usuario";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Médico",
            "Enfermera/o",
            "Secretaria/o"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(261, 322);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(99, 21);
            this.cmbTipoUsuario.TabIndex = 7;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(124, 414);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(217, 49);
            this.btnAgregarUsuario.TabIndex = 8;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // cbNotificar
            // 
            this.cbNotificar.AutoSize = true;
            this.cbNotificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificar.Location = new System.Drawing.Point(135, 469);
            this.cbNotificar.Name = "cbNotificar";
            this.cbNotificar.Size = new System.Drawing.Size(177, 23);
            this.cbNotificar.TabIndex = 9;
            this.cbNotificar.Text = "Notificar adición exitosa";
            this.cbNotificar.UseVisualStyleBackColor = true;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtCorreoUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtCorreoUsuario.BorderSize = 2;
            this.txtCorreoUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtCorreoUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoUsuario.Location = new System.Drawing.Point(157, 244);
            this.txtCorreoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoUsuario.MaxLength = 32767;
            this.txtCorreoUsuario.Multiline = false;
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtCorreoUsuario.PasswordChar = false;
            this.txtCorreoUsuario.Size = new System.Drawing.Size(292, 32);
            this.txtCorreoUsuario.TabIndex = 5;
            this.txtCorreoUsuario.Texto = "";
            this.txtCorreoUsuario.UnderlinedStyle = true;
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtClaveUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtClaveUsuario.BorderSize = 2;
            this.txtClaveUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtClaveUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtClaveUsuario.Location = new System.Drawing.Point(157, 156);
            this.txtClaveUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveUsuario.MaxLength = 32767;
            this.txtClaveUsuario.Multiline = false;
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtClaveUsuario.PasswordChar = false;
            this.txtClaveUsuario.Size = new System.Drawing.Size(292, 32);
            this.txtClaveUsuario.TabIndex = 3;
            this.txtClaveUsuario.Texto = "";
            this.txtClaveUsuario.UnderlinedStyle = true;
            this.txtClaveUsuario.Load += new System.EventHandler(this.txtClaveUsuario_Load);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombreUsuario.BorderSize = 2;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNombreUsuario.Location = new System.Drawing.Point(157, 63);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.MaxLength = 32767;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombreUsuario.PasswordChar = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(292, 32);
            this.txtNombreUsuario.TabIndex = 0;
            this.txtNombreUsuario.Texto = "";
            this.txtNombreUsuario.UnderlinedStyle = true;
            // 
            // frmAgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.cbNotificar);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "frmAgregarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar usuario";
            this.Load += new System.EventHandler(this.frmAgregarUsuarios_Load);
            this.Move += new System.EventHandler(this.frmAgregarUsuarios_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textbox txtNombreUsuario;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Label label1;
        private textbox txtClaveUsuario;
        private System.Windows.Forms.Label label2;
        private textbox txtCorreoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.CheckBox cbNotificar;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
    }
}