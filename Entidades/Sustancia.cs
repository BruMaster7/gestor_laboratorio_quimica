using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sustancia
    {
        public int IdSustancia { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string UnidadMedida { get; set; }
        public string DescripcionManipulacion { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public string Peligrosidad { get; set; }
        public string EnvaseRecomendado { get; set; }
    }
}
