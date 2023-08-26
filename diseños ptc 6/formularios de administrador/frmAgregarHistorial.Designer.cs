namespace diseños_ptc_6
{
    partial class frmAgregarHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarHistorial));
            this.dgvNumEx = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new diseños_ptc_6.textbox();
            this.cbNotificar = new System.Windows.Forms.CheckBox();
            this.btnAgregarH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumEx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumEx
            // 
            this.dgvNumEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumEx.Location = new System.Drawing.Point(52, 110);
            this.dgvNumEx.Name = "dgvNumEx";
            this.dgvNumEx.RowHeadersWidth = 51;
            this.dgvNumEx.RowTemplate.Height = 24;
            this.dgvNumEx.Size = new System.Drawing.Size(514, 150);
            this.dgvNumEx.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 35);
            this.label3.TabIndex = 43;
            this.label3.Text = "Numero de expediente:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(52, 324);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.MaxLength = 10;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(9);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.Size = new System.Drawing.Size(504, 38);
            this.txtDescripcion.TabIndex = 42;
            this.txtDescripcion.Texto = "";
            this.txtDescripcion.UnderlinedStyle = true;
            // 
            // cbNotificar
            // 
            this.cbNotificar.AutoSize = true;
            this.cbNotificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificar.Location = new System.Drawing.Point(209, 559);
            this.cbNotificar.Margin = new System.Windows.Forms.Padding(4);
            this.cbNotificar.Name = "cbNotificar";
            this.cbNotificar.Size = new System.Drawing.Size(231, 27);
            this.cbNotificar.TabIndex = 41;
            this.cbNotificar.Text = "Notificar adición exitosa";
            this.cbNotificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarH
            // 
            this.btnAgregarH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(227)))));
            this.btnAgregarH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.btnAgregarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarH.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarH.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarH.Location = new System.Drawing.Point(175, 491);
            this.btnAgregarH.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarH.Name = "btnAgregarH";
            this.btnAgregarH.Size = new System.Drawing.Size(289, 60);
            this.btnAgregarH.TabIndex = 40;
            this.btnAgregarH.Text = "Agregar";
            this.btnAgregarH.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 39;
            this.label2.Text = "Descripcion :";
            // 
            // frmAgregarHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(643, 681);
            this.Controls.Add(this.dgvNumEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cbNotificar);
            this.Controls.Add(this.btnAgregarH);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumEx;
        private System.Windows.Forms.Label label3;
        private textbox txtDescripcion;
        private System.Windows.Forms.CheckBox cbNotificar;
        private System.Windows.Forms.Button btnAgregarH;
        private System.Windows.Forms.Label label2;
    }
}