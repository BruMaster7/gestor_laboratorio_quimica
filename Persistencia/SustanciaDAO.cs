using Entidades;
using MySql.Data.MySqlClient;
using Persistencia.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SustanciaDAO
    {
        private Conexion conexion;

        public SustanciaDAO()
        {
            conexion = new Conexion();
        }

        public Sustancia ObtenerPorId(int id)
        {
            Sustancia sustancia = null;
            try
            {
                conexion.AbrirConexion();
                string sql = @"SELECT idSustancia, nombre, categoria, unidadMedida, 
                                      descripcionManipulacion, ubicacion, fechaIngreso, 
                                      fechaVencimiento, stockActual, stockMinimo, 
                                      peligrosidad, envaseRecomendado
                               FROM Sustancia WHERE idSustancia = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sustancia = Mapear(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener sustancia: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return sustancia;
        }

        public List<Sustancia> ObtenerTodas()
        {
            var lista = new List<Sustancia>();
            try
            {
                conexion.AbrirConexion();
                string sql = @"SELECT idSustancia, nombre, categoria, unidadMedida, 
                                      descripcionManipulacion, ubicacion, fechaIngreso, 
                                      fechaVencimiento, stockActual, stockMinimo, 
                                      peligrosidad, envaseRecomendado
                               FROM Sustancia";
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
                Console.WriteLine("Error al obtener sustancias: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        public void Insertar(Sustancia s)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"INSERT INTO Sustancia
                               (nombre, categoria, unidadMedida, descripcionManipulacion, 
                                ubicacion, fechaIngreso, fechaVencimiento, stockActual, 
                                stockMinimo, peligrosidad, envaseRecomendado)
                               VALUES
                               (@nombre, @categoria, @unidadMedida, @descripcionManipulacion, 
                                @ubicacion, @fechaIngreso, @fechaVencimiento, @stockActual, 
                                @stockMinimo, @peligrosidad, @envaseRecomendado)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", s.Nombre);
                cmd.Parameters.AddWithValue("@categoria", s.Categoria);
                cmd.Parameters.AddWithValue("@unidadMedida", s.UnidadMedida);
                cmd.Parameters.AddWithValue("@descripcionManipulacion", s.DescripcionManipulacion);
                cmd.Parameters.AddWithValue("@ubicacion", s.Ubicacion);
                cmd.Parameters.AddWithValue("@fechaIngreso", s.FechaIngreso);
                cmd.Parameters.AddWithValue("@fechaVencimiento", s.FechaVencimiento);
                cmd.Parameters.AddWithValue("@stockActual", s.StockActual);
                cmd.Parameters.AddWithValue("@stockMinimo", s.StockMinimo);
                cmd.Parameters.AddWithValue("@peligrosidad", s.Peligrosidad);
                cmd.Parameters.AddWithValue("@envaseRecomendado", s.EnvaseRecomendado);

                cmd.ExecuteNonQuery();
                s.IdSustancia = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar sustancia: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Actualizar(Sustancia s)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"UPDATE Sustancia SET 
                                  nombre = @nombre,
                                  categoria = @categoria,
                                  unidadMedida = @unidadMedida,
                                  descripcionManipulacion = @descripcionManipulacion,
                                  ubicacion = @ubicacion,
                                  fechaIngreso = @fechaIngreso,
                                  fechaVencimiento = @fechaVencimiento,
                                  stockActual = @stockActual,
                                  stockMinimo = @stockMinimo,
                                  peligrosidad = @peligrosidad,
                                  envaseRecomendado = @envaseRecomendado
                               WHERE idSustancia = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", s.Nombre);
                cmd.Parameters.AddWithValue("@categoria", s.Categoria);
                cmd.Parameters.AddWithValue("@unidadMedida", s.UnidadMedida);
                cmd.Parameters.AddWithValue("@descripcionManipulacion", s.DescripcionManipulacion);
                cmd.Parameters.AddWithValue("@ubicacion", s.Ubicacion);
                cmd.Parameters.AddWithValue("@fechaIngreso", s.FechaIngreso);
                cmd.Parameters.AddWithValue("@fechaVencimiento", s.FechaVencimiento);
                cmd.Parameters.AddWithValue("@stockActual", s.StockActual);
                cmd.Parameters.AddWithValue("@stockMinimo", s.StockMinimo);
                cmd.Parameters.AddWithValue("@peligrosidad", s.Peligrosidad);
                cmd.Parameters.AddWithValue("@envaseRecomendado", s.EnvaseRecomendado);
                cmd.Parameters.AddWithValue("@id", s.IdSustancia);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar sustancia: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                conexion.AbrirConexion();

                // Borramos la sustancia. Las alertas relacionadas se borrarán automáticamente.
                string sql = "DELETE FROM Sustancia WHERE idSustancia = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        Console.WriteLine("Sustancia eliminada correctamente.");
                    else
                        Console.WriteLine("No se encontró la sustancia con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar sustancia: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        // 🔎 Métodos específicos

        public void ActualizarStock(int id, int cantidad)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "UPDATE Sustancia SET stockActual = stockActual + @cantidad WHERE idSustancia = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar stock: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Sustancia> ObtenerCriticas()
        {
            var lista = new List<Sustancia>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT * FROM Sustancia WHERE stockActual <= stockMinimo";
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
                Console.WriteLine("Error al obtener sustancias críticas: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        public bool EsCompatible(int id1, int id2)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"SELECT COUNT(*) FROM sustancia_incompatibilidad 
                               WHERE (idSustancia = @id1 AND idIncompatibilidad IN 
                                    (SELECT idIncompatibilidad FROM Sustancia_Incompatibilidad WHERE idSustancia = @id2))";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id1", id1);
                cmd.Parameters.AddWithValue("@id2", id2);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al comprobar compatibilidad: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        // Buscar Sustancia por nombre (parcial), categoria y ubicación
        public List<Sustancia> Buscar(string nombre = null, string categoria = null, string ubicacion = null)
        {
            var lista = new List<Sustancia>();
            try
            {
                conexion.AbrirConexion();
                var condiciones = new List<string>();
                if (!string.IsNullOrWhiteSpace(nombre))
                    condiciones.Add("nombre LIKE @nombre");
                if (!string.IsNullOrWhiteSpace(categoria))
                    condiciones.Add("categoria = @categoria");
                if (!string.IsNullOrWhiteSpace(ubicacion))
                    condiciones.Add("ubicacion = @ubicacion");
                string whereClause = condiciones.Count > 0 ? "WHERE " + string.Join(" AND ", condiciones) : "";
                string sql = $"SELECT * FROM Sustancia {whereClause}";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                if (!string.IsNullOrWhiteSpace(nombre))
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                if (!string.IsNullOrWhiteSpace(categoria))
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                if (!string.IsNullOrWhiteSpace(ubicacion))
                    cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
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
                Console.WriteLine("Error al buscar sustancias: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        // Traer todas las ubicaciones únicas
        public List<string> ObtenerUbicaciones()
        {
            var lista = new List<string>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT DISTINCT ubicacion FROM Sustancia";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetString("ubicacion"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener ubicaciones: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        // Traer todas las categorías únicas
        public List<string> ObtenerCategorias()
        {
            var lista = new List<string>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT DISTINCT categoria FROM Sustancia";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetString("categoria"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener categorías: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        public List<Sustancia> ObtenerVencidas()
        {
            var lista = new List<Sustancia>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT * FROM Sustancia WHERE fechaVencimiento <= CURDATE()";
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

        // Mapear sustancia desde reader
        private Sustancia Mapear(MySqlDataReader reader)
        {
            return new Sustancia
            {
                IdSustancia = reader.GetInt32("idSustancia"),
                Nombre = reader.GetString("nombre"),
                Categoria = reader.GetString("categoria"),
                UnidadMedida = reader.GetString("unidadMedida"),
                DescripcionManipulacion = reader.GetString("descripcionManipulacion"),
                Ubicacion = reader.GetString("ubicacion"),
                FechaIngreso = reader.GetDateTime("fechaIngreso"),
                FechaVencimiento = reader.GetDateTime("fechaVencimiento"),
                StockActual = reader.GetInt32("stockActual"),
                StockMinimo = reader.GetInt32("stockMinimo"),
                Peligrosidad = reader.GetString("peligrosidad"),
                EnvaseRecomendado = reader.GetString("envaseRecomendado")
            };
        }

        public void InsertarIncompatibilidades(int idSustancia, List<int> idsIncompatibles)
        {
            try
            {
                conexion.AbrirConexion();
                foreach (int idIncomp in idsIncompatibles)
                {
                    string sql = @"INSERT INTO sustancia_incompatibilidad (idSustancia, idIncompatibilidad)
                           VALUES (@idSustancia, @idIncompatibilidad)";
                    MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                    cmd.Parameters.AddWithValue("@idSustancia", idSustancia);
                    cmd.Parameters.AddWithValue("@idIncompatibilidad", idIncomp);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar incompatibilidades: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void ActualizarIncompatibilidades(int idSustancia, List<int> idsIncompatibles)
        {
            try
            {
                conexion.AbrirConexion();

                // Borrar las existentes
                string sqlDelete = @"DELETE FROM sustancia_incompatibilidad WHERE idSustancia = @idSustancia";
                MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, conexion.ObtenerConexion());
                cmdDelete.Parameters.AddWithValue("@idSustancia", idSustancia);
                cmdDelete.ExecuteNonQuery();

                // Insertar las nuevas
                foreach (int idIncomp in idsIncompatibles)
                {
                    string sqlInsert = @"INSERT INTO sustancia_incompatibilidad (idSustancia, idIncompatibilidad)
                                 VALUES (@idSustancia, @idIncompatibilidad)";
                    MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conexion.ObtenerConexion());
                    cmdInsert.Parameters.AddWithValue("@idSustancia", idSustancia);
                    cmdInsert.Parameters.AddWithValue("@idIncompatibilidad", idIncomp);
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar incompatibilidades: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<(int idSustancia, int idIncompatibilidad)> ObtenerTodasIncompatibilidades()
        {
            List<(int, int)> lista = new List<(int, int)>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idSustancia, idIncompatibilidad FROM sustancia_incompatibilidad";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add((reader.GetInt32("idSustancia"), reader.GetInt32("idIncompatibilidad")));
                }
                reader.Close();
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        public List<int> ObtenerIdsIncompatibles(int idSustancia)
        {
            List<int> lista = new List<int>();

            try
            {
                conexion.AbrirConexion();
                string sql = @"
            SELECT idIncompatibilidad AS idRelacionado
            FROM sustancia_incompatibilidad
            WHERE idSustancia = @idSustancia

            UNION

            SELECT idSustancia AS idRelacionado
            FROM sustancia_incompatibilidad
            WHERE idIncompatibilidad = @idSustancia;
        ";

                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@idSustancia", idSustancia);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetInt32("idRelacionado"));
                    }
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }



    }
}
