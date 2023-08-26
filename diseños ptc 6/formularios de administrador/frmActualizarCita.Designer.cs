namespace diseños_ptc_6
{
    partial class frmActualizarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarCita));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPacienteCita = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicEn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizarCita = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicEn)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(167, 528);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 55;
            this.label4.Text = "Paciente:";
            // 
            // dgvPacienteCita
            // 
            this.dgvPacienteCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienteCita.Location = new System.Drawing.Point(64, 350);
            this.dgvPacienteCita.Name = "dgvPacienteCita";
            this.dgvPacienteCita.RowHeadersWidth = 51;
            this.dgvPacienteCita.RowTemplate.Height = 24;
            this.dgvPacienteCita.Size = new System.Drawing.Size(514, 150);
            this.dgvPacienteCita.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 53;
            this.label1.Text = "Médico encargado:";
            // 
            // dgvMedicEn
            // 
            this.dgvMedicEn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicEn.Location = new System.Drawing.Point(64, 131);
            this.dgvMedicEn.Name = "dgvMedicEn";
            this.dgvMedicEn.RowHeadersWidth = 51;
            this.dgvMedicEn.RowTemplate.Height = 24;
            this.dgvMedicEn.Size = new System.Drawing.Size(514, 150);
            this.dgvMedicEn.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 35);
            this.label3.TabIndex = 51;
            this.label3.Text = "Datos de la cita:";
            // 
            // btnActualizarCita
            // 
            this.btnActualizarCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarCita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnActualizarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCita.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCita.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarCita.Location = new System.Drawing.Point(161, 592);
            this.btnActualizarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarCita.Name = "btnActualizarCita";
            this.btnActualizarCita.Size = new System.Drawing.Size(289, 60);
            this.btnActualizarCita.TabIndex = 50;
            this.btnActualizarCita.Text = "Actualizar";
            this.btnActualizarCita.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 35);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fecha:";
            // 
            // frmActualizarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(643, 681);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPacienteCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicEn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActualizarCita);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActualizarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar cita";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicEn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPacienteCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicEn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizarCita;
        private System.Windows.Forms.Label label2;
    }
}