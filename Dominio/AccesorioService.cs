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
        private readonly AccesorioDAO accesorioDAO;
        private readonly AlertaService alerta;
        private readonly HistorialDAO historialDAO;

        public AccesorioService()
        {
            accesorioDAO = new AccesorioDAO();
            alerta = new AlertaService();
            historialDAO = new HistorialDAO();
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

            // 🔹 Registrar en historial
            historialDAO.RegistrarMovimiento(SesionActual.NombreUsuario, $"Agregó Accesorio: {a.Nombre}");
        }

        public List<Accesorio> ObtenerTodos() => accesorioDAO.ObtenerTodos();

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

            var existente = accesorioDAO.ObtenerAccesorioPorId(a.IdAccesorio);
            if (existente == null)
                throw new ArgumentException("El accesorio no existe.");

            accesorioDAO.Actualizar(a);

            bool estabaSinStock = existente.StockActual <= 0;
            bool ahoraTieneStock = a.StockActual > 0;
            if (estabaSinStock && ahoraTieneStock)
            {
                var alertaDao = new AlertaDAO();
                alertaDao.DesactivarAlertasPorAccesorioNombre(existente.Nombre, "Accesorio sin stock");
            }

            alerta.GenerarYGuardarAlertas();

            // 🔹 Registrar en historial
            historialDAO.RegistrarMovimiento(SesionActual.NombreUsuario, $"Actualizó Accesorio: {a.Nombre}");
        }

        public void EliminarAccesorio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");

            accesorioDAO.Eliminar(nombre);

            var alertaDao = new AlertaDAO();
            alertaDao.EliminarPorAccesorioNombre(nombre, "Accesorio sin stock");
            alerta.GenerarYGuardarAlertas();

            // 🔹 Registrar en historial
            historialDAO.RegistrarMovimiento(SesionActual.NombreUsuario, $"Eliminó Accesorio: {nombre}");
        }

        public bool ExistePorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe especificar un nombre válido.");
            return accesorioDAO.ExistePorNombre(nombre);
        }
    }
}
