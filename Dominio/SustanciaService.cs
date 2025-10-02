using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            dao.Actualizar(s);
            alerta.GenerarYGuardarAlertas();
        }

        public void Eliminar(int id)
        {
            dao.Eliminar(id);
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
