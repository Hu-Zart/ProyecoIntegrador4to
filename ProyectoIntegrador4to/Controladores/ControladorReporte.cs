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
        public void reporteDetallesVenta(DataSet dsReporte, int idVentaSeleccionada)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"select p.nombre, cantidad, precio_venta from detalle_ventas d join productos p on d.id_producto = p.id_producto where id_venta = @idVenta";
            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                comando.Parameters.AddWithValue("@idVenta", idVentaSeleccionada);
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
