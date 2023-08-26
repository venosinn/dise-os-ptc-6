using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseños_ptc_6
{
    public partial class frmEspecialidades : Form
    {
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            //codigo
            if (cbNotificar.Checked)
            {
                MessageBox.Show("Especialidad agregada exitosamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
