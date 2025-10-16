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
    public partial class FrmAlertas : Form
    {
        public FrmAlertas()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAlertas_Load(object sender, EventArgs e)
        {
            List<Alerta> alertas = SistemaFacade.Instancia.ObtenerAlertas();
            listAlertas.Items.Clear();
            foreach (var alerta in alertas)
            {
                listAlertas.Items.Add(alerta.Descripcion);
            }
        }
    }
}
