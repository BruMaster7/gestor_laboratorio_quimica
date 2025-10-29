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
        private AlertaService alerta = new AlertaService();

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
            alerta.GenerarYGuardarAlertas();
            
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

            // Obtener estado previo para comparar alertas
            var existente = accesorioDAO.ObtenerAccesorioPorId(a.IdAccesorio);
            if (existente == null)
                throw new ArgumentException("El accesorio no existe.");

            // Actualizar en BD
            accesorioDAO.Actualizar(a);

            // Si antes estaba sin stock (<=0) y ahora tiene stock (>0), desactivar alertas de "Accesorio sin stock"
            bool estabaSinStock = existente.StockActual <= 0;
            bool ahoraTieneStock = a.StockActual > 0;
            if (estabaSinStock && ahoraTieneStock)
            {
                var alertaDao = new AlertaDAO();
                alertaDao.DesactivarAlertasPorAccesorioNombre(existente.Nombre, "Accesorio sin stock");
            }

            // Regenerar alertas globales
            alerta.GenerarYGuardarAlertas();
        }

        public void EliminarAccesorio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");

            accesorioDAO.Eliminar(nombre);

            // Eliminar alertas asociadas a este accesorio (descripcion contiene el nombre)
            var alertaDao = new AlertaDAO();
            alertaDao.EliminarPorAccesorioNombre(nombre, "Accesorio sin stock");

            alerta.GenerarYGuardarAlertas();
        }

        public bool ExistePorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");
            return accesorioDAO.ExistePorNombre(nombre);
        }
    }
}
