namespace diseños_ptc_6
{
    partial class frmActualizarPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarPacientes));
            this.btnActualizarPacientes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAlergias = new System.Windows.Forms.TextBox();
            this.txtResponsable = new diseños_ptc_6.textbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltura = new diseños_ptc_6.textbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeso = new diseños_ptc_6.textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoPaciente = new diseños_ptc_6.textbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new diseños_ptc_6.textbox();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActualizarPacientes
            // 
            this.btnActualizarPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarPacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnActualizarPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPacientes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPacientes.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarPacientes.Location = new System.Drawing.Point(157, 671);
            this.btnActualizarPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarPacientes.Name = "btnActualizarPacientes";
            this.btnActualizarPacientes.Size = new System.Drawing.Size(289, 60);
            this.btnActualizarPacientes.TabIndex = 40;
            this.btnActualizarPacientes.Text = "Actualizar";
            this.btnActualizarPacientes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(494, 35);
            this.label7.TabIndex = 39;
            this.label7.Text = "Responsable(solo si es menor de edad):";
            // 
            // tbAlergias
            // 
            this.tbAlergias.Location = new System.Drawing.Point(155, 505);
            this.tbAlergias.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlergias.Multiline = true;
            this.tbAlergias.Name = "tbAlergias";
            this.tbAlergias.Size = new System.Drawing.Size(381, 137);
            this.tbAlergias.TabIndex = 38;
            // 
            // txtResponsable
            // 
            this.txtResponsable.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtResponsable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtResponsable.BorderSize = 2;
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtResponsable.ForeColor = System.Drawing.Color.Black;
            this.txtResponsable.Location = new System.Drawing.Point(53, 428);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(5);
            this.txtResponsable.MaxLength = 32767;
            this.txtResponsable.Multiline = false;
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Padding = new System.Windows.Forms.Padding(9);
            this.txtResponsable.PasswordChar = false;
            this.txtResponsable.Size = new System.Drawing.Size(507, 38);
            this.txtResponsable.TabIndex = 37;
            this.txtResponsable.Texto = "";
            this.txtResponsable.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 495);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 35);
            this.label6.TabIndex = 36;
            this.label6.Text = "Alergias:";
            // 
            // txtAltura
            // 
            this.txtAltura.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtAltura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtAltura.BorderSize = 2;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtAltura.ForeColor = System.Drawing.Color.Black;
            this.txtAltura.Location = new System.Drawing.Point(140, 300);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(5);
            this.txtAltura.MaxLength = 32767;
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Padding = new System.Windows.Forms.Padding(9);
            this.txtAltura.PasswordChar = false;
            this.txtAltura.Size = new System.Drawing.Size(187, 38);
            this.txtAltura.TabIndex = 35;
            this.txtAltura.Texto = "";
            this.txtAltura.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 35);
            this.label5.TabIndex = 34;
            this.label5.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtPeso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtPeso.BorderSize = 2;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtPeso.ForeColor = System.Drawing.Color.Black;
            this.txtPeso.Location = new System.Drawing.Point(429, 305);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(5);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Padding = new System.Windows.Forms.Padding(9);
            this.txtPeso.PasswordChar = false;
            this.txtPeso.Size = new System.Drawing.Size(181, 38);
            this.txtPeso.TabIndex = 33;
            this.txtPeso.Texto = "";
            this.txtPeso.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 35);
            this.label4.TabIndex = 32;
            this.label4.Text = "Peso:";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(137, 239);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(160, 24);
            this.cbSexo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sexo:";
            // 
            // dtpFechaNa
            // 
            this.dtpFechaNa.Location = new System.Drawing.Point(344, 172);
            this.dtpFechaNa.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNa.Name = "dtpFechaNa";
            this.dtpFechaNa.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNa.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 35);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtApellidoPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtApellidoPaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtApellidoPaciente.BorderSize = 2;
            this.txtApellidoPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtApellidoPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoPaciente.Location = new System.Drawing.Point(184, 96);
            this.txtApellidoPaciente.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellidoPaciente.MaxLength = 32767;
            this.txtApellidoPaciente.Multiline = false;
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Padding = new System.Windows.Forms.Padding(9);
            this.txtApellidoPaciente.PasswordChar = false;
            this.txtApellidoPaciente.Size = new System.Drawing.Size(389, 38);
            this.txtApellidoPaciente.TabIndex = 27;
            this.txtApellidoPaciente.Texto = "";
            this.txtApellidoPaciente.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Apellido:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombrePaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombrePaciente.BorderSize = 2;
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombrePaciente.ForeColor = System.Drawing.Color.Black;
            this.txtNombrePaciente.Location = new System.Drawing.Point(171, 31);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombrePaciente.MaxLength = 32767;
            this.txtNombrePaciente.Multiline = false;
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Padding = new System.Windows.Forms.Padding(9);
            this.txtNombrePaciente.PasswordChar = false;
            this.txtNombrePaciente.Size = new System.Drawing.Size(389, 38);
            this.txtNombrePaciente.TabIndex = 25;
            this.txtNombrePaciente.Texto = "";
            this.txtNombrePaciente.UnderlinedStyle = true;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(47, 31);
            this.lbNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(123, 35);
            this.lbNombreUsuario.TabIndex = 24;
            this.lbNombreUsuario.Text = "Nombre:";
            // 
            // frmActualizarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(645, 814);
            this.Controls.Add(this.btnActualizarPacientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAlergias);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaNa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lbNombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActualizarPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar pacientes";
            this.Load += new System.EventHandler(this.frmActualizarPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizarPacientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAlergias;
        private textbox txtResponsable;
        private System.Windows.Forms.Label label6;
        private textbox txtAltura;
        private System.Windows.Forms.Label label5;
        private textbox txtPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNa;
        private System.Windows.Forms.Label label2;
        private textbox txtApellidoPaciente;
        private System.Windows.Forms.Label label1;
        private textbox txtNombrePaciente;
        private System.Windows.Forms.Label lbNombreUsuario;
    }
}