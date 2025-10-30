using Dominio;
using Entidades;

namespace GestorLaboratorio
{
    public partial class FrmGestionAccesorios : Form
    {
        private int accesorioSeleccionadoId = -1;

        // Lista única de categorías (mantener sincronizada con el alta)
        private readonly string[] categoriasDisponibles = new[]
        {
            "Vidriería",
            "Material metálico",
            "Plásticos y descartables",
            "Instrumentos de medición",
            "Accesorios de calentamiento",
            "Otros"
        };

        public FrmGestionAccesorios()
        {
            InitializeComponent();
            dgvAccesorios.CellClick += dataGridViewAccesorios_CellClick;
        }

        private void FrmGestionAccesorios_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarAccesorios();
        }

        private void btnActualizarGestionAcc_Click(object sender, EventArgs e)
        {
            if (accesorioSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un accesorio primero ❌");
                return;
            }

            // Validaciones consistentes con el alta
            if (string.IsNullOrWhiteSpace(txtNombreGestionAcc.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionGestionAcc.Text) ||
                string.IsNullOrWhiteSpace(txtUbicacionGestionAcc.Text) ||
                string.IsNullOrWhiteSpace(cmbCategoriaGestionAcc.Text))
            {
                MessageBox.Show("Por favor, complete Nombre, Descripción, Ubicación y Categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Descripcion = txtDescripcionGestionAcc.Text.Trim(),
                    Categoria = cmbCategoriaGestionAcc.Text.Trim()
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
            txtFiltroNombre.Text = "";
            CargarAccesorios();
        }

        private void dataGridViewAccesorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // evitar header
            {
                DataGridViewRow fila = dgvAccesorios.Rows[e.RowIndex];

                accesorioSeleccionadoId = Convert.ToInt32(fila.Cells["IdAccesorio"].Value);

                txtNombreGestionAcc.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtUbicacionGestionAcc.Text = fila.Cells["Ubicacion"].Value?.ToString() ?? "";
                nudStockGestionAcc.Value = Convert.ToInt32(fila.Cells["StockActual"].Value);
                txtDescripcionGestionAcc.Text = fila.Cells["Descripcion"].Value?.ToString() ?? "";

                // Intentar asignar categoría si la columna está presente en la grilla
                try
                {
                    bool tieneColCategoria = dgvAccesorios.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Categoria" || c.HeaderText == "Categoria");
                    if (tieneColCategoria)
                    {
                        var valorCat = fila.Cells["Categoria"].Value?.ToString();
                        if (!string.IsNullOrWhiteSpace(valorCat) && cmbCategoriaGestionAcc.Items.Contains(valorCat))
                            cmbCategoriaGestionAcc.SelectedItem = valorCat;
                        else if (!string.IsNullOrWhiteSpace(valorCat))
                        {
                            // Si la categoría viene de BD pero no está en el combo (caso raro), añadirla temporalmente y seleccionarla.
                            cmbCategoriaGestionAcc.Items.Add(valorCat);
                            cmbCategoriaGestionAcc.SelectedItem = valorCat;
                        }
                        else
                            cmbCategoriaGestionAcc.SelectedIndex = -1;
                    }
                    else
                    {
                        // Si la grilla no contiene categoría, no podemos inferirla desde el DAO actual.
                        cmbCategoriaGestionAcc.SelectedIndex = -1;
                    }
                }
                catch
                {
                    cmbCategoriaGestionAcc.SelectedIndex = -1;
                }
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
                    cmbCategoriaGestionAcc.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        // Cargar categorías de forma centralizada y sin elemento vacío
        private void CargarCategorias()
        {
            cmbCategoriaGestionAcc.Items.Clear();
            cmbCategoriaGestionAcc.Items.AddRange(categoriasDisponibles);
            cmbCategoriaGestionAcc.SelectedIndex = -1;
        }
    }
}