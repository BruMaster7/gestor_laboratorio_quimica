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

        public SustanciaService()
        {
            dao = new SustanciaDAO();
        }

        // Agregar nueva sustancia
        public void AgregarSustancia(Sustancia s)
        {
            // Validaciones de negocio antes de persistir
            if (string.IsNullOrWhiteSpace(s.Nombre))
                throw new ArgumentException("El nombre de la sustancia es obligatorio.");

            if (s.StockActual < 0)
                throw new ArgumentException("El stock actual no puede ser negativo.");

            if (s.FechaVencimiento <= s.FechaIngreso)
                throw new ArgumentException("La fecha de vencimiento debe ser posterior a la de ingreso.");

            // Pasamos al DAO para guardar en BD
            dao.Insertar(s);
        }

        // Obtener todas
        public List<Sustancia> ObtenerTodas()
        {
            return dao.ObtenerTodas();
        }

        // Obtener una por ID
        public Sustancia ObtenerPorId(int id)
        {
            return dao.ObtenerPorId(id);
        }

        // Actualizar
        public void Actualizar(Sustancia s)
        {
            dao.Actualizar(s);
        }

        // Eliminar
        public void Eliminar(int id)
        {
            dao.Eliminar(id);
        }

        // Obtener críticas
        public List<Sustancia> ObtenerCriticas()
        {
            return dao.ObtenerCriticas();
        }

        // Verificar compatibilidad
        public bool EsCompatible(int id1, int id2)
        {
            return dao.EsCompatible(id1, id2);
        }
    }

}
