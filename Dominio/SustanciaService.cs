using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Dominio
{
    public class SustanciaService
    {
        private SustanciaDAO dao;
        private AlertaService alerta = new AlertaService();

        public SustanciaService()
        {
            dao = new SustanciaDAO();
        }

        public void AgregarSustancia(Sustancia s)
        {
            if (string.IsNullOrWhiteSpace(s.Nombre))
                throw new ArgumentException("El nombre de la sustancia es obligatorio.");

            if (s.StockActual < 0)
                throw new ArgumentException("El stock actual no puede ser negativo.");

            if (s.FechaVencimiento <= s.FechaIngreso)
                throw new ArgumentException("La fecha de vencimiento debe ser posterior a la de ingreso.");

            dao.Insertar(s);
            alerta.GenerarYGuardarAlertas();
        }

        public List<Sustancia> ObtenerTodas()
        {
            return dao.ObtenerTodas();
        }

        public Sustancia ObtenerPorId(int id)
        {
            return dao.ObtenerPorId(id);
        }

        public void Actualizar(Sustancia s)
        {
            // Obtener estado previo para comparar cambios relevantes a alertas
            var existente = dao.ObtenerPorId(s.IdSustancia);
            if (existente == null)
                throw new ArgumentException("La sustancia no existe.");

            // Actualizar en la BD
            dao.Actualizar(s);

            var alertaDao = new AlertaDAO();

            // Si antes estaba en stock crítico y ahora el stock superó el mínimo, desactivar alerta de stock crítico
            bool estabaCritico = existente.StockActual <= existente.StockMinimo;
            bool ahoraNoCritico = s.StockActual > s.StockMinimo;
            if (estabaCritico && ahoraNoCritico)
            {
                alertaDao.DesactivarAlertasPorSustanciaYTipo(s.IdSustancia, "Sustancia con stock crítico");
            }

            // Si antes estaba vencida y ahora ya no está vencida, desactivar alerta de vencimiento
            bool estabaVencida = existente.FechaVencimiento < DateTime.Now;
            bool ahoraNoVencida = s.FechaVencimiento >= DateTime.Now;
            if (estabaVencida && ahoraNoVencida)
            {
                alertaDao.DesactivarAlertasPorSustanciaYTipo(s.IdSustancia, "Sustancia vencida");
            }

            // Regenerar alertas globales (insertará nuevas donde corresponda y evita duplicados)
            alerta.GenerarYGuardarAlertas();
        }

        public void Eliminar(int id)
        {
            dao.Eliminar(id);

            // Eliminar/desactivar alertas asociadas a la sustancia
            var alertaDao = new AlertaDAO();
            alertaDao.EliminarPorSustancia(id);

            // Regenerar alertas globales por si cambió el contexto
            alerta.GenerarYGuardarAlertas();
        }

        public List<Sustancia> ObtenerCriticas()
        {
            return dao.ObtenerCriticas();
        }

        public bool EsCompatible(int id1, int id2)
        {
            return dao.EsCompatible(id1, id2);
        }

        public List<Sustancia> Buscar(string nombre,string categoria, string ubicacion)
        {
            return dao.Buscar(nombre, categoria, ubicacion);
        }

        public List<string> ObtenerCategorias()
        {
            return dao.ObtenerCategorias();
        }

        public List<string> ObtenerUbicaciones ()
        {
            return dao.ObtenerUbicaciones();
        }

    }

}
