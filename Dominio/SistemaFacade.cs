using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SistemaFacade
    {
        private static SistemaFacade instancia;   // Singleton
        private SustanciaService sustanciaService;
        private AccesorioService accesorioService;


        // 🔒 Constructor privado (evita que se pueda instanciar fuera)
        private SistemaFacade()
        {
            sustanciaService = new SustanciaService();
            accesorioService = new AccesorioService();
        }

        // Acceso único a la instancia
        public static SistemaFacade Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new SistemaFacade();
                return instancia;
            }
        }

        // Metodos Sustancia
        public void AgregarSustancia(Sustancia s)
        {
            sustanciaService.AgregarSustancia(s);
        }

        public List<Sustancia> ObtenerSustancias()
        {
            return sustanciaService.ObtenerTodas();
        }

        public Sustancia ObtenerSustanciaPorId(int id)
        {
            return sustanciaService.ObtenerPorId(id);
        }

        public void ActualizarSustancia(Sustancia s)
        {
            sustanciaService.Actualizar(s);
        }

        public void EliminarSustancia(int id)
        {
            sustanciaService.Eliminar(id);
        }

        public List<Sustancia> ObtenerCriticas()
        {
            return sustanciaService.ObtenerCriticas();
        }

        public bool EsCompatible(int id1, int id2)
        {
            return sustanciaService.EsCompatible(id1, id2);
        }

        // -----------------------------
        // Accesorios
        // -----------------------------
        public void AgregarAccesorio(Accesorio a) => accesorioService.AgregarAccesorio(a);
        public List<Accesorio> ObtenerAccesorios() => accesorioService.ObtenerTodos();
        public Accesorio ObtenerAccesorioPorNombre(string nombre) => accesorioService.ObtenerPorNombre(nombre);
        public void ActualizarAccesorio(Accesorio a) => accesorioService.ActualizarAccesorio(a);
        public void EliminarAccesorio(string nombre) => accesorioService.EliminarAccesorio(nombre);

        public List<Accesorio> BuscarAccesoriosPorNombre(string nombre) => accesorioService.BuscarPorNombre(nombre);
    }

}
