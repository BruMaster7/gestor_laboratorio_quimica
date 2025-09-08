using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Accesorio
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int StockActual { get; set; }
        public string Ubicacion { get; set; }

        //public void ActualizarStock(int cantidad) { /* Lógica de actualización */ }
        //public bool EstaDisponible() { /* Lógica de disponibilidad */ }
    }
}
