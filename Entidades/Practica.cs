using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Practica
    {
        public int IdPractica { get; set; }
        public DateTime Fecha { get; set; }
        public string Docente { get; set; } // ahora varchar tomado del textbox
        public string Objetivo { get; set; }
        public int CantidadEstudiantes { get; set; }
    }
}
