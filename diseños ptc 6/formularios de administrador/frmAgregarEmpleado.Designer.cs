namespace diseños_ptc_6
{
    partial class frmAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarEmpleado));
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new diseños_ptc_6.textbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new diseños_ptc_6.textbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.cbNotificar = new System.Windows.Forms.CheckBox();
            this.txtDuiEmpleado = new diseños_ptc_6.textbox();
            this.SuspendLayout();
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(50, 102);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(96, 28);
            this.lbNombreUsuario.TabIndex = 2;
            this.lbNombreUsuario.Text = "Nombre:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombreEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombreEmpleado.BorderSize = 2;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(141, 98);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmpleado.Multiline = false;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombreEmpleado.PasswordChar = false;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(292, 32);
            this.txtNombreEmpleado.TabIndex = 3;
            this.txtNombreEmpleado.Texto = "";
            this.txtNombreEmpleado.UnderlinedStyle = true;
            this.txtNombreEmpleado.Load += new System.EventHandler(this.txtNombreEmpleado_Load);
            this.txtNombreEmpleado.Enter += new System.EventHandler(this.txtNombreEmpleado_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido:";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtApellidoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtApellidoEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtApellidoEmpleado.BorderSize = 2;
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtApellidoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(141, 185);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoEmpleado.Multiline = false;
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellidoEmpleado.PasswordChar = false;
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(292, 32);
            this.txtApellidoEmpleado.TabIndex = 5;
            this.txtApellidoEmpleado.Texto = "";
            this.txtApellidoEmpleado.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "DUI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Especialidad:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ninguna",
            "General",
            "Odontología",
            "Pediatría",
            "Ginecología",
            "Oncología",
            "Dermatología",
            "Oftalmología",
            "Ortopedia",
            "Urología"});
            this.comboBox1.Location = new System.Drawing.Point(204, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(124, 414);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(217, 49);
            this.btnAgregarEmpleado.TabIndex = 10;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // cbNotificar
            // 
            this.cbNotificar.AutoSize = true;
            this.cbNotificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificar.Location = new System.Drawing.Point(135, 469);
            this.cbNotificar.Name = "cbNotificar";
            this.cbNotificar.Size = new System.Drawing.Size(177, 23);
            this.cbNotificar.TabIndex = 11;
            this.cbNotificar.Text = "Notificar adición exitosa";
            this.cbNotificar.UseVisualStyleBackColor = true;
            // 
            // txtDuiEmpleado
            // 
            this.txtDuiEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtDuiEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtDuiEmpleado.BorderSize = 2;
            this.txtDuiEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtDuiEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtDuiEmpleado.Location = new System.Drawing.Point(141, 265);
            this.txtDuiEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuiEmpleado.MaxLength = 10;
            this.txtDuiEmpleado.Multiline = false;
            this.txtDuiEmpleado.Name = "txtDuiEmpleado";
            this.txtDuiEmpleado.Padding = new System.Windows.Forms.Padding(7);
            this.txtDuiEmpleado.PasswordChar = false;
            this.txtDuiEmpleado.Size = new System.Drawing.Size(292, 32);
            this.txtDuiEmpleado.TabIndex = 12;
            this.txtDuiEmpleado.Texto = "";
            this.txtDuiEmpleado.UnderlinedStyle = true;
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.txtDuiEmpleado);
            this.Controls.Add(this.cbNotificar);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lbNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreUsuario;
        private textbox txtNombreEmpleado;
        private System.Windows.Forms.Label label1;
        private textbox txtApellidoEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.CheckBox cbNotificar;
        private textbox txtDuiEmpleado;
    }
}