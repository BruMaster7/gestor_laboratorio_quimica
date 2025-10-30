using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public static class SesionActual
    {
        public static Usuario UsuarioLogueado { get; set; }

        public static string NombreUsuario => UsuarioLogueado?.nombre ?? "Desconocido";
    }
}
