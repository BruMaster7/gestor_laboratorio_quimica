using Entidades;
using MySql.Data.MySqlClient;
using Persistencia.Persistencia;
using System;

namespace Dominio
{
    public class UsuarioDAO
    {
        private Conexion conexion;

        public UsuarioDAO()
        {
            conexion = new Conexion();
        }

        public void AgregarUsuario(Usuario nuevo)
        {
            if (nuevo == null) throw new ArgumentNullException(nameof(nuevo));

            // Normalizar nombre y validar
            nuevo.nombre = nuevo.nombre?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(nuevo.nombre))
            {
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            }

            try
            {
                conexion.AbrirConexion();

                // Verificar existencia de usuario (insensible a mayúsculas)
                string checkSql = "SELECT COUNT(*) FROM usuario WHERE LOWER(nombre) = LOWER(@nombre)";
                using var checkCmd = new MySqlCommand(checkSql, conexion.ObtenerConexion());
                checkCmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                int existe = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (existe > 0)
                {
                    throw new InvalidOperationException("Ya existe un usuario con ese nombre.");
                }

                string sql = "INSERT INTO usuario (nombre, contrasena, idRol) VALUES (@nombre, @contrasena, @idRol)";
                using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                cmd.Parameters.AddWithValue("@contrasena", nuevo.contrasena);
                cmd.Parameters.AddWithValue("@idRol", nuevo.idRol);

                cmd.ExecuteNonQuery();
                nuevo.idUsuario = (int)cmd.LastInsertedId;
                //informar exito
            }
            catch (MySqlException ex)
            {
                // Propagar la excepción con detalle, para que la UI lo maneje
                throw new Exception($"Error MySQL al agregar usuario (Código {ex.Number}): {ex.Message}", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            // Evitar eliminación del usuario "Admin" (insensible a mayúsculas)
            if (string.Equals(nombreUsuario, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("No se puede eliminar el usuario 'Admin'.");
            }

            try
            {
                conexion.AbrirConexion();

                string sql = "DELETE FROM usuario WHERE nombre = @nombre";
                using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombreUsuario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    throw new Exception("No se encontró ningún usuario con el nombre proporcionado.");
                }
            }
            catch (MySqlException ex)
            {
                // Propagar excepción con detalle de MySQL
                throw new Exception($"Error MySQL al eliminar usuario (Código {ex.Number}): {ex.Message}", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idUsuario, nombre, contrasena, idRol FROM usuario";
                using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        idUsuario = reader.GetInt32("idUsuario"),
                        nombre = reader.GetString("nombre"),
                        contrasena = reader.GetString("contrasena"),
                        idRol = reader.GetInt32("idRol")
                    };
                    usuarios.Add(usuario);
                }
            }
            catch (MySqlException ex)
            {
                // Propagar excepción con detalle de MySQL
                throw new Exception($"Error MySQL al obtener usuarios (Código {ex.Number}): {ex.Message}", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return usuarios;
        }

        public bool UsuarioEsAdmin(string usuario)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idRol FROM usuario where nombre = @nombre;";
                using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", usuario);
                object result = cmd.ExecuteScalar();
                if (result != null && Convert.ToInt32(result) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                // Propagar excepción con detalle de MySQL
                throw new Exception($"Error MySQL al verificar rol de usuario (Código {ex.Number}): {ex.Message}", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public bool ValidarUsuario(string usuarioValido, string claveValida)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT COUNT(*) FROM usuario WHERE nombre = @nombre AND contrasena = @contrasena";
                using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", usuarioValido);
                cmd.Parameters.AddWithValue("@contrasena", claveValida);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (MySqlException ex)
            {
                // Propagar excepción con detalle de MySQL
                throw new Exception($"Error MySQL al validar usuario (Código {ex.Number}): {ex.Message}", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idUsuario, nombre, contrasena, idRol FROM usuario WHERE nombre = @nombre";
                using var cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        idUsuario = reader.GetInt32("idUsuario"),
                        nombre = reader.GetString("nombre"),
                        contrasena = reader.GetString("contrasena"),
                        idRol = reader.GetInt32("idRol")
                    };
                    return usuario;
                }
                else
                {
                    return null; // No se encontró el usuario
                }
            }
            catch (MySqlException ex)
            {
                // Propagar excepción con detalle de MySQL
                throw new Exception($"Error MySQL al obtener usuario por nombre (Código {ex.Number}): {ex.Message}", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}

