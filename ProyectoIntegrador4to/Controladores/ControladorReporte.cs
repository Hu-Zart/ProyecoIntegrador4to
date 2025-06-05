using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Controladores
{
    internal class ControladorReporte
    {
        public void reporteDetallesVenta(DataSet dsReporte)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"SELECT
                            p.nombre,
                            p.email,
                            c.titulo AS cursos
                        FROM personas p
                        INNER JOIN inscripciones i ON p.id = i.id_persona
                        INNER JOIN cursos c ON i.id_curso = c.id";
            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dsReporte);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar los cursos por persona: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

    }
}
