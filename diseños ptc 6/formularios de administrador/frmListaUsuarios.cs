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
    public partial class frmListaUsuarios : Form
    {
        public frmListaUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form Tipos = null;
        private void btnTiposUsuarios_Click(object sender, EventArgs e)
        {
            if(Tipos != null) { 
            Tipos.Close();
            }
            Tipos = new frmTiposUsuarios();
            Tipos.Show();
        }
        Form ac_us = null;
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (ac_us != null)
            {
                ac_us.Close();
            }
            ac_us= new frmActualizarUsuarios();
            ac_us.Show();
        }

        private void frmListaUsuarios_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
