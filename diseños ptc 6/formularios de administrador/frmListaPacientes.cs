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
    public partial class frmListaPacientes : Form
    {
        public frmListaPacientes()
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

        Form ac = null;
        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            if (ac != null)
            {
                ac.Close();
            }
           ac = new frmActualizarPacientes();
            ac.Show();
        }

        private void frmListaPacientes_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }
        private void MostrarPacientes()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = Pacientes.CargarPacientes();
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

