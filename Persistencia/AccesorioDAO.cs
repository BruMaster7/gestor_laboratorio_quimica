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

        public Accesorio ObtenerAccesorioPorId(int id)
        {
            Accesorio accesorio = null;
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idAccesorio, nombre, descripcion, stockActual, ubicacion, categoria FROM Accesorio WHERE idAccesorio = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        accesorio = Mapear(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener accesorio por ID: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return accesorio;
        }

        // 🔎 Insertar un nuevo accesorio (incluye categoria)
        public void Insertar(Accesorio a)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"INSERT INTO Accesorio 
                               (nombre, descripcion, stockActual, ubicacion, categoria) 
                               VALUES (@nombre, @descripcion, @stockActual, @ubicacion, @categoria)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());

                cmd.Parameters.AddWithValue("@nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrWhiteSpace(a.Descripcion) ? (object)DBNull.Value : a.Descripcion);
                cmd.Parameters.AddWithValue("@stockActual", a.StockActual);
                cmd.Parameters.AddWithValue("@ubicacion", string.IsNullOrWhiteSpace(a.Ubicacion) ? (object)DBNull.Value : a.Ubicacion);
                cmd.Parameters.AddWithValue("@categoria", string.IsNullOrWhiteSpace(a.Categoria) ? (object)DBNull.Value : a.Categoria);

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

        // 🔎 Obtener todos los accesorios (incluye categoria)
        public List<Accesorio> ObtenerTodos()
        {
            var lista = new List<Accesorio>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idAccesorio, nombre, descripcion, stockActual, ubicacion, categoria FROM Accesorio";
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

        // 🔎 Obtener accesorio por nombre (incluye categoria)
        public Accesorio ObtenerPorNombre(string nombre)
        {
            Accesorio accesorio = null;
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idAccesorio, nombre, descripcion, stockActual, ubicacion, categoria FROM Accesorio WHERE nombre = @nombre";
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
                string sql = @"SELECT idAccesorio, nombre, descripcion, stockActual, ubicacion, categoria
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

        public List<Accesorio> ObtenerAccesoriosSinStock()
        {
            var lista = new List<Accesorio>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idAccesorio, nombre, descripcion, stockActual, ubicacion, categoria FROM Accesorio WHERE stockActual <= 0";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(Mapear(reader));
                    }
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        // 🔎 Actualizar accesorio (incluye categoria)
        public void Actualizar(Accesorio a)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"UPDATE Accesorio SET 
                          nombre = @nombre,
                          descripcion = @descripcion,
                          stockActual = @stockActual,
                          ubicacion = @ubicacion,
                          categoria = @categoria
                       WHERE idAccesorio = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrWhiteSpace(a.Descripcion) ? (object)DBNull.Value : a.Descripcion);
                cmd.Parameters.AddWithValue("@stockActual", a.StockActual);
                cmd.Parameters.AddWithValue("@ubicacion", string.IsNullOrWhiteSpace(a.Ubicacion) ? (object)DBNull.Value : a.Ubicacion);
                cmd.Parameters.AddWithValue("@categoria", string.IsNullOrWhiteSpace(a.Categoria) ? (object)DBNull.Value : a.Categoria);
                cmd.Parameters.AddWithValue("@id", a.IdAccesorio);

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

        public bool ExistePorNombre(string nombre)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT COUNT(*) FROM Accesorio WHERE nombre = @nombre";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar accesorio: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        // 🔧 Mapear accesorio desde reader (maneja nulos)
        private Accesorio Mapear(MySqlDataReader reader)
        {
            return new Accesorio
            {
                IdAccesorio = reader.GetInt32("idAccesorio"),
                Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? string.Empty : reader.GetString("nombre"),
                Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? string.Empty : reader.GetString("descripcion"),
                StockActual = reader.IsDBNull(reader.GetOrdinal("stockActual")) ? 0 : reader.GetInt32("stockActual"),
                Ubicacion = reader.IsDBNull(reader.GetOrdinal("ubicacion")) ? string.Empty : reader.GetString("ubicacion"),
                Categoria = reader.IsDBNull(reader.GetOrdinal("categoria")) ? string.Empty : reader.GetString("categoria")
            };
        }
    }
}
