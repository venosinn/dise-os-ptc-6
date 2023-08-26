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
    public partial class FrmPrincipalDoctores : Form
    {
        public FrmPrincipalDoctores()
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
        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubPacientes);
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaExpediente());
        }
        //Form agp = null;
        private void btnAgregarPacientes_Click(object sender, EventArgs e)
        {
            //if (agp != null)
              //  agp.Close();
            //agp = new frmAgregarPaciente();
            //agp.ShowDialog();
        }
        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            

            abrirChildForms(new frmListaPacientes());
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

        private void btnListaDiagnosticos_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaDiagnosticos());
        }
        //Form ad = null;
        private void btnAgregarDiagnosticos_Click(object sender, EventArgs e)
        {
           // if (ad != null)
                //ad.Close();
            //ad = new frmAgregarDiagnostico();
            //ad.ShowDialog();
        }

        private void btnListaTratamientos_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaTratamientos());
        }
        //Form at = null; 
        private void btnAgregarTratamientos_Click(object sender, EventArgs e)
        {
            //if (ad != null)
              //  ad.Close();
            //ad = new frmAgregarTratamiento();
            //ad.ShowDialog();

           
        }

        private void btnListaHistoriales_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaHistoriales());
        }
        //Form ah = null;
        private void btnAgregarHistoriales_Click(object sender, EventArgs e)
        {
            //if (ah != null)
              //  ah.Close();
            //ah = new frmAgregarHistorial();
            //ah.ShowDialog();
        }

        private void btnListaCitas_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaCitas());
        }
        //Form ac = null;
        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            //if (ac != null)
              //  ac.Close();
            //ac = new frmAgregarCita();
            //ac.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipalDoctores_Load(object sender, EventArgs e)
        {

        }

        private void pnlSubPacientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubPacientes);
        }

        private void btnListaPacientes_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaPacientes());
        }
        Form agp = null;
        private void btnAgregarPacientes_Click_1(object sender, EventArgs e)
        {
            if (agp != null)
                agp.Close();
            agp = new frmAgregarPaciente();
            agp.ShowDialog();

        }

        private void pnlSubCita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubCita);
        }

        private void btnExpedientes_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaExpediente());
        }

        private void btnDiagnosticos_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubDiagnosticos);
        }

        private void btnListaDiagnosticos_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaDiagnosticos());
        }
        Form ad = null;

        private void btnAgregarDiagnosticos_Click_1(object sender, EventArgs e)
        {
            if (ad != null)
                ad.Close();
            ad = new frmAgregarDiagnostico();
            ad.ShowDialog();
        }

        private void btnTratamientos_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubTratamientos);
        }

        private void btnListaTratamientos_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaTratamientos());
        }
        Form at = null;
        private void btnAgregarTratamientos_Click_1(object sender, EventArgs e)
        {
            if (ad != null)
                ad.Close();
            ad = new frmAgregarTratamiento();
            ad.ShowDialog();
        }

        private void btnHistoriales_Click_1(object sender, EventArgs e)
        {
            mostrarSubs(pnlSubHistoriales);
        }

        private void btnListaHistoriales_Click_1(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaHistoriales());
        }
        Form ah = null;
        private void btnAgregarHistoriales_Click_1(object sender, EventArgs e)
        {
            if (ah != null)
                ah.Close();
            ah = new frmAgregarHistorial();
            ah.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirChildForms(new frmListaCitas());
        }
        Form ac = null;
        private void button1_Click(object sender, EventArgs e)
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
