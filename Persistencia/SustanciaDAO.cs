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
                string sql = "DELETE FROM Sustancia WHERE idSustancia = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
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

        // 🔧 Mapear sustancia desde reader
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
    }
}
