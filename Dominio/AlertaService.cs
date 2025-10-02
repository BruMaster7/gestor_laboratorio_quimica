using System;
using System.Collections.Generic;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class AlertaService
    {
        private readonly AlertaDAO alertaDAO;

        public AlertaService()
        {
            alertaDAO = new AlertaDAO();
        }

        /// Genera y retorna todas las alertas actuales del sistema.
        public List<Alerta> ObtenerAlertasActuales()
        {
            return alertaDAO.ObtenerAlertasActivas();
        }

        public void GenerarYGuardarAlertas()
        {
            var alertaDAO = new AlertaDAO();
            var alertas = alertaDAO.GenerarAlertas();
            foreach (var alerta in alertas)
            {
                // Evitar duplicados: solo insertar si no existe una alerta activa igual
                if (!ExisteAlertaActiva(alerta))
                    alertaDAO.Insertar(alerta, alerta.IdSustancia);
            }
        }

        private bool ExisteAlertaActiva(Alerta alerta)
        {
            var alertaDAO = new AlertaDAO();
            var activas = alertaDAO.ObtenerAlertasActivas();
            return activas.Any(a => a.Tipo == alerta.Tipo && a.Descripcion == alerta.Descripcion && a.IdSustancia == alerta.IdSustancia);
        }
    }
}
