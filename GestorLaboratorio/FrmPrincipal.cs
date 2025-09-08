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

        private void sustanciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSustancias frm = new FrmSustancias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccesorios frm = new FrmAccesorios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda frmAgenda = new FrmAgenda();
            frmAgenda.MdiParent = this;
            frmAgenda.Show();
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlertas frmAlertas = new FrmAlertas();
            frmAlertas.MdiParent = this;
            frmAlertas.Show();
           


        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            frmHistorial.MdiParent = this;
            frmHistorial.Show();
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
            FrmFormularios frmFormularios = new FrmFormularios();
            frmFormularios.MdiParent = this;
            frmFormularios.Show();
        }
    }
}
