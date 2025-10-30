using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Historial
    {
        public int IdHistorial { get; set; }
        public string Usuario { get; set; }
        public string Movimiento { get; set; }
        public DateTime FechaHora { get; set; }

        public override string ToString()
        {
            return $"{FechaHora:yyyy-MM-dd HH:mm} - {Usuario}: {Movimiento}";
        }
    }
}
