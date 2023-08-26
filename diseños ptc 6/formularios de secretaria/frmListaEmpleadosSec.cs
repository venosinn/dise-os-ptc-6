using Modelos;
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
    public partial class frmListaEmpleadosSec : Form
    {
        public frmListaEmpleadosSec()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaEmpleadosSec_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            dgvListaEmpleados.DataSource = null;
            dgvListaEmpleados.DataSource = Empleados.CargarEmpleados();
        }
        
        
    }
}
