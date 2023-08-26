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
    public partial class frmPrincipalSec : Form
    {
        public frmPrincipalSec()
        {
            InitializeComponent();
            personalizarDiseño();
        }
        private void personalizarDiseño()
        {
            
            pnlSubPacientes.Visible = false;
            pnlSubCitas.Visible = false;
        }
        private void ocultarSubs()
        {
           
            if (pnlSubPacientes.Visible == true) { pnlSubPacientes.Visible = false; }
            if (pnlSubCitas.Visible == true) { pnlSubCitas.Visible = false; }
        }
        private Form frmActivo = null;
        private void abrirChildForms(Form childForm)
        {
            if (frmActivo != null)
                frmActivo.Close();
            frmActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void mostrarSubs(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubs();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }
        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubPacientes);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubCitas);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaEmpleadosSec());
        }

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaPacientes());
        }
        private void btnAgregarPacientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaExpediente());
        }

        private void btnListaCitas_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaCitas());
        }
       
        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlSubTratamientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipalSec_Load(object sender, EventArgs e)
        {

        }

        private void btnListaEmpleados_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaEmpleadosSec());
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubEmpleados);
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmEspecialidades());
            ocultarSubs();
        }

        private void btnPacientes_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubPacientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaPacientes());
            ocultarSubs();
        }
        Form ap = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ap != null)
                ap.Close();
            ap = new frmAgregarPaciente();
            ap.ShowDialog();
        }

        private void btnExpedientes_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaExpediente());
            ocultarSubs();
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubDiagnosticos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaDiagnosticos());
            ocultarSubs();
        }

        private void btnHistoriales_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubHistoriales);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaHistoriales());
            ocultarSubs();
        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubCitas);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaCitas());
            ocultarSubs();
        }
        Form ac = null;
        private void button9_Click(object sender, EventArgs e)
        {
            if (ac != null)
                ac.Close();
            ac = new frmAgregarCita();
            ac.ShowDialog();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnCerrarSesion_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
