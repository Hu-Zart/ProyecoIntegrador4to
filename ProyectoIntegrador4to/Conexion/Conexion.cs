using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Conexion
{
    internal class Conexion
    {

        private MySqlConnection conectar = null;

        private static string servidor = "localhost";
        private static string usuario = "root";
        private static string password = "tics";
        private static string bd = "veterinariaDN";
        private static string puerto = "3306";

        private static string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conectar = new MySqlConnection(cadenaConexion);
                conectar.Open();
                //MessageBox.Show("Conexión exitosa a la base de datos");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return conectar;
        }

        public void cerrarConexion()
        {
            try
            {
                if (conectar != null && conectar.State == System.Data.ConnectionState.Open)
                {
                    conectar.Close();
                    //MessageBox.Show("Conexión cerrada");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }

}
