using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Controladores
{
    internal class ControladorUsuarios
    {
        public void consultarUsuarios(DataGridView dgUsuarios)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            Modelos.ModeloUsuarios objetoUsuario = new Modelos.ModeloUsuarios();
            DataTable dtUsuarios = new DataTable();

            // Definir columnas (sin permitir nulos en el DataTable, como en el ejemplo)
            dtUsuarios.Columns.Add("ID", typeof(int));
            dtUsuarios.Columns.Add("Nombre", typeof(string));
            dtUsuarios.Columns.Add("Fecha Ingreso", typeof(DateTime));
            dtUsuarios.Columns.Add("Dirección", typeof(string));
            dtUsuarios.Columns.Add("Priv. Inventario", typeof(bool));
            dtUsuarios.Columns.Add("Priv. Administrativo", typeof(bool));
            dtUsuarios.Columns.Add("Priv. Veterinario", typeof(bool));
            dtUsuarios.Columns.Add("Priv. Venta", typeof(bool));
            dtUsuarios.Columns.Add("Telefono", typeof(string));
            dtUsuarios.Columns.Add("Contraseña", typeof(string));

            string sql = @"
        SELECT 
            id_usuario, 
            nombre, 
            fecha_ingreso, 
            direccion, 
            privilegio_inventario, 
            privilegio_administrativo, 
            privilegio_veterinario, 
            privilegio_venta, 
            telefono, 
            contraseña 
        FROM usuarios";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataSet dt = new DataSet();
                sqlDataAdapter.Fill(dt);
                DataTable dtDatos = dt.Tables[0];

                foreach (DataRow row in dtDatos.Rows)
                {
                    
                    objetoUsuario.IdUsuario = Convert.ToInt32(row["id_usuario"]);
                    objetoUsuario.Nombre = row["nombre"].ToString();
                    objetoUsuario.FechaRegistro = Convert.ToDateTime(row["fecha_ingreso"]);
                    objetoUsuario.Direccion = row["direccion"].ToString();
                    objetoUsuario.PermisoInventario = Convert.ToBoolean(row["privilegio_inventario"]);
                    objetoUsuario.PermisoRegistro = Convert.ToBoolean(row["privilegio_administrativo"]);
                    objetoUsuario.PermisoVeterinario = Convert.ToBoolean(row["privilegio_veterinario"]);
                    objetoUsuario.PermisoVenta= Convert.ToBoolean(row["privilegio_venta"]);
                    objetoUsuario.Telefono = row["telefono"].ToString();
                    objetoUsuario.Contrasena = row["contraseña"].ToString();

                    dtUsuarios.Rows.Add(
                        objetoUsuario.IdUsuario,
                        objetoUsuario.Nombre,
                        objetoUsuario.FechaRegistro,
                        objetoUsuario.Direccion,
                        objetoUsuario.PermisoInventario,
                        objetoUsuario.PermisoRegistro,
                        objetoUsuario.PermisoVeterinario,
                        objetoUsuario.PermisoVenta,
                        objetoUsuario.Telefono,
                        objetoUsuario.Contrasena
                    );
                }

                dgUsuarios.DataSource = dtUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los usuarios: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void agregarUsuario(Modelos.ModeloUsuarios usuario)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"
        INSERT INTO usuarios 
            (nombre, fecha_ingreso, direccion, privilegio_inventario, privilegio_administrativo, 
             privilegio_veterinario, privilegio_venta, telefono, contraseña) 
        VALUES 
            (@nombre, @fecha_ingreso, @direccion, @privilegio_inventario, @privilegio_administrativo, 
             @privilegio_veterinario, @privilegio_venta, @telefono, @contrasena)";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", usuario.Nombre);
                sqlCommand.Parameters.AddWithValue("@fecha_ingreso", usuario.FechaRegistro);
                sqlCommand.Parameters.AddWithValue("@direccion", usuario.Direccion);
                sqlCommand.Parameters.AddWithValue("@privilegio_inventario", usuario.PermisoInventario);
                sqlCommand.Parameters.AddWithValue("@privilegio_administrativo", usuario.PermisoRegistro);
                sqlCommand.Parameters.AddWithValue("@privilegio_veterinario", usuario.PermisoVeterinario);
                sqlCommand.Parameters.AddWithValue("@privilegio_venta", usuario.PermisoVenta);
                sqlCommand.Parameters.AddWithValue("@telefono", usuario.Telefono);
                sqlCommand.Parameters.AddWithValue("@contrasena", usuario.Contrasena);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario agregado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void actualizarUsuario(Modelos.ModeloUsuarios objetoUsuario)
        {
            if (objetoUsuario == null)
            {
                MessageBox.Show("El objeto usuario no puede ser nulo.");
                return;
            }

            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"
        UPDATE usuarios SET 
            nombre = @nombre,
            fecha_ingreso = @fecha_ingreso,
            direccion = @direccion,
            privilegio_inventario = @privilegio_inventario,
            privilegio_administrativo = @privilegio_administrativo,
            privilegio_veterinario = @privilegio_veterinario,
            privilegio_venta = @privilegio_venta,
            telefono = @telefono,
            contraseña = @contrasena
        WHERE id_usuario = @id_usuario";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", objetoUsuario.Nombre);
                sqlCommand.Parameters.AddWithValue("@fecha_ingreso", objetoUsuario.FechaRegistro);
                sqlCommand.Parameters.AddWithValue("@direccion", objetoUsuario.Direccion);
                sqlCommand.Parameters.AddWithValue("@privilegio_inventario", objetoUsuario.PermisoInventario);
                sqlCommand.Parameters.AddWithValue("@privilegio_administrativo", objetoUsuario.PermisoRegistro);
                sqlCommand.Parameters.AddWithValue("@privilegio_veterinario", objetoUsuario.PermisoVeterinario);
                sqlCommand.Parameters.AddWithValue("@privilegio_venta", objetoUsuario.PermisoVenta);
                sqlCommand.Parameters.AddWithValue("@telefono", objetoUsuario.Telefono);
                sqlCommand.Parameters.AddWithValue("@contrasena", objetoUsuario.Contrasena);
                sqlCommand.Parameters.AddWithValue("@id_usuario", objetoUsuario.IdUsuario);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario actualizado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void eliminarUsuario(int idUsuario)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "DELETE FROM usuarios WHERE id_usuario = @id_usuario";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_usuario", idUsuario);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario eliminado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }


    }
}
