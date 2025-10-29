using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorLaboratorio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
         
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Datos fijos temporales
            string usuarioValido = txtUsuario.Text;
            string claveValida = txtClave.Text;
            bool usuarioLogeado = SistemaFacade.Instancia.Login(usuarioValido, claveValida);
            if (usuarioLogeado)
            {
                Usuario usuarioLogueado = SistemaFacade.Instancia.ObtenerUsuarioPorNombre(usuarioValido);
                // Credenciales
                SesionActual.UsuarioLogueado = usuarioLogueado;
                FrmPrincipal frmPrincipal = new FrmPrincipal(usuarioLogueado);
                frmPrincipal.Show();
                this.Hide(); // Ocultar el formulario de login
            }
            else
            {
                // Credenciales incorrectas
                MessageBox.Show("Usuario o clave incorrectos. Inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
