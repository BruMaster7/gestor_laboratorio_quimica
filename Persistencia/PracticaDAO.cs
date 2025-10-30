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
    public class PracticaDAO
    {
        private Conexion conexion;

        public PracticaDAO()
        {
            conexion = new Conexion();
        }

        public int Insertar(Practica p)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"INSERT INTO Practica (fecha, docente, objetivo, cantidadEstudiantes, detalles)
                               VALUES (@fecha, @docente, @objetivo, @cantidadEstudiantes, @detalles);
                               SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@fecha", p.Fecha);
                cmd.Parameters.AddWithValue("@docente", string.IsNullOrWhiteSpace(p.Docente) ? DBNull.Value : (object)p.Docente);
                cmd.Parameters.AddWithValue("@objetivo", p.Objetivo);
                cmd.Parameters.AddWithValue("@cantidadEstudiantes", p.CantidadEstudiantes);
                cmd.Parameters.AddWithValue("@detalles", string.IsNullOrWhiteSpace(p.Detalles) ? DBNull.Value : (object)p.Detalles);

                // Ejecutar y obtener id
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Practica> ObtenerTodas()
        {
            var lista = new List<Practica>();
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idPractica, fecha, docente, objetivo, cantidadEstudiantes, detalles FROM Practica ORDER BY fecha";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Practica
                        {
                            IdPractica = reader.GetInt32("idPractica"),
                            Fecha = reader.GetDateTime("fecha"),
                            Docente = reader.IsDBNull(reader.GetOrdinal("docente")) ? "" : reader.GetString("docente"),
                            Objetivo = reader.IsDBNull(reader.GetOrdinal("objetivo")) ? "" : reader.GetString("objetivo"),
                            CantidadEstudiantes = reader.IsDBNull(reader.GetOrdinal("cantidadEstudiantes")) ? 0 : reader.GetInt32("cantidadEstudiantes"),
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

        public Practica ObtenerPorId(int id)
        {
            Practica p = null;
            try
            {
                conexion.AbrirConexion();
                string sql = "SELECT idPractica, fecha, docente, objetivo, cantidadEstudiantes, detalles FROM Practica WHERE idPractica = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        p = new Practica
                        {
                            IdPractica = reader.GetInt32("idPractica"),
                            Fecha = reader.GetDateTime("fecha"),
                            Docente = reader.IsDBNull(reader.GetOrdinal("docente")) ? "" : reader.GetString("docente"),
                            Objetivo = reader.IsDBNull(reader.GetOrdinal("objetivo")) ? "" : reader.GetString("objetivo"),
                            CantidadEstudiantes = reader.IsDBNull(reader.GetOrdinal("cantidadEstudiantes")) ? 0 : reader.GetInt32("cantidadEstudiantes"),
                            Detalles = reader.IsDBNull(reader.GetOrdinal("detalles")) ? "" : reader.GetString("detalles")
                        };
                    }
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return p;
        }

        public void Eliminar(int id)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = "DELETE FROM Practica WHERE idPractica = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Verifica si existe práctica en ±minutosIntervalo alrededor de la fecha indicada
        public bool HayConflictoHorario(DateTime fecha, int minutosIntervalo = 60, int? excluirId = null)
        {
            try
            {
                conexion.AbrirConexion();
                string sql = @"
                    SELECT COUNT(*) 
                    FROM Practica
                    WHERE ABS(TIMESTAMPDIFF(MINUTE, fecha, @fecha)) < @minutos";

                if (excluirId.HasValue)
                    sql += " AND idPractica <> @excluirId";

                MySqlCommand cmd = new MySqlCommand(sql, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@minutos", minutosIntervalo);

                if (excluirId.HasValue)
                    cmd.Parameters.AddWithValue("@excluirId", excluirId.Value);

                var result = cmd.ExecuteScalar();
                int count = Convert.ToInt32(result);
                return count > 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}

