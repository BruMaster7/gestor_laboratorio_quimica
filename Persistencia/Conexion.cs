using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using MySql.Data.MySqlClient;

namespace Persistencia
{



    namespace Persistencia
    {
        public class Conexion
        {
            private MySqlConnection conexion;
            private string cadenaConexion;

            public Conexion()
            {
                // La cadena de conexión usa los valores por defecto de XAMPP.
                // Server=localhost (o 127.0.0.1)
                // Port=3306 (por defecto)
                // User=root (por defecto, sin contraseña)
                // Database=laboratorio (la base de datos que se desea conectar)
                cadenaConexion = "Server=localhost;Port=3306;Database=laboratorio;Uid=root;Pwd=;";
                conexion = new MySqlConnection(cadenaConexion);
            }

            public void AbrirConexion()
            {
                try
                {
                    conexion.Open();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error general: " + ex.Message);
                }
            }

            public void CerrarConexion()
            {
                try
                {
                    if (conexion.State == System.Data.ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error general: " + ex.Message);
                }
            }

            public MySqlConnection ObtenerConexion()
            {
                return conexion;
            }
        }
    }
}
