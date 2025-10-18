using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class usuarioService
    {
            private UsuarioDAO dao;
            public usuarioService()
            {
                dao = new UsuarioDAO();
        }
        public void AgregarUsuario(Usuario nuevo) {
            if (string.IsNullOrWhiteSpace(nuevo.nombre))
                throw new ArgumentException("El nombre de usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(nuevo.contrasena))
                throw new ArgumentException("La contraseña es obligatoria.");
            dao.AgregarUsuario(nuevo); }

        public  void EliminarUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario es obligatorio.");
            dao.EliminarUsuario(nombreUsuario);
        }

        public  List<Usuario> ObtenerUsuarios()
        {
            return dao.ObtenerUsuarios();
        }

        public bool Login(string usuarioValido, string claveValida)
        {
            if (string.IsNullOrWhiteSpace(usuarioValido) || string.IsNullOrWhiteSpace(claveValida))
            {
                return false;
            }else
            {
                return dao.ValidarUsuario(usuarioValido, claveValida);
            }
        }

        public bool EsAdmin(string usuario)
        {
            return dao.UsuarioEsAdmin(usuario);
        }
    }
    }
