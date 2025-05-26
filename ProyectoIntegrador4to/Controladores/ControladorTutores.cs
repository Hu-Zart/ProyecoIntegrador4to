using MySql.Data.MySqlClient;
using System;
using ProyectoIntegrador4to.Modelos;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Controladores
{
    internal class ControladorTutores
    {
        public void consultarTutores(DataGridView dgTutores)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            Modelos.ModeloTutores objetoTutor = new Modelos.ModeloTutores();
            DataTable dtTutores = new DataTable();

            dtTutores.Columns.Add("ID", typeof(int));
            dtTutores.Columns.Add("Nombre", typeof(string));
            dtTutores.Columns.Add("Dirección", typeof(string));
            dtTutores.Columns.Add("Telefono", typeof(string));

            string sql = "SELECT id_tutor, nombre, direccion, telefono FROM tutores";

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
                    objetoTutor.IdTutor = Convert.ToInt32(row["id_tutor"]);
                    objetoTutor.Nombre = row["nombre"].ToString();
                    objetoTutor.Direccion = row["direccion"] != DBNull.Value ? row["direccion"].ToString() : "";
                    objetoTutor.Telefono = row["telefono"] != DBNull.Value ? row["telefono"].ToString() : "";
                    dtTutores.Rows.Add(objetoTutor.IdTutor, objetoTutor.Nombre, objetoTutor.Direccion, objetoTutor.Telefono);
                }
                dgTutores.DataSource = dtTutores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los tutores: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void tutoresPorId(int idTutor, ModeloTutores objetoTutores)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "SELECT id_tutor, nombre, direccion, telefono FROM tutores WHERE id_tutor = @id_tutor";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_tutor", idTutor);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataSet dt = new DataSet();
                sqlDataAdapter.Fill(dt);
                DataTable dtDatos = dt.Tables[0];
                foreach (DataRow row in dtDatos.Rows)
                {
                    objetoTutores.IdTutor = Convert.ToInt32(row["id_tutor"]);
                    objetoTutores.Nombre = row["nombre"].ToString();
                    objetoTutores.Direccion = row["direccion"] != DBNull.Value ? row["direccion"].ToString() : "";
                    objetoTutores.Telefono = row["telefono"] != DBNull.Value ? row["telefono"].ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el tutor por ID: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void agregarTutor(ModeloTutores tutor)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "INSERT INTO tutores (nombre, direccion, telefono) VALUES (@nombre, @direccion, @telefono)";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", tutor.Nombre);
                sqlCommand.Parameters.AddWithValue("@direccion", tutor.Direccion);
                sqlCommand.Parameters.AddWithValue("@telefono", tutor.Telefono);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Tutor agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tutor: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void actualizarTutor(ModeloTutores objetoTutor)
        {
            if (objetoTutor == null)
            {
                MessageBox.Show("El objeto tutor no puede ser nullo.");
                return;
            }
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "UPDATE tutores SET nombre = @nombre, direccion = @direccion, telefono = @telefono WHERE id_tutor = @id_tutor";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", objetoTutor.Nombre);
                sqlCommand.Parameters.AddWithValue("@direccion", objetoTutor.Direccion);
                sqlCommand.Parameters.AddWithValue("@telefono", objetoTutor.Telefono);
                sqlCommand.Parameters.AddWithValue("@id_tutor", objetoTutor.IdTutor);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Tutor actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el tutor: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void eliminarTutor(int idTutor)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "DELETE FROM tutores WHERE id_tutor = @id_tutor";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_tutor", idTutor);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Tutor eliminado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el tutor: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
