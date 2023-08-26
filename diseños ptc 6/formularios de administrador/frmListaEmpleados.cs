﻿using Modelos;
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
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form ac_em = null;
        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            if(ac_em != null)
            { ac_em.Close(); }
            ac_em = new frmActualizarEmpleados();
            ac_em.ShowDialog();
        }
        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            dgvListaEmpleados.DataSource = null;
            dgvListaEmpleados.DataSource = Empleados.CargarEmpleados();

        }

        private void dgvListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
