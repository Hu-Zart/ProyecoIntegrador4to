using MySql.Data.MySqlClient;
using ProyectoIntegrador4to.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Controladores
{
    internal class ControladorProveedoes
    {
        public void consultarProveedores(DataGridView dgProveedores)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            Modelos.ModeloProveedores objetoProveedor = new Modelos.ModeloProveedores();
            DataTable dtProveedores = new DataTable();

            dtProveedores.Columns.Add("ID", typeof(int));
            dtProveedores.Columns.Add("Nombre", typeof(string));
            dtProveedores.Columns.Add("Contacto", typeof(string));
            dtProveedores.Columns.Add("Teléfono", typeof(string));
            dtProveedores.Columns.Add("Dirección", typeof(string));
            dtProveedores.Columns.Add("Email", typeof(string));

            string sql = "SELECT id_proveedor, nombre, contacto, telefono, direccion, email FROM proveedores";

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
                    objetoProveedor.IdProveedor = Convert.ToInt32(row["id_proveedor"]);
                    objetoProveedor.Nombre = row["nombre"].ToString();
                    objetoProveedor.Contacto = row["contacto"].ToString();
                    objetoProveedor.Telefono = row["telefono"].ToString();
                    objetoProveedor.Direccion = row["direccion"].ToString();
                    objetoProveedor.Email = row["email"].ToString();
                    dtProveedores.Rows.Add(objetoProveedor.IdProveedor, objetoProveedor.Nombre, objetoProveedor.Contacto, objetoProveedor.Telefono, objetoProveedor.Direccion, objetoProveedor.Email);
                }

                dgProveedores.DataSource = dtProveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los proveedores: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void proveedoresPorId(int idProveedor, ModeloProveedores objetoPorveedor)
        {
            if (objetoPorveedor == null)
            {
                MessageBox.Show("Error: el objeto de proveedor no puede ser nulo");
                return;
            }
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "SELECT id_proveedor, nombre, contacto, telefono, direccion, email FROM proveedores WHERE id_proveedor = @id_proveedor";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_proveedor", idProveedor);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataSet dt = new DataSet();
                sqlDataAdapter.Fill(dt);
                DataTable dtDatos = dt.Tables[0];
                foreach (DataRow row in dtDatos.Rows)
                {
                    objetoPorveedor.IdProveedor = Convert.ToInt32(row["id_proveedor"]);
                    objetoPorveedor.Nombre = row["nombre"].ToString();
                    objetoPorveedor.Contacto = row["contacto"].ToString();
                    objetoPorveedor.Telefono = row["telefono"].ToString();
                    objetoPorveedor.Direccion = row["direccion"].ToString();
                    objetoPorveedor.Email = row["email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el proveedor por ID: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void agregarProveedor(ModeloProveedores objetoProveedore)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "INSERT INTO proveedores (nombre, contacto, telefono, direccion, email) VALUES (@nombre, @contacto, @telefono, @direccion, @email)";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@nombre", objetoProveedore.Nombre);
                cmd.Parameters.AddWithValue("@contacto", objetoProveedore.Contacto);
                cmd.Parameters.AddWithValue("@telefono", objetoProveedore.Telefono);
                cmd.Parameters.AddWithValue("@direccion", objetoProveedore.Direccion);
                cmd.Parameters.AddWithValue("@email", objetoProveedore.Email);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Proveedor agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el proveedor: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void actualizarProveedor(ModeloProveedores objetoProveedore)
        {
            if (objetoProveedore == null)
            {
                MessageBox.Show("Error: el objeto de proveedor no puede ser nulo.");
                return;
            }
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "UPDATE proveedores SET nombre = @nombre, contacto = @contacto, telefono = @telefono, direccion = @direccion, email = @email WHERE id_proveedor = @id_proveedor";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@id_proveedor", objetoProveedore.IdProveedor);
                cmd.Parameters.AddWithValue("@nombre", objetoProveedore.Nombre);
                cmd.Parameters.AddWithValue("@contacto", objetoProveedore.Contacto);
                cmd.Parameters.AddWithValue("@telefono", objetoProveedore.Telefono);
                cmd.Parameters.AddWithValue("@direccion", objetoProveedore.Direccion);
                cmd.Parameters.AddWithValue("@email", objetoProveedore.Email);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Proveedor actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el proveedor con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message);
            }
            finally
            {
                if (conexion != null) conexion.cerrarConexion();

            }
        }

        public void eliminarProveedor(int idProveedor)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "DELETE FROM proveedores WHERE id_proveedor = @id_proveedor";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@id_proveedor", idProveedor);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Proveedor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
