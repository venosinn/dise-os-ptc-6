namespace diseños_ptc_6
{
    partial class frmAgregarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCita));
            this.dgvMedico = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNotificar = new System.Windows.Forms.CheckBox();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.dtpPaciente = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedico
            // 
            this.dgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedico.Location = new System.Drawing.Point(31, 112);
            this.dgvMedico.Name = "dgvMedico";
            this.dgvMedico.RowHeadersWidth = 51;
            this.dgvMedico.RowTemplate.Height = 24;
            this.dgvMedico.Size = new System.Drawing.Size(514, 150);
            this.dgvMedico.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 35);
            this.label3.TabIndex = 43;
            this.label3.Text = "Datos de la cita:";
            // 
            // cbNotificar
            // 
            this.cbNotificar.AutoSize = true;
            this.cbNotificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificar.Location = new System.Drawing.Point(150, 641);
            this.cbNotificar.Margin = new System.Windows.Forms.Padding(4);
            this.cbNotificar.Name = "cbNotificar";
            this.cbNotificar.Size = new System.Drawing.Size(231, 27);
            this.cbNotificar.TabIndex = 41;
            this.cbNotificar.Text = "Notificar adición exitosa";
            this.cbNotificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarC.Location = new System.Drawing.Point(128, 573);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(289, 60);
            this.btnAgregarC.TabIndex = 40;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 35);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 45;
            this.label1.Text = "Médico encargado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 47;
            this.label4.Text = "Paciente:";
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(31, 331);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.RowHeadersWidth = 51;
            this.dgvPaciente.RowTemplate.Height = 24;
            this.dgvPaciente.Size = new System.Drawing.Size(514, 150);
            this.dgvPaciente.TabIndex = 46;
            // 
            // dtpPaciente
            // 
            this.dtpPaciente.Location = new System.Drawing.Point(134, 509);
            this.dtpPaciente.Name = "dtpPaciente";
            this.dtpPaciente.Size = new System.Drawing.Size(200, 22);
            this.dtpPaciente.TabIndex = 48;
            // 
            // frmAgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(643, 681);
            this.Controls.Add(this.dtpPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNotificar);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar cita";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbNotificar;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.DateTimePicker dtpPaciente;
    }
}