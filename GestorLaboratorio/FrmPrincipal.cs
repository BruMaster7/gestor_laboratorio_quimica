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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
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
    }
}
