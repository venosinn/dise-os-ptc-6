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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void pnlLateral_Paint(object sender, PaintEventArgs e)
        {

        }
        private void personalizarDiseño()
        {
            pnlSubUsuarios.Visible = false;
            pnlSubEmpleados.Visible = false;
            pnlSubPacientes.Visible = false;
            pnlSubDiagnosticos.Visible = false;
            pnlSubTratamientos.Visible = false;
            pnlSubHistoriales.Visible = false;
            pnlSubCitas.Visible = false;
        }
        private void ocultarSubs()
        {
            if(pnlSubUsuarios.Visible == true) { pnlSubUsuarios.Visible = false; }
            if (pnlSubEmpleados.Visible == true) { pnlSubEmpleados.Visible = false; }
            if (pnlSubPacientes.Visible == true) { pnlSubPacientes.Visible = false; }
            if (pnlSubDiagnosticos.Visible == true) { pnlSubDiagnosticos.Visible = false; }
            if (pnlSubTratamientos.Visible == true) { pnlSubTratamientos.Visible = false; }
            if (pnlSubHistoriales.Visible == true) { pnlSubHistoriales.Visible = false; }
            if (pnlSubCitas.Visible == true) { pnlSubCitas.Visible = false; }
        }
        private void mostrarSubs(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubs();
                subMenu.Visible = true;
            } else { subMenu.Visible = false; }
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
           
        }

        private void btnListaEspecialidades_Click(object sender, EventArgs e)
        {
            //codigo 
            abrirChildForms(new frmEspecialidades());
        }

        private void btnAgregarEspecialidades_Click(object sender, EventArgs e)
        {
            //codigo 
            
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
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

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public frmPrincipal(Usuarios u)
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubEmpleados);
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubUsuarios);
        }
        
        private void pnlSubUsuarios_Paint(object sender, PaintEventArgs e)
        {
           
            
            
            
        }

        private void btnEspecialidades_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmEspecialidades());
            ocultarSubs();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubPacientes);
        }

        private void btnDiagnosticos_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubDiagnosticos);
        }

        private void btnTratamientos_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubTratamientos);
        }

        private void btnHistoriales_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubHistoriales);
        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubCitas);
        }

        private void btnListaUsuarios_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaUsuarios());
         
        }
        Form ag_us = null;
        private void btnAgergarUsuarios_Click_1(object sender, EventArgs e)
        {

            if (ag_us != null)
                ag_us.Close();
            ag_us = new frmAgregarUsuarios();
            ag_us.ShowDialog();
            //cargarUsuarios();
        }

        private void btnListaEmpleados_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaEmpleados());
        }
        Form ae = null;
        private void btnAgregarEmpleados_Click_1(object sender, EventArgs e)
        {
            if (ae != null)
                ae.Close();
            ae = new frmAgregarEmpleado();
            ae.ShowDialog();
        }

        private void btnExpedientes_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaExpediente());
            ocultarSubs();
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

        private void button4_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaDiagnosticos());
            ocultarSubs();
        }
        Form ad = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (ad != null)
                ad.Close();
            ad = new frmAgregarDiagnostico();
            ad.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaTratamientos());
            ocultarSubs();
        }
        Form at=null;
        private void button5_Click(object sender, EventArgs e)
        {
            if (at != null)
                ad.Close();
            ad = new frmAgregarDiagnostico();
            ad.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaHistoriales());
            ocultarSubs();
        }
        Form ah = null;
        private void button7_Click(object sender, EventArgs e)
        {
            if (ah != null)
                ah.Close();
            ah = new frmAgregarHistorial();
            ah.ShowDialog();
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
    }
}
