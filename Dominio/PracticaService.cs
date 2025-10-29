using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class PracticaService
    {
        private readonly PracticaDAO practicaDAO;
        private readonly SolicitudPracticaDAO solicitudDAO;

        public PracticaService()
        {
            practicaDAO = new PracticaDAO();
            solicitudDAO = new SolicitudPracticaDAO();
        }

        public int AgregarPractica(Practica p)
        {
            // Validaciones mínimas
            if (p == null) throw new ArgumentNullException(nameof(p));
            // La validación de 48 horas la realiza la capa UI antes, pero reafirmamos aquí por seguridad:
            if (p.Fecha < DateTime.Now.AddHours(48))
                throw new ArgumentException("La práctica debe solicitarse con al menos 48 horas de anticipación.");

            int id = practicaDAO.Insertar(p);

            // Generar solicitud
            var solicitud = new SolicitudPractica
            {
                IdPractica = id,
                FechaEnvio = DateTime.Now,
                Estado = "Pendiente",
                FechaPractica = p.Fecha,
                Docente = p.Docente,
                NombrePractica = p.Objetivo,
                Grupo = p.CantidadEstudiantes.ToString()
            };
            solicitudDAO.Insertar(solicitud);

            return id;
        }

        public List<Practica> ObtenerPracticas()
        {
            return practicaDAO.ObtenerTodas();
        }

        public List<SolicitudPractica> ObtenerSolicitudes()
        {
            return solicitudDAO.ObtenerTodas();
        }

        public SolicitudPractica ObtenerSolicitudPorId(int idSolicitud)
        {
            return solicitudDAO.ObtenerPorId(idSolicitud);
        }

        public void AprobarSolicitud(int idSolicitud)
        {
            solicitudDAO.ActualizarEstado(idSolicitud, "Aprobada");
        }

        public void RechazarSolicitud(int idSolicitud)
        {
            var s = solicitudDAO.ObtenerPorId(idSolicitud);
            if (s != null)
            {
                // Eliminar solicitud y la práctica asociada
                solicitudDAO.EliminarPorIdSolicitud(idSolicitud);
                practicaDAO.Eliminar(s.IdPractica);
            }
        }

        public void EliminarPractica(int idPractica)
        {
            solicitudDAO.EliminarPorPracticaId(idPractica);
            practicaDAO.Eliminar(idPractica);
        }
    }
}