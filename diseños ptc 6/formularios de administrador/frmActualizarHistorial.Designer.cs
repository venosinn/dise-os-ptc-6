namespace diseños_ptc_6
{
    partial class frmActualizarHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarHistorial));
            this.dgvNumEx = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescHis = new diseños_ptc_6.textbox();
            this.btnActualizarHis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumEx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumEx
            // 
            this.dgvNumEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumEx.Location = new System.Drawing.Point(32, 76);
            this.dgvNumEx.Name = "dgvNumEx";
            this.dgvNumEx.RowHeadersWidth = 51;
            this.dgvNumEx.RowTemplate.Height = 24;
            this.dgvNumEx.Size = new System.Drawing.Size(514, 150);
            this.dgvNumEx.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 35);
            this.label3.TabIndex = 48;
            this.label3.Text = "Numero de expediente:";
            // 
            // txtDescHis
            // 
            this.txtDescHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtDescHis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtDescHis.BorderSize = 2;
            this.txtDescHis.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtDescHis.ForeColor = System.Drawing.Color.Black;
            this.txtDescHis.Location = new System.Drawing.Point(42, 303);
            this.txtDescHis.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescHis.MaxLength = 10;
            this.txtDescHis.Multiline = false;
            this.txtDescHis.Name = "txtDescHis";
            this.txtDescHis.Padding = new System.Windows.Forms.Padding(9);
            this.txtDescHis.PasswordChar = false;
            this.txtDescHis.Size = new System.Drawing.Size(504, 38);
            this.txtDescHis.TabIndex = 47;
            this.txtDescHis.Texto = "";
            this.txtDescHis.UnderlinedStyle = true;
            // 
            // btnActualizarHis
            // 
            this.btnActualizarHis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarHis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnActualizarHis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarHis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnActualizarHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarHis.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarHis.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarHis.Location = new System.Drawing.Point(138, 465);
            this.btnActualizarHis.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarHis.Name = "btnActualizarHis";
            this.btnActualizarHis.Size = new System.Drawing.Size(289, 60);
            this.btnActualizarHis.TabIndex = 46;
            this.btnActualizarHis.Text = "Actualizar";
            this.btnActualizarHis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 45;
            this.label2.Text = "Descripcion :";
            // 
            // frmActualizarHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(643, 681);
            this.Controls.Add(this.dgvNumEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescHis);
            this.Controls.Add(this.btnActualizarHis);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActualizarHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar historial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumEx;
        private System.Windows.Forms.Label label3;
        private textbox txtDescHis;
        private System.Windows.Forms.Button btnActualizarHis;
        private System.Windows.Forms.Label label2;
    }
}