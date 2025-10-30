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
    public partial class FrmGestorSustancias : Form
    {
        private int SustanciaSeleccionadaId = -1;

        public FrmGestorSustancias()
        {
            InitializeComponent();
            dgvSus.CellClick += dataGridViewSustancias_CellClick;
        }

        private void FrmGestorSustancias_Load(object sender, EventArgs e)
        {
            CargarSustancias();
            cargarCategorias();
            cargarUbicaciones();

            cmbUbiFiltro.SelectedIndex = 0;

        }

        private void CargarSustancias()
        {
            try
            {
                List<Sustancia> sustancias = SistemaFacade.Instancia.ObtenerSustancias();

                dgvSus.DataSource = null;
                dgvSus.DataSource = sustancias;

                dgvSus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sustancias: " + ex.Message);
            }
        }

        private void cargarCategorias()
        {
            try
            {
                // Evaluar el resultado de la función para obtener la lista de categorías
                var categorias = SistemaFacade.Instancia.ObtenerCategorias();

                cmbCategoriaFiltro.Items.Clear();
                cmbCategoriaFiltro.Items.AddRange(categorias.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }

        private void cargarUbicaciones()
        {
            try
            {
                // Evaluar el resultado de la función para obtener la lista de ubicaciones
                var ubicaciones = SistemaFacade.Instancia.ObtenerUbicaciones();
                cmbUbiFiltro.Items.Clear();
                cmbUbiFiltro.Items.AddRange(ubicaciones.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ubicaciones: " + ex.Message);
            }
        }

        private void dataGridViewSustancias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // evitar header
            {
                DataGridViewRow fila = dgvSus.Rows[e.RowIndex];

                SustanciaSeleccionadaId = Convert.ToInt32(fila.Cells["IdSustancia"].Value);

                txtNombreGestorSus.Text = fila.Cells["Nombre"].Value.ToString();
                cmbCategoriaGestorSus.Text = fila.Cells["Categoria"].Value.ToString();
                txtUbicacionGestorSus.Text = fila.Cells["Ubicacion"].Value.ToString();
                nudStockMGestorSus.Value = Convert.ToInt32(fila.Cells["StockMinimo"].Value);
                txtManRecGestionSus.Text = fila.Cells["DescripcionManipulacion"].Value.ToString();
                nudStockAGestorSus.Value = Convert.ToInt32(fila.Cells["StockActual"].Value);
                cmbUnidad.Text = fila.Cells["UnidadMedida"].Value.ToString();
                txtEnvase.Text = fila.Cells["EnvaseRecomendado"].Value.ToString();
                txtIncompGestionSus.Text = fila.Cells["Peligrosidad"].Value.ToString();
                dtpFechaIngGestionSus.Value = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value);
                dtpFechaVencGestionSus.Value = Convert.ToDateTime(fila.Cells["FechaVencimiento"].Value);
                cmbPeligrosidadGestionSus.Text = fila.Cells["Peligrosidad"].Value.ToString();


            }
        }

        private void btnEliminarGestionSus_Click(object sender, EventArgs e)
        {
            if (SustanciaSeleccionadaId == -1)
            {
                MessageBox.Show("Seleccione una Sustancia primero ❌");
                return;
            }

            try
            {
                var sustancia = SistemaFacade.Instancia.ObtenerSustanciaPorId(SustanciaSeleccionadaId);
                if (sustancia == null)
                {
                    MessageBox.Show("No se encontró la sustancia seleccionada ❌");
                    return;
                }
                var confirmResult = MessageBox.Show($"¿Está seguro de eliminar la sustancia '{sustancia.Nombre}'? ❌",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    SistemaFacade.Instancia.EliminarSustancia(sustancia.IdSustancia);
                    MessageBox.Show("Sustancia eliminada correctamente ✅");
                    // refrescar grilla
                    dgvSus.DataSource = null;
                    dgvSus.DataSource = SistemaFacade.Instancia.ObtenerSustancias();
                    // limpiar selección
                    SustanciaSeleccionadaId = -1;
                    txtNombreGestorSus.Clear();
                    cmbCategoriaGestorSus.Items.Clear();
                    txtUbicacionGestorSus.Clear();
                    nudStockMGestorSus.Value = 0;
                    txtManRecGestionSus.Clear();
                    nudStockAGestorSus.Value = 0;
                    cmbUnidad.Items.Clear();
                    txtEnvase.Clear();
                    txtIncompGestionSus.Clear();
                    //limpiar demas campos
                    dtpFechaIngGestionSus.Value = DateTime.Now;
                    dtpFechaVencGestionSus.Value = DateTime.Now;
                    cmbPeligrosidadGestionSus.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        private void btnCambiarSus_Click(object sender, EventArgs e)
        {
            if (SustanciaSeleccionadaId == -1)
            {
                MessageBox.Show("Seleccione una Sustancia primero ❌");
                return;
            }

            try
            {
                var sustancia = SistemaFacade.Instancia.ObtenerSustanciaPorId(SustanciaSeleccionadaId);
                if (sustancia == null)
                {
                    MessageBox.Show("No se encontró la sustancia seleccionada ❌");
                    return;
                }

                // Actualizar propiedades con los valores del formulario
                sustancia.Nombre = txtNombreGestorSus.Text;
                sustancia.Categoria = cmbCategoriaGestorSus.Text;
                sustancia.Ubicacion = txtUbicacionGestorSus.Text;
                sustancia.StockMinimo = (int)nudStockMGestorSus.Value;
                sustancia.DescripcionManipulacion = txtManRecGestionSus.Text;
                sustancia.StockActual = (int)nudStockAGestorSus.Value;
                sustancia.UnidadMedida = cmbUnidad.Text;
                sustancia.EnvaseRecomendado = txtEnvase.Text;
                sustancia.Peligrosidad = cmbPeligrosidadGestionSus.Text;
                sustancia.FechaIngreso = dtpFechaIngGestionSus.Value;
                sustancia.FechaVencimiento = dtpFechaVencGestionSus.Value;

                // Parsear incompatibilidades desde txtArea
                List<int> idsIncompatibles = txtIncompGestionSus.Text
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x.Trim()))
                    .ToList();

                // Actualizar en el sistema junto con incompatibilidades
                SistemaFacade.Instancia.ActualizarSustancia(sustancia, idsIncompatibles);

                MessageBox.Show("Sustancia modificada correctamente ✅");

                // Refrescar grilla
                dgvSus.DataSource = null;
                dgvSus.DataSource = SistemaFacade.Instancia.ObtenerSustancias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros
            string categoriaFiltro = cmbCategoriaFiltro.SelectedItem?.ToString();
            string ubicacionFiltro = cmbUbiFiltro.SelectedItem?.ToString();
            string nombreFiltro = txtFiltroNombre.Text.Trim();
            try
            {
                var resultados = SistemaFacade.Instancia.Buscar(nombreFiltro, categoriaFiltro, ubicacionFiltro);
                dgvSus.DataSource = null;
                dgvSus.DataSource = resultados;
                dgvSus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar sustancias: " + ex.Message);
            }
        }

        private void btnSinFiltro_Click(object sender, EventArgs e)
        {
            // Limpiar filtros
            cmbCategoriaFiltro.SelectedIndex = -1;
            cmbUbiFiltro.SelectedIndex = 0; // Asumiendo que el índice 0 es "Todos" o el valor inicial
            txtFiltroNombre.Clear();

            // Recargar todas las sustancias
            CargarSustancias();
        }

        private void dgvSus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

