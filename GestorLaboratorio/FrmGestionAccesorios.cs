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
        private int accesorioSeleccionadoId = -1;

        public FrmGestionAccesorios()
        {
            InitializeComponent();
            dgvAccesorios.CellClick += dataGridViewAccesorios_CellClick;
        }

        private void FrmGestionAccesorios_Load(object sender, EventArgs e)
        {
            CargarAccesorios();

        }

        private void btnActualizarGestionAcc_Click(object sender, EventArgs e)
        {
            if (accesorioSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un accesorio primero ❌");
                return;
            }

            try
            {

                var accesorio = new Accesorio
                {
                    IdAccesorio = accesorioSeleccionadoId,
                    Nombre = txtNombreGestionAcc.Text.Trim(),
                    Ubicacion = txtUbicacionGestionAcc.Text.Trim(),
                    StockActual = (int)nudStockGestionAcc.Value,
                    Descripcion = txtDescripcionGestionAcc.Text.Trim()
                };

                SistemaFacade.Instancia.ActualizarAccesorio(accesorio);

                MessageBox.Show("Accesorio actualizado correctamente ✅");

                // refrescar grilla
                dgvAccesorios.DataSource = null;
                dgvAccesorios.DataSource = SistemaFacade.Instancia.ObtenerAccesorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }



        private void CargarAccesorios()
        {
            try
            {
                List<Accesorio> accesorios = SistemaFacade.Instancia.ObtenerAccesorios();

                dgvAccesorios.DataSource = null;
                dgvAccesorios.DataSource = accesorios;

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

        private void dataGridViewAccesorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // evitar header
            {
                DataGridViewRow fila = dgvAccesorios.Rows[e.RowIndex];

                accesorioSeleccionadoId = Convert.ToInt32(fila.Cells["IdAccesorio"].Value);

                txtNombreGestionAcc.Text = fila.Cells["Nombre"].Value.ToString();
                txtUbicacionGestionAcc.Text = fila.Cells["Ubicacion"].Value.ToString();
                nudStockGestionAcc.Value = Convert.ToInt32(fila.Cells["StockActual"].Value);
                txtDescripcionGestionAcc.Text = fila.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnEliminarGestionAcc_Click(object sender, EventArgs e)
        {
            if (accesorioSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un accesorio primero ❌");
                return;
            }

            try
            {
                var accesorio = SistemaFacade.Instancia.ObtenerAccesorioPorId(accesorioSeleccionadoId);
                if (accesorio == null)
                {
                    MessageBox.Show("No se encontró el accesorio seleccionado ❌");
                    return;
                }
                var confirmResult = MessageBox.Show($"¿Está seguro de eliminar el accesorio '{accesorio.Nombre}'? ❌",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    SistemaFacade.Instancia.EliminarAccesorio(accesorio.Nombre);
                    MessageBox.Show("Accesorio eliminado correctamente ✅");
                    // refrescar grilla
                    dgvAccesorios.DataSource = null;
                    dgvAccesorios.DataSource = SistemaFacade.Instancia.ObtenerAccesorios();
                    // limpiar selección
                    accesorioSeleccionadoId = -1;
                    txtNombreGestionAcc.Clear();
                    txtUbicacionGestionAcc.Clear();
                    nudStockGestionAcc.Value = 0;
                    txtDescripcionGestionAcc.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }
    }
}

