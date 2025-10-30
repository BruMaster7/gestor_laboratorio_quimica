using Entidades;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Dominio;
using Persistencia.Persistencia;

namespace Persistencia
{
    public class AlertaDAO
    {
        private Conexion conexion;

        public AlertaDAO()
        {
            conexion = new Conexion();
        }

        public List<Alerta> GenerarAlertas()
        {
            var alertas = new List<Alerta>();

            // Accesorios sin stock
            var accesorioDao = new AccesorioDAO();
            var accesoriosSinStock = accesorioDao.ObtenerAccesoriosSinStock();
            foreach (var acc in accesoriosSinStock)
            {
                alertas.Add(new Alerta
                {
                    Tipo = "Accesorio sin stock",
                    Descripcion = $"El accesorio '{acc.Nombre}' se ha quedado sin stock en la ubicación '{acc.Ubicacion}'.",
                    FechaHora = DateTime.Now,
                    Activo = true
                });
            }

            // Sustancias con stock crítico
            var sustanciaDao = new SustanciaDAO();
            var sustanciasCriticas = sustanciaDao.ObtenerCriticas();
            foreach (var sus in sustanciasCriticas)
            {
                alertas.Add(new Alerta
                {
                    Tipo = "Sustancia con stock crítico",
                    Descripcion = $"La sustancia '{sus.Nombre}' tiene un stock actual de {sus.StockActual}, igual o menor al mínimo permitido ({sus.StockMinimo}).",
                    FechaHora = DateTime.Now,
                    Activo = true,
                    IdSustancia = sus.IdSustancia
                });
            }

            // Sustancias vencidas
            var sustanciasVencidas = sustanciaDao.ObtenerVencidas();
            foreach (var sus in sustanciasVencidas)
            {
                alertas.Add(new Alerta
                {
                    Tipo = "Sustancia vencida",
                    Descripcion = $"La sustancia '{sus.Nombre}' ha vencido el {sus.FechaVencimiento:dd/MM/yyyy}.",
                    FechaHora = DateTime.Now,
                    Activo = true,
                    IdSustancia = sus.IdSustancia
                });
            }

            return alertas;
        }

        // Guarda una alerta en la base de datos
        public void Insertar(Alerta alerta, int? idSustancia = null)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"INSERT INTO Alerta (Tipo, Descripcion, fechaHora, Activo, idSustancia)
                               VALUES (@Tipo, @Descripcion, @fechaHora, @Activo, @idSustancia)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Tipo", alerta.Tipo);
                cmd.Parameters.AddWithValue("@Descripcion", alerta.Descripcion);
                cmd.Parameters.AddWithValue("@fechaHora", alerta.FechaHora);
                cmd.Parameters.AddWithValue("@Activo", alerta.Activo);
                if (idSustancia.HasValue)
                    cmd.Parameters.AddWithValue("@idSustancia", idSustancia.Value);
                else
                    cmd.Parameters.AddWithValue("@idSustancia", DBNull.Value);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Trae todas las alertas activas
        public List<Alerta> ObtenerAlertasActivas()
        {
            var lista = new List<Alerta>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idAlerta, Tipo, Descripcion, fechaHora, Activo, idSustancia FROM Alerta WHERE Activo = 1";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Alerta
                        {
                            IdAlerta = reader.GetInt32("idAlerta"),
                            Tipo = reader.GetString("Tipo"),
                            Descripcion = reader.GetString("Descripcion"),
                            FechaHora = reader.GetDateTime("fechaHora"),
                            Activo = reader.GetBoolean("Activo"),
                            IdSustancia = reader.IsDBNull(reader.GetOrdinal("idSustancia")) ? null : reader.GetInt32("idSustancia")
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

        // Desactiva alertas activas de una sustancia por tipo (cuando IdSustancia está presente)
        public void DesactivarAlertasPorSustanciaYTipo(int idSustancia, string tipo)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "UPDATE Alerta SET Activo = 0 WHERE idSustancia = @idSustancia AND Tipo = @tipo AND Activo = 1";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@idSustancia", idSustancia);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Desactiva alertas activas de un tipo que contengan el nombre del accesorio en la descripción
        public void DesactivarAlertasPorAccesorioNombre(string nombreAccesorio, string tipo = "Accesorio sin stock")
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "UPDATE Alerta SET Activo = 0 WHERE Tipo = @tipo AND Descripcion LIKE @pat AND Activo = 1";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@pat", "%" + nombreAccesorio + "%");
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Elimina todas las alertas (activas o no) asociadas a una accesorio buscando por descripción
        public void EliminarPorAccesorioNombre(string nombreAccesorio, string tipo = "Accesorio sin stock")
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "DELETE FROM Alerta WHERE Tipo = @tipo AND Descripcion LIKE @pat";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@pat", "%" + nombreAccesorio + "%");
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Desactiva todas las alertas activas relacionadas con una sustancia
        public void DesactivarAlertasPorSustancia(int idSustancia)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "UPDATE Alerta SET Activo = 0 WHERE idSustancia = @idSustancia AND Activo = 1";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@idSustancia", idSustancia);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Elimina todas las alertas (activas o no) asociadas a una sustancia
        public void EliminarPorSustancia(int idSustancia)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "DELETE FROM Alerta WHERE idSustancia = @idSustancia";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@idSustancia", idSustancia);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
