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
    public partial class frmAgregarUsuarios : Form
    {
        public frmAgregarUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //codigo
            if(cbNotificar.Checked) {
                MessageBox.Show("Usuario agregado exitosamente","Notificación",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void frmAgregarUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void frmAgregarUsuarios_Move(object sender, EventArgs e)
        {

        }

        private void txtClaveUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
