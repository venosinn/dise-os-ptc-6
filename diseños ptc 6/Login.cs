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
    public partial class frmLog_in : Form
    {
        public frmLog_in()
        {
            InitializeComponent();
        }

        private void textbox1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuarios u = new Usuarios();
            u.Nombre_usuario = txtUsuario.Texto;
            u.Clave_usuario = txtClave.Texto;

            MessageBox.Show(u.Nombre_usuario + u.Clave_usuario);

            try
            {
                u = u.IniciarSesion();

                if (u == null)
                {
                    MessageBox.Show("Credenciales invalidas");
                }
                 else
                 {
                    if(u.Id_tipo_us == 1)
                     {
                         frmPrincipal fp = new frmPrincipal(u);

                         Hide();

                         fp.ShowDialog();

                         Show();
                     }
                    else if(u.Id_tipo_us == 4)
                     {
                         frmPrincipalEnfermeros fp = new frmPrincipalEnfermeros();

                         Hide();

                         fp.ShowDialog();

                         Show();
                     }
                     else if (u.Id_tipo_us == 2)
                     {
                         FrmPrincipalDoctores fp = new FrmPrincipalDoctores();

                         Hide();

                         fp.ShowDialog();

                         Show();
                     }
                     else if (u.Id_tipo_us == 3)
                     {
                         frmPrincipalSec fp = new frmPrincipalSec();

                         Hide();

                         fp.ShowDialog();

                         Show();
                     }

            }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            
            


           /* if (txtUsuario.Texto == "admin" && txtClave.Texto == "admin")
            {
                frmPrincipal f1 = new frmPrincipal();
                this.Hide();
                f1.Show();
                f1.Closed += delegate
                {
                    this.Show();
                };
                txtClave.Text = "";
                txtUsuario.Text = "";
            }
            else if (txtUsuario.Texto == "medic" && txtClave.Texto == "medic")
            {
                FrmPrincipalDoctores f1 = new FrmPrincipalDoctores();
                this.Hide();
                f1.Show();
                f1.Closed += delegate
                {
                    this.Show();
                };
                txtClave.Texto = "";
                txtUsuario.Texto = "";
            }
            else if (txtUsuario.Texto == "secret" && txtClave.Texto == "secret")
            {
                frmPrincipalSec fs = new frmPrincipalSec();
                this.Hide();
                fs.Show();
                fs.Closed += delegate
                {
                    this.Show();
                };
                txtClave.Texto = "";
                txtUsuario.Texto = "";
            }
            else if (txtUsuario.Texto == "enfer" && txtClave.Texto == "enfer")
            {
                frmPrincipalEnfermeros fs = new frmPrincipalEnfermeros();
                this.Hide();
                fs.Show();
                fs.Closed += delegate
                {
                    this.Show();
                };
                txtClave.Texto = "";
                txtUsuario.Texto = "";
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/



        }

        private void frmLog_in_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
