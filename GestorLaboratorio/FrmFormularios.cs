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
    public partial class FrmFormularios : Form
    {
        private List<SolicitudPractica> solicitudes = new List<SolicitudPractica>();

        public FrmFormularios()
        {
            InitializeComponent();
            this.Load += FrmFormularios_Load;
            listSolicitudesForms.SelectedIndexChanged += listSolicitudesForms_SelectedIndexChanged;
            btnAprobarForms.Click += btnAprobarForms_Click;
            btnRechazarForms.Click += btnRechazarForms_Click;
        }

        private void FrmFormularios_Load(object sender, EventArgs e)
        {
            CargarSolicitudes();
            txtDocenteForms.ReadOnly = true;
            txtFechaHoraForms.ReadOnly = true;
            txtGrupoForms.ReadOnly = true;
            txtDetallesForms.ReadOnly = true;

        }

        private void CargarSolicitudes()
        {
            try
            {
                solicitudes = SistemaFacade.Instancia.ObtenerSolicitudesPractica();
                listSolicitudesForms.DataSource = null;
                listSolicitudesForms.DataSource = solicitudes;
                // ToString en SolicitudPractica se usa para mostrar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar solicitudes: " + ex.Message);
            }
        }

        private void listSolicitudesForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSolicitudesForms.SelectedItem is SolicitudPractica s)
            {
                txtDocenteForms.Text = s.Docente;
                txtFechaHoraForms.Text = s.FechaPractica.ToString("yyyy-MM-dd HH:mm");
                txtGrupoForms.Text = s.Grupo;
                txtDetallesForms.Text = s.Detalles;
            }
        }

        private void btnAprobarForms_Click(object sender, EventArgs e)
        {
            if (listSolicitudesForms.SelectedItem is SolicitudPractica s)
            {
                SistemaFacade.Instancia.AprobarSolicitud(s.IdSolicitud);
                MessageBox.Show("Solicitud aprobada ✅");
                CargarSolicitudes();
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud primero.");
            }
        }

        private void btnRechazarForms_Click(object sender, EventArgs e)
        {
            if (listSolicitudesForms.SelectedItem is SolicitudPractica s)
            {
                var confirm = MessageBox.Show("¿Desea rechazar la solicitud y eliminar la práctica agendada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    SistemaFacade.Instancia.RechazarSolicitud(s.IdSolicitud);
                    MessageBox.Show("Solicitud y práctica eliminadas ✅");
                    CargarSolicitudes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud primero.");
            }
        }

        private void btnAprobarForms_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmFormularios_Load_1(object sender, EventArgs e)
        {

        }
    }
}
