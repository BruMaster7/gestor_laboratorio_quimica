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
        private AlertaService alertaService = new AlertaService();
        private usuarioService usuarioService;

        // Nuevo servicio para prácticas
        private PracticaService practicaService = new PracticaService();


        // 🔒 Constructor privado (evita que se pueda instanciar fuera)
        private SistemaFacade()
        {
            sustanciaService = new SustanciaService(SesionActual.NombreUsuario);
            accesorioService = new AccesorioService();
            usuarioService = new usuarioService();
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
        public void AgregarSustancia(Sustancia s, List<int> idsIncompatibles)
        {
            sustanciaService.AgregarSustancia(s, idsIncompatibles);
        }

        public List<Sustancia> ObtenerSustancias()
        {
            return sustanciaService.ObtenerTodas();
        }

        public Sustancia ObtenerSustanciaPorId(int id)
        {
            return sustanciaService.ObtenerPorId(id);
        }

        public void ActualizarSustancia(Sustancia s, List<int> idsIncompatibles)
        {
            sustanciaService.Actualizar(s, idsIncompatibles);
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

        public List<Sustancia> Buscar(string nombre, string categoria, string ubicacion)
        {
            return sustanciaService.Buscar(nombre, categoria, ubicacion);
        }

        public List<string> ObtenerCategorias()
        {
            return sustanciaService.ObtenerCategorias();
        }

        public List<string> ObtenerUbicaciones()
        {
            return sustanciaService.ObtenerUbicaciones();
        }

        // -----------------------------
        // Accesorios
        // -----------------------------

        public Accesorio ObtenerAccesorioPorId(int id) => accesorioService.ObtenerPorId(id);
        public void AgregarAccesorio(Accesorio a) => accesorioService.AgregarAccesorio(a);
        public List<Accesorio> ObtenerAccesorios() => accesorioService.ObtenerTodos();
        public Accesorio ObtenerAccesorioPorNombre(string nombre) => accesorioService.ObtenerPorNombre(nombre);
        public void ActualizarAccesorio(Accesorio a) => accesorioService.ActualizarAccesorio(a);
        public void EliminarAccesorio(string nombre) => accesorioService.EliminarAccesorio(nombre);

        public List<Accesorio> BuscarAccesoriosPorNombre(string nombre) => accesorioService.BuscarPorNombre(nombre);
        public bool ExisteAccesorioPorNombre(string nombre) => accesorioService.ExistePorNombre(nombre);

        // -----------------------------
        // PRACTICAS / SOLICITUDES
        // -----------------------------
        public int AgregarPractica(Practica p) => practicaService.AgregarPractica(p);
        public List<Practica> ObtenerPracticas() => practicaService.ObtenerPracticas();
        public List<SolicitudPractica> ObtenerSolicitudesPractica() => practicaService.ObtenerSolicitudes();
        public SolicitudPractica ObtenerSolicitudPorId(int id) => practicaService.ObtenerSolicitudPorId(id);
        public void AprobarSolicitud(int idSolicitud) => practicaService.AprobarSolicitud(idSolicitud);
        public void RechazarSolicitud(int idSolicitud) => practicaService.RechazarSolicitud(idSolicitud);
        public void EliminarPractica(int idPractica) => practicaService.EliminarPractica(idPractica);

        // -----------------------------
        // ALERTAS
        // -----------------------------

        public List<Alerta> ObtenerAlertas() => alertaService.ObtenerAlertasActuales();

        //Usuarios
        public void AgregarUsuario(Usuario nuevo)
        {
            usuarioService.AgregarUsuario(nuevo);

        }

        public void EliminarUsuario(string nombreUsuario)
        {
            usuarioService.EliminarUsuario(nombreUsuario);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioService.ObtenerUsuarios();
        }

        public bool Login(string usuarioValido, string claveValida)
        {
            return usuarioService.Login(usuarioValido, claveValida);
        }

        public bool UsuarioLogeadoEsAdmin(string usuario)
        {
            return usuarioService.EsAdmin(usuario);
        }

        public bool UsuarioLogeadoEsAdmin(string v, object usuarioValido)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            return usuarioService.ObtenerUsuarioPorNombre(nombreUsuario);
        }
    }

}
