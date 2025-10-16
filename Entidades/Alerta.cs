using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alerta
    {
        public int IdAlerta { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Activo { get; set; }
        public int? IdSustancia { get; set; } // Nullable para accesorios

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
