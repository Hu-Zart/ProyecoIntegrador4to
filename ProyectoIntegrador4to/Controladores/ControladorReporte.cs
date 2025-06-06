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
            string sql = @"SELECT 
                p.nombre AS Producto, 
                cantidad AS Cantidad, 
                precio_venta AS Precio 
               FROM detalle_ventas d 
               JOIN productos p ON d.id_producto = p.id_producto 
               WHERE id_venta = @idVenta";
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

        public void reporteHojaHistoria(DataSet dsReporte, int idConsulta)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"SELECT 
    u.nombre AS UNombre,
    u.telefono AS UTelefono,
    c.fecha_consulta AS FechaConsulta,
    t.nombre AS TNombre,
    t.direccion AS TDireccion,
    t.telefono AS TTelefono,
    p.nombre AS PNombre,
    e.nombre AS PEspecie,  
    p.raza AS PRaza,
    p.fecha_nacimiento AS PFechaNacimiento,
    c.temperatura AS Temperatura,
    c.frecuencia_cardiaca AS LPM,
    c.frecuencia_respiratoria AS RPM,
    c.motivo AS Motivo,
    c.anamnesis AS Anamnesis,
    c.diagnostico AS Diagnostico,
    c.tratamiento AS Tratamiento
FROM consultas c
INNER JOIN usuarios u ON c.id_usuario = u.id_usuario
INNER JOIN pacientes p ON c.id_paciente = p.id_paciente
INNER JOIN tutores t ON p.id_tutor = t.id_tutor
INNER JOIN especies e ON p.id_especie = e.id_especie  
WHERE c.id_consulta = @idConsulta";

            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                comando.Parameters.AddWithValue("@idConsulta", idConsulta);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                // Llenar la tabla específica del XSD
                adaptador.Fill(dsReporte, "HojaHistoria");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al generar hoja de historia: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

    }
}
