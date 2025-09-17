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
    public partial class FrmAltaAccesorios : Form
    {
        public FrmAltaAccesorios()
        {
            InitializeComponent();
        }

        private void btnAgregarAcc_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAltaAcc.Text.Trim();
            string descripcion = txtDescripcionAltaAcc.Text.Trim();
            string ubicacion = txtUbicacionAltaAcc.Text.Trim();
            string stockStr = nudStockAltaAcc.Text.Trim();
            string categoria = cmbCategoriaAltaAcc.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) ||
                string.IsNullOrEmpty(ubicacion) || string.IsNullOrEmpty(stockStr) ||
                string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(stockStr, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var nuevoAccesorio = new Entidades.Accesorio
            {
                Nombre = nombre,
                Descripcion = descripcion,
                StockActual = stock,
                Ubicacion = ubicacion
            };
            try
            {
                Dominio.SistemaFacade.Instancia.AgregarAccesorio(nuevoAccesorio);
                MessageBox.Show("Accesorio agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar accesorio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
