using Entidades;
using MySql.Data.MySqlClient;
using Persistencia.Persistencia;
using System;
using System.Collections.Generic;

namespace Persistencia
{
    public class SolicitudPracticaDAO
    {
        private Conexion conexion;

        public SolicitudPracticaDAO()
        {
            conexion = new Conexion();
        }

        public int Insertar(SolicitudPractica s)
        {
            conexion.AbrirConexion();
            try
            {
                // Intento inicial con idUsuario = 1 (valor fijo)
                string sql = @"INSERT INTO SolicitudPractica (idPractica, fechaEnvio, estado, idUsuario)
                               VALUES (@idPractica, @fechaEnvio, @estado, @idUsuario);
                               SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@idPractica", s.IdPractica);
                cmd.Parameters.AddWithValue("@fechaEnvio", s.FechaEnvio);
                cmd.Parameters.AddWithValue("@estado", s.Estado);
                cmd.Parameters.AddWithValue("@idUsuario", 1);

                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (MySqlException mex)
            {
                // Si falla por FK (no existe idUsuario = 1), buscar/crear un usuario válido y reintentar
                if (mex.Number == 1452 || mex.Message.Contains("foreign key", StringComparison.OrdinalIgnoreCase) || mex.Message.Contains("idUsuario", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        // 1) Intentar obtener cualquier idUsuario existente
                        string sqlFind = "SELECT idUsuario FROM usuario LIMIT 1";
                        MySqlCommand cmdFind = new MySqlCommand(sqlFind, conexion.ObtenerConexion());
                        var obj = cmdFind.ExecuteScalar();
                        int idUsuarioValido = 0;

                        if (obj != null && int.TryParse(obj.ToString(), out idUsuarioValido) && idUsuarioValido > 0)
                        {
                            // se obtuvo un idUsuario válido
                        }
                        else
                        {
                            // 2) No existe usuario: crear uno automático
                            string sqlCreateUser = @"INSERT INTO usuario (nombre, contrasena, idRol)
                                                     VALUES (@nombre, @contrasena, @idRol);
                                                     SELECT LAST_INSERT_ID();";
                            MySqlCommand cmdCreate = new MySqlCommand(sqlCreateUser, conexion.ObtenerConexion());
                            string autoName = "auto_solicitud_user";
                            string autoPass = Guid.NewGuid().ToString("N").Substring(0, 8);
                            cmdCreate.Parameters.AddWithValue("@nombre", autoName);
                            cmdCreate.Parameters.AddWithValue("@contrasena", autoPass);
                            cmdCreate.Parameters.AddWithValue("@idRol", 2);
                            var resUser = cmdCreate.ExecuteScalar();
                            idUsuarioValido = Convert.ToInt32(resUser);
                        }

                        // Reintentar insertar la solicitud con idUsuario válido
                        string sql2 = @"INSERT INTO SolicitudPractica (idPractica, fechaEnvio, estado, idUsuario)
                                       VALUES (@idPractica, @fechaEnvio, @estado, @idUsuario);
                                       SELECT LAST_INSERT_ID();";
                        MySqlCommand cmd2 = new MySqlCommand(sql2, conexion.ObtenerConexion());
                        cmd2.Parameters.AddWithValue("@idPractica", s.IdPractica);
                        cmd2.Parameters.AddWithValue("@fechaEnvio", s.FechaEnvio);
                        cmd2.Parameters.AddWithValue("@estado", s.Estado);
                        cmd2.Parameters.AddWithValue("@idUsuario", idUsuarioValido);

                        var result2 = cmd2.ExecuteScalar();
                        return Convert.ToInt32(result2);
                    }
                    catch
                    {
                        // Si vuelve a fallar, propagar la excepción original para diagnóstico
                        throw;
                    }
                }

                // Otro error MySQL: propagar
                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<SolicitudPractica> ObtenerTodas()
        {
            var lista = new List<SolicitudPractica>();
            try
            {
                conexion.AbrirConexion();
                // Unir con Practica para mostrar datos relevantes en UI (incluye ahora p.detalles)
                string sql = @"
                    SELECT sp.idSolicitud, sp.idPractica, sp.fechaEnvio, sp.estado,
                           p.fecha AS fechaPractica, p.objetivo, p.docente, p.cantidadEstudiantes, p.detalles
                    FROM SolicitudPractica sp
                    JOIN Practica p ON p.idPractica = sp.idPractica
                    ORDER BY sp.fechaEnvio DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new SolicitudPractica
                        {
                            IdSolicitud = reader.GetInt32("idSolicitud"),
                            IdPractica = reader.GetInt32("idPractica"),
                            FechaEnvio = reader.GetDateTime("fechaEnvio"),
                            Estado = reader.GetString("estado"),
                            FechaPractica = reader.IsDBNull(reader.GetOrdinal("fechaPractica")) ? DateTime.MinValue : reader.GetDateTime("fechaPractica"),
                            NombrePractica = reader.IsDBNull(reader.GetOrdinal("objetivo")) ? "" : reader.GetString("objetivo"),
                            Docente = reader.IsDBNull(reader.GetOrdinal("docente")) ? "" : reader.GetString("docente"),
                            Grupo = reader.IsDBNull(reader.GetOrdinal("cantidadEstudiantes")) ? "" : reader.GetInt32("cantidadEstudiantes").ToString(),
                            Detalles = reader.IsDBNull(reader.GetOrdinal("detalles")) ? "" : reader.GetString("detalles")
                        });
                    }
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        public SolicitudPractica ObtenerPorId(int idSolicitud)
        {
            SolicitudPractica s = null;
            try
            {
                conexion.AbrirConexion();
                string sql = @"
                    SELECT sp.idSolicitud, sp.idPractica, sp.fechaEnvio, sp.estado,
                           p.fecha AS fechaPractica, p.objetivo, p.docente, p.cantidadEstudiantes
                    FROM SolicitudPractica sp
                    JOIN Practica p ON p.idPractica = sp.idPractica
                    WHERE sp.idSolicitud = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", idSolicitud);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        s = new SolicitudPractica
                        {
                            IdSolicitud = reader.GetInt32("idSolicitud"),
                            IdPractica = reader.GetInt32("idPractica"),
                            FechaEnvio = reader.GetDateTime("fechaEnvio"),
                            Estado = reader.GetString("estado"),
                            FechaPractica = reader.IsDBNull(reader.GetOrdinal("fechaPractica")) ? DateTime.MinValue : reader.GetDateTime("fechaPractica"),
                            NombrePractica = reader.IsDBNull(reader.GetOrdinal("objetivo")) ? "" : reader.GetString("objetivo"),
                            Docente = reader.IsDBNull(reader.GetOrdinal("docente")) ? "" : reader.GetString("docente"),
                            Grupo = reader.IsDBNull(reader.GetOrdinal("cantidadEstudiantes")) ? "" : reader.GetInt32("cantidadEstudiantes").ToString(),
                            Detalles = reader.IsDBNull(reader.GetOrdinal("detalles")) ? "" : reader.GetString("detalles")
                        };
                    }
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return s;
        }

        public void ActualizarEstado(int idSolicitud, string nuevoEstado)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "UPDATE SolicitudPractica SET estado = @estado WHERE idSolicitud = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idSolicitud);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void EliminarPorIdSolicitud(int idSolicitud)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "DELETE FROM SolicitudPractica WHERE idSolicitud = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", idSolicitud);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void EliminarPorPracticaId(int idPractica)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "DELETE FROM SolicitudPractica WHERE idPractica = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", idPractica);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}