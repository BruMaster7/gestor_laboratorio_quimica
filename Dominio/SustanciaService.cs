using Entidades;
using System;
using System.Collections.Generic;
using Persistencia;

namespace Dominio
{
    public class SustanciaService
    {
        private SustanciaDAO dao;
        private AlertaService alerta = new AlertaService();
        private HistorialDAO historialDAO = new HistorialDAO();

        // Usuario actual (por ejemplo, se asigna desde frmPrincipal al crear el servicio)
        private readonly string usuarioActual;

        public SustanciaService(string usuario)
        {
            dao = new SustanciaDAO();
            usuarioActual = usuario;
        }

        public void AgregarSustancia(Sustancia s, List<int> idsIncompatibles)
        {
            if (string.IsNullOrWhiteSpace(s.Nombre))
                throw new ArgumentException("El nombre de la sustancia es obligatorio.");

            if (s.StockActual < 0)
                throw new ArgumentException("El stock actual no puede ser negativo.");

            if (s.FechaVencimiento <= s.FechaIngreso)
                throw new ArgumentException("La fecha de vencimiento debe ser posterior a la de ingreso.");

            // Insertar sustancia
            dao.Insertar(s);

            // Insertar incompatibilidades
            if (idsIncompatibles != null && idsIncompatibles.Count > 0)
                dao.InsertarIncompatibilidades(s.IdSustancia, idsIncompatibles);

            GenerarAlertasPorIncompatibilidad();
            alerta.GenerarYGuardarAlertas();

            // Registrar en historial
            historialDAO.RegistrarMovimiento(usuarioActual, $"Agregó la sustancia '{s.Nombre}' con stock {s.StockActual}.");
        }


        public List<Sustancia> ObtenerTodas()
        {
            return dao.ObtenerTodas();
        }

        public Sustancia ObtenerPorId(int id)
        {
            return dao.ObtenerPorId(id);
        }

        public void Actualizar(Sustancia s, List<int> idsIncompatibles)
        {
            var existente = dao.ObtenerPorId(s.IdSustancia);
            if (existente == null)
                throw new ArgumentException("La sustancia no existe.");

            dao.Actualizar(s);

            // Actualizar incompatibilidades
            if (idsIncompatibles != null)
                dao.ActualizarIncompatibilidades(s.IdSustancia, idsIncompatibles);
                GenerarAlertasPorIncompatibilidad();

            var alertaDao = new AlertaDAO();

            bool estabaCritico = existente.StockActual <= existente.StockMinimo;
            bool ahoraNoCritico = s.StockActual > s.StockMinimo;
            if (estabaCritico && ahoraNoCritico)
            {
                alertaDao.DesactivarAlertasPorSustanciaYTipo(s.IdSustancia, "Sustancia con stock crítico");
            }

            bool estabaVencida = existente.FechaVencimiento < DateTime.Now;
            bool ahoraNoVencida = s.FechaVencimiento >= DateTime.Now;
            if (estabaVencida && ahoraNoVencida)
            {
                alertaDao.DesactivarAlertasPorSustanciaYTipo(s.IdSustancia, "Sustancia vencida");
            }

            alerta.GenerarYGuardarAlertas();

            historialDAO.RegistrarMovimiento(usuarioActual, $"Actualizó la sustancia '{s.Nombre}'.");
        }


        public void Eliminar(int id)
        {
            var sustancia = dao.ObtenerPorId(id);
            if (sustancia == null)
                throw new ArgumentException("La sustancia no existe.");

            dao.Eliminar(id);

            var alertaDao = new AlertaDAO();
            alertaDao.EliminarPorSustancia(id);

            alerta.GenerarYGuardarAlertas();

            // Registrar en historial
            historialDAO.RegistrarMovimiento(usuarioActual, $"Eliminó la sustancia '{sustancia.Nombre}'.");
        }

        public List<Sustancia> ObtenerCriticas()
        {
            return dao.ObtenerCriticas();
        }

        public bool EsCompatible(int id1, int id2)
        {
            return dao.EsCompatible(id1, id2);
        }

        public List<Sustancia> Buscar(string nombre, string categoria, string ubicacion)
        {
            return dao.Buscar(nombre, categoria, ubicacion);
        }

        public List<string> ObtenerCategorias()
        {
            return dao.ObtenerCategorias();
        }

        public List<string> ObtenerUbicaciones()
        {
            return dao.ObtenerUbicaciones();
        }

        public void AgregarIncompatibilidades(int idSustancia, List<int> idsIncompatibles)
        {
            dao.InsertarIncompatibilidades(idSustancia, idsIncompatibles);
        }

        public void ActualizarIncompatibilidades(int idSustancia, List<int> idsIncompatibles)
        {
            dao.ActualizarIncompatibilidades(idSustancia, idsIncompatibles);
        }

        public void GenerarAlertasPorIncompatibilidad()
        {
            var alertaDao = new AlertaDAO();
            var sustancias = dao.ObtenerTodas(); // Lista de todas las sustancias
            var incompatibilidades = dao.ObtenerTodasIncompatibilidades();
            // Debe devolver List<(int idSustancia, int idIncompatibilidad)>

            // Recorrer cada sustancia
            foreach (var s1 in sustancias)
            {
                foreach (var s2 in sustancias)
                {
                    if (s1.IdSustancia >= s2.IdSustancia)
                        continue; // Evitar duplicados y auto-comparación

                    // Si s1 y s2 son incompatibles
                    bool sonIncompatibles = incompatibilidades.Any(x =>
                        (x.idSustancia == s1.IdSustancia && x.idIncompatibilidad == s2.IdSustancia) ||
                        (x.idSustancia == s2.IdSustancia && x.idIncompatibilidad == s1.IdSustancia));

                    if (!sonIncompatibles)
                        continue;

                    // Si están en la misma ubicación
                    if (s1.Ubicacion == s2.Ubicacion)
                    {
                        // Crear alerta
                        Alerta alerta = new Alerta
                        {
                            Tipo = "Incompatibilidad de sustancias",
                            Descripcion = $"Las sustancias '{s1.Nombre}' y '{s2.Nombre}' son incompatibles y están en la misma ubicación '{s1.Ubicacion}'",
                            FechaHora = DateTime.Now,
                            Activo = true
                        };

                        // Insertar alerta vinculada a las dos sustancias (opcional: vincular solo a la primera)
                        alertaDao.Insertar(alerta, s1.IdSustancia);
                    }
                }
            }
        }

    }
}
