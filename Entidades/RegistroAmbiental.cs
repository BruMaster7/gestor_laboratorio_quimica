using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RegistroAmbiental
    {
        public string TipoGasDetectado { get; set; }
        public DateTime FechaHora { get; set; }
        public float Nivel { get; set; }
    }
}
