namespace diseños_ptc_6
{
    partial class frmAgregarTratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarTratamiento));
            this.cbNotificar = new System.Windows.Forms.CheckBox();
            this.btnAgregarTratamiento = new System.Windows.Forms.Button();
            this.lbPresentacion = new System.Windows.Forms.Label();
            this.lbDosis = new System.Windows.Forms.Label();
            this.lbNombreTratamiento = new System.Windows.Forms.Label();
            this.lbNumeroEx = new System.Windows.Forms.Label();
            this.dgvNumEx = new System.Windows.Forms.DataGridView();
            this.txtPresentacion = new diseños_ptc_6.textbox();
            this.txtDosis = new diseños_ptc_6.textbox();
            this.txtNombreT = new diseños_ptc_6.textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumEx)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNotificar
            // 
            this.cbNotificar.AutoSize = true;
            this.cbNotificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificar.Location = new System.Drawing.Point(173, 645);
            this.cbNotificar.Margin = new System.Windows.Forms.Padding(4);
            this.cbNotificar.Name = "cbNotificar";
            this.cbNotificar.Size = new System.Drawing.Size(231, 27);
            this.cbNotificar.TabIndex = 31;
            this.cbNotificar.Text = "Notificar adición exitosa";
            this.cbNotificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTratamiento
            // 
            this.btnAgregarTratamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarTratamiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarTratamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarTratamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTratamiento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTratamiento.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarTratamiento.Location = new System.Drawing.Point(159, 577);
            this.btnAgregarTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            this.btnAgregarTratamiento.Size = new System.Drawing.Size(289, 60);
            this.btnAgregarTratamiento.TabIndex = 30;
            this.btnAgregarTratamiento.Text = "Agregar";
            this.btnAgregarTratamiento.UseVisualStyleBackColor = true;
            // 
            // lbPresentacion
            // 
            this.lbPresentacion.AutoSize = true;
            this.lbPresentacion.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresentacion.Location = new System.Drawing.Point(58, 237);
            this.lbPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPresentacion.Name = "lbPresentacion";
            this.lbPresentacion.Size = new System.Drawing.Size(178, 35);
            this.lbPresentacion.TabIndex = 27;
            this.lbPresentacion.Text = "Presentación:";
            // 
            // lbDosis
            // 
            this.lbDosis.AutoSize = true;
            this.lbDosis.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosis.Location = new System.Drawing.Point(58, 159);
            this.lbDosis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDosis.Name = "lbDosis";
            this.lbDosis.Size = new System.Drawing.Size(85, 35);
            this.lbDosis.TabIndex = 25;
            this.lbDosis.Text = "Dosis:";
            // 
            // lbNombreTratamiento
            // 
            this.lbNombreTratamiento.AutoSize = true;
            this.lbNombreTratamiento.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreTratamiento.Location = new System.Drawing.Point(58, 80);
            this.lbNombreTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreTratamiento.Name = "lbNombreTratamiento";
            this.lbNombreTratamiento.Size = new System.Drawing.Size(123, 35);
            this.lbNombreTratamiento.TabIndex = 23;
            this.lbNombreTratamiento.Text = "Nombre:";
            // 
            // lbNumeroEx
            // 
            this.lbNumeroEx.AutoSize = true;
            this.lbNumeroEx.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroEx.Location = new System.Drawing.Point(58, 354);
            this.lbNumeroEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumeroEx.Name = "lbNumeroEx";
            this.lbNumeroEx.Size = new System.Drawing.Size(305, 35);
            this.lbNumeroEx.TabIndex = 33;
            this.lbNumeroEx.Text = "Numero de expediente:";
            // 
            // dgvNumEx
            // 
            this.dgvNumEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumEx.Location = new System.Drawing.Point(64, 408);
            this.dgvNumEx.Name = "dgvNumEx";
            this.dgvNumEx.RowHeadersWidth = 51;
            this.dgvNumEx.RowTemplate.Height = 24;
            this.dgvNumEx.Size = new System.Drawing.Size(514, 150);
            this.dgvNumEx.TabIndex = 34;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtPresentacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtPresentacion.BorderSize = 2;
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtPresentacion.ForeColor = System.Drawing.Color.Black;
            this.txtPresentacion.Location = new System.Drawing.Point(64, 277);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtPresentacion.MaxLength = 10;
            this.txtPresentacion.Multiline = false;
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Padding = new System.Windows.Forms.Padding(9);
            this.txtPresentacion.PasswordChar = false;
            this.txtPresentacion.Size = new System.Drawing.Size(504, 38);
            this.txtPresentacion.TabIndex = 32;
            this.txtPresentacion.Texto = "";
            this.txtPresentacion.UnderlinedStyle = true;
            // 
            // txtDosis
            // 
            this.txtDosis.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtDosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtDosis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtDosis.BorderSize = 2;
            this.txtDosis.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtDosis.ForeColor = System.Drawing.Color.Black;
            this.txtDosis.Location = new System.Drawing.Point(137, 159);
            this.txtDosis.Margin = new System.Windows.Forms.Padding(5);
            this.txtDosis.MaxLength = 32767;
            this.txtDosis.Multiline = false;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Padding = new System.Windows.Forms.Padding(9);
            this.txtDosis.PasswordChar = false;
            this.txtDosis.Size = new System.Drawing.Size(431, 38);
            this.txtDosis.TabIndex = 26;
            this.txtDosis.Texto = "";
            this.txtDosis.UnderlinedStyle = true;
            // 
            // txtNombreT
            // 
            this.txtNombreT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtNombreT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtNombreT.BorderSize = 2;
            this.txtNombreT.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreT.ForeColor = System.Drawing.Color.Black;
            this.txtNombreT.Location = new System.Drawing.Point(179, 75);
            this.txtNombreT.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreT.MaxLength = 32767;
            this.txtNombreT.Multiline = false;
            this.txtNombreT.Name = "txtNombreT";
            this.txtNombreT.Padding = new System.Windows.Forms.Padding(9);
            this.txtNombreT.PasswordChar = false;
            this.txtNombreT.Size = new System.Drawing.Size(389, 38);
            this.txtNombreT.TabIndex = 24;
            this.txtNombreT.Texto = "";
            this.txtNombreT.UnderlinedStyle = true;
            // 
            // frmAgregarTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(643, 681);
            this.Controls.Add(this.dgvNumEx);
            this.Controls.Add(this.lbNumeroEx);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.cbNotificar);
            this.Controls.Add(this.btnAgregarTratamiento);
            this.Controls.Add(this.lbPresentacion);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.lbDosis);
            this.Controls.Add(this.txtNombreT);
            this.Controls.Add(this.lbNombreTratamiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarTratamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un tratamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textbox txtPresentacion;
        private System.Windows.Forms.CheckBox cbNotificar;
        private System.Windows.Forms.Button btnAgregarTratamiento;
        private System.Windows.Forms.Label lbPresentacion;
        private textbox txtDosis;
        private System.Windows.Forms.Label lbDosis;
        private textbox txtNombreT;
        private System.Windows.Forms.Label lbNombreTratamiento;
        private System.Windows.Forms.Label lbNumeroEx;
        private System.Windows.Forms.DataGridView dgvNumEx;
    }
}