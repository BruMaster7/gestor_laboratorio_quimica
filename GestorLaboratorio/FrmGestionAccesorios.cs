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
    public partial class FrmGestionAccesorios : Form
    {
        public FrmGestionAccesorios()
        {
            InitializeComponent();
        }

        private void FrmGestionAccesorios_Load(object sender, EventArgs e)
        {
            CargarAccesorios();

        }

        private void btnActualizarGestionAcc_Click(object sender, EventArgs e)
        {

        }

        private void CargarAccesorios()
        {
            try
            {
                List<Accesorio> accesorios = SistemaFacade.Instancia.ObtenerAccesorios();

                // Vinculamos la lista directamente al DataGridView
                dgvAccesorios.DataSource = null; // limpiar primero
                dgvAccesorios.DataSource = accesorios;

                // Opcional: ajustar columnas automáticamente
                dgvAccesorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los accesorios: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltroNombre.Text.Trim();

                var resultados = SistemaFacade.Instancia.BuscarAccesoriosPorNombre(filtro);

                dgvAccesorios.DataSource = null;
                dgvAccesorios.DataSource = resultados;

                dgvAccesorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar accesorios: " + ex.Message);
            }
        }

        private void btnSinFiltro_Click(object sender, EventArgs e)
        {
            btnBuscar.Text = "";
            CargarAccesorios();
        }
    }
}

