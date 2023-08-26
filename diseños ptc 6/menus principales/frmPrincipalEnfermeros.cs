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
    public partial class frmPrincipalEnfermeros : Form
    {
        public frmPrincipalEnfermeros()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {

            pnlSubPacientes.Visible = false;
            pnlSubDiagnosticos.Visible = false;
            pnlSubTratamientos.Visible = false;
            pnlSubHistoriales.Visible = false;
            pnlSubCitas.Visible = false;
        }

        private void ocultarSubs()
        {

            if (pnlSubPacientes.Visible == true) { pnlSubPacientes.Visible = false; }
            if (pnlSubDiagnosticos.Visible == true) { pnlSubDiagnosticos.Visible = false; }
            if (pnlSubTratamientos.Visible == true) { pnlSubTratamientos.Visible = false; }
            if (pnlSubHistoriales.Visible == true) { pnlSubHistoriales.Visible = false; }
            if (pnlSubCitas.Visible == true) { pnlSubCitas.Visible = false; }
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

        private void frmPrincipalEnfermeros_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListaDiagnosticos_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaDiagnosticos());
        }

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaPacientes());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubPacientes);
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaExpediente());
            ocultarSubs();
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubDiagnosticos);
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubTratamientos);
        }

        private void btnHistoriales_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubHistoriales);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubCitas);
        }
        Form ag_pac = null;
        private void btnAgregarPacientes_Click(object sender, EventArgs e)
        {
            if (ag_pac != null)
                ag_pac.Close();
            ag_pac = new frmAgregarPaciente();
            ag_pac.ShowDialog();
        }
        Form ag_di = null;
        private void btnAgregarDiagnosticos_Click(object sender, EventArgs e)
        {
            if (ag_di != null)
            { ag_di.Close(); }
            ag_di = new frmAgregarDiagnostico();
            ag_di.ShowDialog();
        }

        private void btnListaTratamientos_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaTratamientos());
        }
        Form at = null;
        private void btnAgregarTratamientos_Click(object sender, EventArgs e)
        {
            if (at != null)
            { at.Close(); }
            at = new frmAgregarTratamiento();
            at.ShowDialog();
        }

        private void btnListaHistoriales_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaHistoriales());
        }
        Form ah = null;
        private void btnAgregarHistoriales_Click(object sender, EventArgs e)
        {
            if (ah != null)
            { ah.Close(); }
            ah = new frmAgregarHistorial();
            ah.ShowDialog();
        }

        private void btnListaCitas_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaCitas());
        }
        Form ac = null;
        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            if (ac != null)
            { ac.Close(); }
            ac = new frmAgregarCita();
            ac.ShowDialog();
        }

        private void btnPacientes_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubPacientes);
        }

        private void btnExpedientes_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaExpediente());
            ocultarSubs();
        }

        private void btnDiagnosticos_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubDiagnosticos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaDiagnosticos());
            ocultarSubs();
        }

        private void btnTratamientos_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubTratamientos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaTratamientos());
            ocultarSubs();
        }

        private void btnHistoriales_Click_1(object sender, EventArgs e)
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

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaPacientes());
            ocultarSubs();
        }

        private void btnCerrarSesion_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
