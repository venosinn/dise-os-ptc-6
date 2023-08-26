namespace diseños_ptc_6
{
    partial class frmAgregarDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarDiagnostico));
            this.dgvDiagnostico = new System.Windows.Forms.DataGridView();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.btnAgregarPacientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiagnostico
            // 
            this.dgvDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnostico.Location = new System.Drawing.Point(173, 82);
            this.dgvDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiagnostico.Name = "dgvDiagnostico";
            this.dgvDiagnostico.RowHeadersWidth = 51;
            this.dgvDiagnostico.Size = new System.Drawing.Size(425, 288);
            this.dgvDiagnostico.TabIndex = 0;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(37, 82);
            this.lbNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(125, 35);
            this.lbNombreUsuario.TabIndex = 7;
            this.lbNombreUsuario.Text = "Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Diagnóstico:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(219, 446);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(347, 185);
            this.txtDiagnostico.TabIndex = 10;
            // 
            // btnAgregarPacientes
            // 
            this.btnAgregarPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarPacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPacientes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPacientes.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPacientes.Location = new System.Drawing.Point(152, 725);
            this.btnAgregarPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPacientes.Name = "btnAgregarPacientes";
            this.btnAgregarPacientes.Size = new System.Drawing.Size(289, 60);
            this.btnAgregarPacientes.TabIndex = 23;
            this.btnAgregarPacientes.Text = "Agregar";
            this.btnAgregarPacientes.UseVisualStyleBackColor = true;
            // 
            // frmAgregarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(643, 804);
            this.Controls.Add(this.btnAgregarPacientes);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.dgvDiagnostico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 851);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 851);
            this.Name = "frmAgregarDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar diagnóstico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiagnostico;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Button btnAgregarPacientes;
    }
}