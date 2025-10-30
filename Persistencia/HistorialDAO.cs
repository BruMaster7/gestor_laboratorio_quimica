using Entidades;
using MySql.Data.MySqlClient;
using Persistencia;
using Persistencia.Persistencia;
using System;
using System.Collections.Generic;
using System.Diagnostics;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Entidades;
using MySql.Data.MySqlClient;
using Persistencia;
using System.Diagnostics;


    namespace Persistencia
    {
        public class HistorialDAO
        {
            private readonly Conexion conexion;

            public HistorialDAO()
            {
                conexion = new Conexion();
            }

            public void RegistrarMovimiento(string usuario, string movimiento)
            {
                try
                {
                    conexion.AbrirConexion();

                    int? idUsuario = null;

                    // Buscar el idUsuario en base al nombre
                    if (!string.IsNullOrWhiteSpace(usuario))
                    {
                        string sqlFind = "SELECT idUsuario FROM usuario WHERE nombre = @nombre LIMIT 1";
                        using var cmdFind = new MySqlCommand(sqlFind, conexion.ObtenerConexion());
                        cmdFind.Parameters.AddWithValue("@nombre", usuario);
                        var res = cmdFind.ExecuteScalar();
                        if (res != null && int.TryParse(res.ToString(), out int idf))
                            idUsuario = idf;
                    }

                    // Insertar el historial
                    string sql = @"INSERT INTO Historial (id_usuario, movimiento) 
                               VALUES (@id_usuario, @movimiento)";
                    using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario.HasValue ? idUsuario.Value : 2);
                    cmd.Parameters.AddWithValue("@movimiento", movimiento ?? string.Empty);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Muestra el código y el mensaje exacto del error de MySQL
                    Debug.WriteLine($"[MySQL Error] Nº{ex.Number} - {ex.Message}");
                    throw new Exception($"Error de MySQL al guardar historial: {ex.Number} - {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[General Error] {ex}");
                    throw new Exception("Error general al guardar historial en la base de datos.", ex);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

        ///
        /// Devuelve todos los registros del historial
        ///

        public List<Historial> ObtenerTodas()
        {
            var lista = new List<Historial>();

            try
            {
                conexion.AbrirConexion();
                string sql = @"
        SELECT h.id AS idHistorial, h.id_usuario, h.movimiento, 
               u.nombre AS usuario, h.Fecha
        FROM Historial h
        LEFT JOIN usuario u ON u.idUsuario = h.id_usuario
        ORDER BY h.id DESC";

                using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Historial
                    {
                        IdHistorial = reader.GetInt32("idHistorial"),
                        Usuario = reader.IsDBNull(reader.GetOrdinal("usuario")) ? "" : reader.GetString("usuario"),
                        Movimiento = reader.IsDBNull(reader.GetOrdinal("movimiento")) ? "" : reader.GetString("movimiento"),
                        FechaHora = reader.IsDBNull(reader.GetOrdinal("Fecha"))
                            ? DateTime.Now
                            : reader.GetDateTime("Fecha")
                    });
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine($"[MySQL Error] Nº{ex.Number} - {ex.Message}");
                throw new Exception($"Error de MySQL al obtener historial: {ex.Number} - {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[General Error] {ex}");
                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }


    }
}

