using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Entidades;

namespace GestorLaboratorio
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
            btnAgregarAgenda.Click += btnAgregarAgenda_Click;
            this.Load += FrmAgenda_Load;
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            CargarPracticas();
        }

        private void CargarPracticas()
        {
            try
            {
                var practicas = SistemaFacade.Instancia.ObtenerPracticas();
                // Mapear a una lista anónima para mostrar columnas existentes en designer
                var listaMostrar = practicas.Select(p => new
                {
                    Fecha = p.Fecha.ToString("yyyy-MM-dd"),
                    Hora = p.Fecha.ToString("HH:mm"),
                    Docente = p.Docente,
                    Practica = p.Objetivo,
                    Grupo = p.CantidadEstudiantes,
                    Id = p.IdPractica
                }).ToList();

                dgvPracticasProg.DataSource = null;
                dgvPracticasProg.DataSource = listaMostrar;
                if (dgvPracticasProg.Columns.Contains("Id"))
                    dgvPracticasProg.Columns["Id"].Visible = false;
                dgvPracticasProg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar prácticas: " + ex.Message);
            }
        }

        private void btnAgregarAgenda_Click(object? sender, EventArgs e)
        {
            try
            {
                DateTime fechaHora = dtpFechaAgenda.Value.Date + dtpHoraAgenda.Value.TimeOfDay;

                if (fechaHora < DateTime.Now.AddHours(48))
                {
                    MessageBox.Show("La práctica debe solicitarse con al menos 48 horas de anticipación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validaciones adicionales: objetivo (práctica) y cantidad de estudiantes > 0
                string objetivo = txtPracticaAgenda.Text.Trim();
                if (string.IsNullOrWhiteSpace(objetivo))
                {
                    MessageBox.Show("Por favor, indique la Práctica/Objetivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtGrupoAgenda.Text.Trim(), out var grupo) || grupo <= 0)
                {
                    MessageBox.Show("La cantidad de alumnos debe ser un número entero mayor que 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var practica = new Practica
                {
                    Fecha = fechaHora,
                    Docente = txtDocenteAgenda.Text.Trim(),
                    Objetivo = objetivo,
                    CantidadEstudiantes = grupo,
                    Detalles = txtDetallesAgenda.Text.Trim()
                };

                int id = SistemaFacade.Instancia.AgregarPractica(practica);

                MessageBox.Show("Práctica agendada y solicitud generada ✅ (ID: " + id + ")", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // limpiar formulario (opcional)
                txtDocenteAgenda.Clear();
                txtGrupoAgenda.Clear();
                txtPracticaAgenda.Clear();
                txtDetallesAgenda.Clear();
                dtpFechaAgenda.Value = DateTime.Now;
                dtpHoraAgenda.Value = DateTime.Now;

                CargarPracticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la práctica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarAgenda_Click_1(object sender, EventArgs e)
        {

        }
    }
}
