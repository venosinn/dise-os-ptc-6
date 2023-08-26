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
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
            
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            if (cbNotificar.Checked)
            {
                MessageBox.Show("Empleado agregado exitosamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDuiEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombreEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombreEmpleado_Enter(object sender, EventArgs e)
        {
            
        }
    }
}