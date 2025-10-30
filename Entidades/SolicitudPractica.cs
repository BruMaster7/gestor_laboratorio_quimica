using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SolicitudPractica
    {
        public int IdSolicitud { get; set; }
        public int IdPractica { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Estado { get; set; }

        // Campos auxiliares llenados por el DAO para mostrar en UI
        public DateTime FechaPractica { get; set; }
        public string Docente { get; set; }
        public string NombrePractica { get; set; }
        public string Grupo { get; set; }

        public override string ToString()
        {
            return $"[{FechaPractica:yyyy-MM-dd}] - {Docente} - Práctica: {NombrePractica}";
        }
    }
}
