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
    public partial class FrmAltaSustancias : Form
    {
        public FrmAltaSustancias()
        {
            InitializeComponent();


        }

        private void btnAgregarSus_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Crear objeto Sustancia
                Sustancia nueva = new Sustancia
                {
                    Nombre = txtNombreSus.Text.Trim(),
                    Categoria = cmbCategoriaSus.Text, // ComboBox, se toma el texto seleccionado
                    UnidadMedida = cmbUnidadSus.Text,
                    DescripcionManipulacion = txtManipulacionSus.Text.Trim(),
                    Ubicacion = txtUbicacionSus.Text.Trim(),
                    FechaIngreso = dtpIngresoSus.Value,
                    FechaVencimiento = dtpVencimientoSus.Value,
                    StockActual = (int)numStockActualSus.Value,
                    StockMinimo = (int)nudStockMínSus.Value,
                    Peligrosidad = cmbPeligrosidadSus.Text,
                    EnvaseRecomendado = txtEnvaseSus.Text.Trim()
                };

                // ⚠️ txtIncompSus: si usás incompatibilidades, lo podemos manejar aparte en otro DAO
                // por ahora lo guardamos como string "pendiente de procesar"
                string incompatibilidad = txtIncompSus.Text.Trim();

                // 2. Guardar en la BD
                SistemaFacade.Instancia.AgregarSustancia(nueva);
                // 3. Aviso al usuario
                MessageBox.Show("Sustancia agregada con éxito. ID generado: " + nueva.IdSustancia,
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. (Opcional) limpiar campos
                txtNombreSus.Clear();
                cmbCategoriaSus.SelectedIndex = -1;
                cmbUnidadSus.SelectedIndex = -1;
                txtManipulacionSus.Clear();
                txtUbicacionSus.Clear();
                numStockActualSus.Value = 0;
                nudStockMínSus.Value = 0;
                cmbPeligrosidadSus.SelectedIndex = -1;
                txtEnvaseSus.Clear();
                txtIncompSus.Clear();
                dtpIngresoSus.Value = DateTime.Now;
                dtpVencimientoSus.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la sustancia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
