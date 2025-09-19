using Entidades;
using MySql.Data.MySqlClient;
using Persistencia.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class AccesorioDAO
    {
        private Conexion conexion;

        public AccesorioDAO()
        {
            conexion = new Conexion();
        }

        // 🔎 Insertar un nuevo accesorio
        public void Insertar(Accesorio a)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"INSERT INTO Accesorio 
                               (nombre, descripcion, stockActual, ubicacion) 
                               VALUES (@nombre, @descripcion, @stockActual, @ubicacion)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());

                cmd.Parameters.AddWithValue("@nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@stockActual", a.StockActual);
                cmd.Parameters.AddWithValue("@ubicacion", a.Ubicacion);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar accesorio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // 🔎 Obtener todos los accesorios
        public List<Accesorio> ObtenerTodos()
        {
            var lista = new List<Accesorio>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT nombre, descripcion, stockActual, ubicacion FROM Accesorio";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(Mapear(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener accesorios: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        // 🔎 Obtener accesorio por nombre (puedes cambiar a ID si lo agregás en DB)
        public Accesorio ObtenerPorNombre(string nombre)
        {
            Accesorio accesorio = null;
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT nombre, descripcion, stockActual, ubicacion FROM Accesorio WHERE nombre = @nombre";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        accesorio = Mapear(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener accesorio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return accesorio;
        }

        public List<Accesorio> BuscarPorNombre(string filtro)
        {
            var lista = new List<Accesorio>();
            try
            {
                conexion.AbrirConexion();
                string sql = @"SELECT idAccesorio, nombre, descripcion, stockActual, ubicacion
                       FROM Accesorio
                       WHERE nombre LIKE @filtro";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%"); // contiene

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(Mapear(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar accesorios: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }


        // 🔎 Actualizar accesorio
        public void Actualizar(Accesorio a)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"UPDATE Accesorio SET 
                                  descripcion = @descripcion,
                                  stockActual = @stockActual,
                                  ubicacion = @ubicacion
                               WHERE nombre = @nombre";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());

                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@stockActual", a.StockActual);
                cmd.Parameters.AddWithValue("@ubicacion", a.Ubicacion);
                cmd.Parameters.AddWithValue("@nombre", a.Nombre);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar accesorio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // 🔎 Eliminar accesorio
        public void Eliminar(string nombre)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "DELETE FROM Accesorio WHERE nombre = @nombre";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar accesorio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // 🔧 Mapear accesorio desde reader
        private Accesorio Mapear(MySqlDataReader reader)
        {
            return new Accesorio
            {
                Nombre = reader.GetString("nombre"),
                Descripcion = reader.GetString("descripcion"),
                StockActual = reader.GetInt32("stockActual"),
                Ubicacion = reader.GetString("ubicacion")
            };
        }
    }
}

