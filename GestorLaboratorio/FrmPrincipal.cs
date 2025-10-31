using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dominio;

namespace GestorLaboratorio
{
    public partial class FrmPrincipal : Form
    {
        // Estado para evitar notificaciones repetidas idénticas
        private int lastAlertCount = 0;
        private string lastAlertSignature = string.Empty;

        public FrmPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();
            if (usuarioLogueado.idRol != 1)
            {
                gestionarUsuariosToolStripMenuItem.Visible = false;
                alertasToolStripMenuItem.Visible = false;
                formularioToolStripMenuItem.Visible = false;
                historialToolStripMenuItem.Visible = false;
                gestiónToolStripMenuItem.Visible = false;
            }
        }

        private void AbrirFormulario(Form nuevo)
        {
            // Cierra cualquier hijo MDI abierto
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Configura el nuevo
            nuevo.MdiParent = this;

            nuevo.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgenda());
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAlertas());
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHistorial());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmFormularios());
        }

        private void gestionarExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGestorSustancias());
        }

        private void añadirNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAltaSustancias());
        }

        private void gestorDeExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGestionAccesorios());
        }

        private void añadirNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAltaAccesorios());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGestionUsuarios());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Inicia el timer que vigila las alertas
            timerAlertas.Start();
            // Verificación inmediata al arrancar
            VerificarAlertasYMostrar();
        }

        // Timer tick: verifica alertas en la base y muestra notificación si procede
        private void timerAlertas_Tick(object? sender, EventArgs e)
        {
            VerificarAlertasYMostrar();
        }

        // Doble click en el icono de notificación abre el formulario de Alertas
        private void notifyIconAlerts_DoubleClick(object? sender, EventArgs e)
        {
            AbrirFormulario(new FrmAlertas());
            // opcional: ocultar globos hasta próxima novedad
            lastAlertSignature = string.Empty;
        }

        // Lógica central para comprobar alertas y notificar
        private void VerificarAlertasYMostrar()
        {
            try
            {
                var alertas = SistemaFacade.Instancia.ObtenerAlertas() ?? new List<Entidades.Alerta>();
                int count = alertas.Count;
                string signature = count > 0 ? $"{count}|{alertas[0].Descripcion}" : string.Empty;

                if (count > 0)
                {
                    // Mostrar notifyicon (si está oculto)
                    notifyIconAlerts.Visible = true;

                    // Mostrar balloon sólo si hay novedad respecto a la última vez
                    if (signature != lastAlertSignature)
                    {
                        string titulo = $"Alertas activas ({count})";
                        string texto = alertas[0].Descripcion;
                        if (texto.Length > 240)
                            texto = texto.Substring(0, 240) + "...";

                        notifyIconAlerts.BalloonTipTitle = titulo;
                        notifyIconAlerts.BalloonTipText = texto;
                        notifyIconAlerts.BalloonTipIcon = ToolTipIcon.Warning;
                        // mostrar por 8 segundos
                        notifyIconAlerts.ShowBalloonTip(8000);

                        // Actualizar estado
                        lastAlertSignature = signature;
                        lastAlertCount = count;
                    }
                }
                else
                {
                    // No hay alertas activas: ocultar icono y resetear estado
                    notifyIconAlerts.Visible = false;
                    lastAlertCount = 0;
                    lastAlertSignature = string.Empty;
                }
            }
            catch (Exception ex)
            {
                // Log o manejo mínimo: no interrumpir la UI por errores en BD
                // Puedes reemplazar con un registro en tu HistorialDAO si lo deseas.
                Console.WriteLine($"Error verificando alertas: {ex.Message}");
            }
        }
    }
}
