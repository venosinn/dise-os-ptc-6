using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace diseños_ptc_6
{
    public partial class frmListaExpediente : Form
    {
        public frmListaExpediente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListaExpediente_Load(object sender, EventArgs e)
        {
            MostrarExpedientes();
        }

        private void MostrarExpedientes()
        {
            dgvExpedientes.DataSource = null;
            dgvExpedientes.DataSource = Expedientes.CargarExpedientes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvExpedientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
