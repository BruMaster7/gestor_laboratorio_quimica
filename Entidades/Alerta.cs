using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alerta
    {
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Activo { get; set; }
    }
}
