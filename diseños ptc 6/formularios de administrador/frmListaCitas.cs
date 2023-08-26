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
    public partial class frmListaCitas : Form
    {
        public frmListaCitas()
        {
            InitializeComponent();
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form al = null;
        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            if (al != null)
            {
                al.Close();
            }
            al = new frmActualizarCita();
            al.Show();

        }
    }
}
