using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorLaboratorio
{
    public partial class FrmHistorial : Form
    {
        private readonly HistorialDAO historialDAO;

        public FrmHistorial()
        {
            InitializeComponent();
            historialDAO = new HistorialDAO();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            try
            {
                listHistorial.Items.Clear();
                var lista = historialDAO.ObtenerTodas();

                foreach (var h in lista)
                {
                    // El ToString de Historial ya formatea la fecha y el movimiento
                    listHistorial.Items.Add(h.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImpHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener historial
                HistorialDAO historialDAO = new HistorialDAO();
                List<Historial> lista = historialDAO.ObtenerTodas();

                if (lista.Count == 0)
                {
                    MessageBox.Show("No hay registros en el historial.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2. Configurar PrintDocument
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = "Microsoft Print to PDF"; // imprime en PDF

                // Pregunta dónde guardar el PDF
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    FileName = "Historial_Laboratorio.pdf"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                // Asignar la ruta de salida
                pd.PrinterSettings.PrintFileName = saveDialog.FileName;
                pd.PrinterSettings.PrintToFile = true;

                // Variables de impresión
                int yPos = 40;
                int lineHeight = 20;
                Font font = new Font("Arial", 10);

                pd.PrintPage += (s, ev) =>
                {
                    // Título
                    Font titleFont = new Font("Arial", 14, FontStyle.Bold);
                    ev.Graphics.DrawString("Historial del Laboratorio", titleFont, Brushes.Black, ev.MarginBounds.Left, yPos);
                    yPos += 40;

                    // Contenido
                    foreach (var h in lista)
                    {
                        string texto = $"{h.FechaHora:yyyy-MM-dd HH:mm} - {h.Usuario}: {h.Movimiento}";
                        ev.Graphics.DrawString(texto, font, Brushes.Black, ev.MarginBounds.Left, yPos);
                        yPos += lineHeight;

                        // Nueva página si se llega al final
                        if (yPos > ev.MarginBounds.Bottom)
                        {
                            ev.HasMorePages = true;
                            yPos = 40; // reset para siguiente página
                            return;
                        }
                    }
                    ev.HasMorePages = false;
                };

                // 3. Imprimir (generará el PDF)
                pd.Print();
                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
