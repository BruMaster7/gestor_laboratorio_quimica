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
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }
        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
        private void cargarUsuarios()
        {
            try
            {
                List<Usuario> usuarios = SistemaFacade.Instancia.ObtenerUsuarios();

                var listaMostrar = usuarios.Select(u => new { u.nombre }).ToList();

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = listaMostrar;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //crear objeto usuario
                Usuario nuevo = new Usuario
                {
                    nombre = txtnombreUsuario.Text.Trim(),
                    contrasena = txtContrasenaUsuario.Text.Trim(),
                    idRol = 2
                };

                //mostrar en console


                //guardar en la bd
                SistemaFacade.Instancia.AgregarUsuario(nuevo);
                MessageBox.Show("Usuario creado con éxito",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtUsuarioAborrar.Text.Trim();
                SistemaFacade.Instancia.EliminarUsuario(nombreUsuario);
                MessageBox.Show("Usuario eliminado con éxito",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}