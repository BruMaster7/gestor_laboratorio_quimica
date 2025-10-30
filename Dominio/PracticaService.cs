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
        private readonly HistorialDAO historialDAO;

        public PracticaService()
        {
            practicaDAO = new PracticaDAO();
            solicitudDAO = new SolicitudPracticaDAO();
            historialDAO = new HistorialDAO();
        }

        public int AgregarPractica(Practica p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            if (p.Fecha < DateTime.Now.AddHours(48))
                throw new ArgumentException("La práctica debe solicitarse con al menos 48 horas de anticipación.");

            // Validaciones de negocio: objetivo obligatorio y cantidad de estudiantes > 0
            if (string.IsNullOrWhiteSpace(p.Objetivo))
                throw new ArgumentException("La Práctica/Objetivo no puede estar vacía.");
            if (p.CantidadEstudiantes <= 0)
                throw new ArgumentException("La cantidad de estudiantes debe ser un número entero mayor que 0.");

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

            // Registrar en historial
            historialDAO.RegistrarMovimiento(
                SesionActual.NombreUsuario,
                $"Agregó la práctica '{p.Objetivo}' para el docente '{p.Docente}' programada el {p.Fecha:yyyy-MM-dd HH:mm}."
            );

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

            historialDAO.RegistrarMovimiento(
                SesionActual.NombreUsuario,
                $"Aprobó la solicitud de práctica con ID {idSolicitud}."
            );
        }

        public void RechazarSolicitud(int idSolicitud)
        {
            var s = solicitudDAO.ObtenerPorId(idSolicitud);
            if (s != null)
            {
                solicitudDAO.EliminarPorIdSolicitud(idSolicitud);
                practicaDAO.Eliminar(s.IdPractica);

                historialDAO.RegistrarMovimiento(
                    SesionActual.NombreUsuario,
                    $"Rechazó y eliminó la solicitud de práctica con ID {idSolicitud} y la práctica asociada '{s.NombrePractica}'."
                );
            }
        }

        public void EliminarPractica(int idPractica)
        {
            var practica = practicaDAO.ObtenerPorId(idPractica);
            if (practica != null)
            {
                solicitudDAO.EliminarPorPracticaId(idPractica);
                practicaDAO.Eliminar(idPractica);

                historialDAO.RegistrarMovimiento(
                    SesionActual.NombreUsuario,
                    $"Eliminó la práctica '{practica.Objetivo}' programada para el docente '{practica.Docente}' el {practica.Fecha:yyyy-MM-dd HH:mm}."
                );
            }
        }
    }
}