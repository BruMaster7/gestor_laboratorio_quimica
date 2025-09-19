using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AccesorioService
    {
        private AccesorioDAO accesorioDAO;

        public AccesorioService()
        {
            accesorioDAO = new AccesorioDAO();
        }

        public Accesorio ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser un número positivo.");
            return accesorioDAO.ObtenerAccesorioPorId(id);
        }

        public void AgregarAccesorio(Accesorio a)
        {
            if (string.IsNullOrWhiteSpace(a.Nombre))
                throw new ArgumentException("El nombre del accesorio no puede estar vacío.");

            accesorioDAO.Insertar(a);
        }

        public List<Accesorio> ObtenerTodos()
        {
            return accesorioDAO.ObtenerTodos();
        }

        public Accesorio ObtenerPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");

            return accesorioDAO.ObtenerPorNombre(nombre);
        }

        public List<Accesorio> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");
            return accesorioDAO.BuscarPorNombre(nombre);
        }

        public void ActualizarAccesorio(Accesorio a)
        {
            if (string.IsNullOrWhiteSpace(a.Nombre))
                throw new ArgumentException("El nombre del accesorio no puede estar vacío.");

            accesorioDAO.Actualizar(a);
        }

        public void EliminarAccesorio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");

            accesorioDAO.Eliminar(nombre);
        }

        public bool ExistePorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");
            return accesorioDAO.ExistePorNombre(nombre);
        }
    }
}
