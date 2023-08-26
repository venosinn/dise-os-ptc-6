namespace diseños_ptc_6
{
    partial class frmActualizarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarEmpleados));
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.txtDuiEmpleado = new diseños_ptc_6.textbox();
            this.txtApellidoEmpleado = new diseños_ptc_6.textbox();
            this.txtNombreEmpleado = new diseños_ptc_6.textbox();
            this.SuspendLayout();
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
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(167, 491);
            this.btnActualizarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(289, 60);
            this.btnActualizarEmpleado.TabIndex = 20;
            this.btnActualizarEmpleado.Text = "Actualizar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(273, 411);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 35);
            this.label3.TabIndex = 18;
            this.label3.Text = "Especialidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "DUI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apellido:";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(68, 107);
            this.lbNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(123, 35);
            this.lbNombreUsuario.TabIndex = 13;
            this.lbNombreUsuario.Text = "Nombre:";
            // 
            // txtDuiEmpleado
            // 
            this.txtDuiEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtDuiEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtDuiEmpleado.BorderSize = 2;
            this.txtDuiEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtDuiEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtDuiEmpleado.Location = new System.Drawing.Point(189, 308);
            this.txtDuiEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.txtDuiEmpleado.MaxLength = 10;
            this.txtDuiEmpleado.Multiline = false;
            this.txtDuiEmpleado.Name = "txtDuiEmpleado";
            this.txtDuiEmpleado.Padding = new System.Windows.Forms.Padding(9);
            this.txtDuiEmpleado.PasswordChar = false;
            this.txtDuiEmpleado.Size = new System.Drawing.Size(389, 38);
            this.txtDuiEmpleado.TabIndex = 22;
            this.txtDuiEmpleado.Texto = "";
            this.txtDuiEmpleado.UnderlinedStyle = true;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtApellidoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtApellidoEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtApellidoEmpleado.BorderSize = 2;
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtApellidoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(189, 209);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellidoEmpleado.MaxLength = 32767;
            this.txtApellidoEmpleado.Multiline = false;
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Padding = new System.Windows.Forms.Padding(9);
            this.txtApellidoEmpleado.PasswordChar = false;
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(389, 38);
            this.txtApellidoEmpleado.TabIndex = 16;
            this.txtApellidoEmpleado.Texto = "";
            this.txtApellidoEmpleado.UnderlinedStyle = true;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombreEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombreEmpleado.BorderSize = 2;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(189, 102);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.Multiline = false;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Padding = new System.Windows.Forms.Padding(9);
            this.txtNombreEmpleado.PasswordChar = false;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(389, 38);
            this.txtNombreEmpleado.TabIndex = 14;
            this.txtNombreEmpleado.Texto = "";
            this.txtNombreEmpleado.UnderlinedStyle = true;
            // 
            // frmActualizarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(643, 681);
            this.Controls.Add(this.txtDuiEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lbNombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 728);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 728);
            this.Name = "frmActualizarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textbox txtDuiEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private textbox txtApellidoEmpleado;
        private System.Windows.Forms.Label label1;
        private textbox txtNombreEmpleado;
        private System.Windows.Forms.Label lbNombreUsuario;
    }
}