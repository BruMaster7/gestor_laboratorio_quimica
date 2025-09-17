using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sustancia
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string UnidadMedida { get; set; }
        public string DescripcionManipulacion { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public bool EsPeligroso { get; set; }
        public string EnvaseRecomendado { get; set; }

        //public void ActualizarStock(int cantidad) { /* Lógica de actualización */ }
        //public bool EsCritica() { /* Lógica de verificación */ }
        //public bool EsCompatibleCon(Sustancia sustancia) { /* Lógica de compatibilidad */ }
        //public void GenerarAlerta() { /* Lógica de generación de alerta */ }
    }
}
