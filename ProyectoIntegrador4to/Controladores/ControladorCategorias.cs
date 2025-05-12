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
    internal class ControladorCategorias
    {
        public void consultarCategorias(DataGridView dgCategorias)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            Modelos.ModeloCategorias objetoCategoria = new Modelos.ModeloCategorias();
            DataTable dtCategorias = new DataTable();

            dtCategorias.Columns.Add("ID", typeof(int));
            dtCategorias.Columns.Add("Nombre", typeof(string));
            dtCategorias.Columns.Add("Descripción", typeof(string));

            string sql = "SELECT id_categoria, nombre, descripcion FROM categorias";

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
                    objetoCategoria.IdCategoria = Convert.ToInt32(row["id_categoria"]);
                    objetoCategoria.Nombre = row["nombre"].ToString();
                    objetoCategoria.Descripcion = row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : "";
                    dtCategorias.Rows.Add(objetoCategoria.IdCategoria, objetoCategoria.Nombre, objetoCategoria.Descripcion);
                }

                dgCategorias.DataSource = dtCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las categorías: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void categoriasPorId(int idCategoria, ModeloCategorias objetoCategorias)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "SELECT id_categoria, nombre, descripcion FROM categorias WHERE id_categoria = @id_categoria";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_categoria", idCategoria);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataSet dt = new DataSet();
                sqlDataAdapter.Fill(dt);
                DataTable dtDatos = dt.Tables[0];
                foreach (DataRow row in dtDatos.Rows)
                {
                    objetoCategorias.IdCategoria = Convert.ToInt32(row["id_categoria"]);
                    objetoCategorias.Nombre = row["nombre"].ToString();
                    objetoCategorias.Descripcion = row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la categoría por ID: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void agregarCategoria(ModeloCategorias objetoCategoria)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "INSERT INTO categorias (nombre, descripcion) VALUES (@nombre, @descripcion)";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@nombre", objetoCategoria.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", objetoCategoria.Descripcion);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Categoría agregada correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al agregar la categoría: " + e.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void actualizarCategoria(ModeloCategorias objetoCategoria)
        {
            if (objetoCategoria == null)
            {
                MessageBox.Show("Error: el objeto de categoría no puede ser nulo.");
                return;
            }
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "UPDATE categorias SET nombre = @nombre, descripcion = @descripcion WHERE id_categoria = @id_categoria";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@nombre", objetoCategoria.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", objetoCategoria.Descripcion);
                cmd.Parameters.AddWithValue("@id_categoria", objetoCategoria.IdCategoria);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Categoria actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la categoria a actualizar.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar la categoría: " + e.Message);
            }
            finally
            {
                if (conexion != null) conexion.cerrarConexion();
                
            }


        }

        public void eliminarCategoria(int idCurso)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "DELETE FROM categorias WHERE id_categoria = @id_categoria";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@id_categoria", idCurso);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Categoría eliminada correctamente.");
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar la categoría: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

    }

}
