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
    internal class ControladorProductos
    {

        public void consultarProductos(DataGridView dgProductos)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtProductos = new DataTable();


            dtProductos.Columns.Add("ID", typeof(int));
            dtProductos.Columns.Add("Nombre", typeof(string));
            dtProductos.Columns.Add("Descripción", typeof(string));
            dtProductos.Columns.Add("Precio", typeof(float));
            dtProductos.Columns.Add("Costo", typeof(float));
            dtProductos.Columns.Add("Existencia", typeof(int));
            dtProductos.Columns.Add("Medida", typeof(string));
            dtProductos.Columns.Add("Caducidad", typeof(DateTime));
            dtProductos.Columns.Add("Proveedor", typeof(string));
            dtProductos.Columns.Add("Categoria", typeof(string));

            // Ocultar columnas
            dtProductos.Columns.Add("id_proveedor", typeof(int));
            dtProductos.Columns.Add("id_categoria", typeof(int));

            string sql = @"SELECT p.id_producto, p.nombre, p.descripcion, p.precio, p.costo, p.existencia, 
                          p.unidad_medida, p.fecha_caducidad, 
                          pr.nombre AS nombre_proveedor, pr.id_proveedor,
                          c.nombre AS nombre_categoria, c.id_categoria
                   FROM productos p 
                   INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor 
                   INNER JOIN categorias c ON p.id_categoria = c.id_categoria";

            try
            {
                using (MySqlConnection sqlConnection = conexion.establecerConexion())
                {
                    MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

                    DataTable dtDatos = new DataTable();
                    sqlDataAdapter.Fill(dtDatos);

                    foreach (DataRow row in dtDatos.Rows)
                    {
                        dtProductos.Rows.Add(
                            Convert.ToInt32(row["id_producto"]),      
                            row["nombre"].ToString(),               
                            row["descripcion"].ToString(),        
                            Convert.ToSingle(row["precio"]),
                            Convert.ToSingle(row["costo"]),           
                            Convert.ToInt32(row["existencia"]),      
                            row["unidad_medida"].ToString(),    
                            Convert.ToDateTime(row["fecha_caducidad"]), 
                            row["nombre_proveedor"].ToString(),       
                            row["nombre_categoria"].ToString(),  
                            Convert.ToInt32(row["id_proveedor"]),     
                            Convert.ToInt32(row["id_categoria"])      
                        );
                    }

                    dgProductos.DataSource = dtProductos;

                    dgProductos.Columns["id_proveedor"].Visible = false;
                    dgProductos.Columns["id_categoria"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los productos: " + ex.Message);
            }
        }
        

        public void productosPorId(int idProducto, ModeloProductos modeloProductos)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "SELECT * FROM productos WHERE id_producto = @id_producto";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_producto", idProducto);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    modeloProductos.IdProducto = Convert.ToInt32(reader["id_producto"]);
                    modeloProductos.Nombre = reader["nombre"].ToString();
                    modeloProductos.Descripcion = reader["descripcion"].ToString();
                    modeloProductos.Precio = Convert.ToSingle(reader["precio"]);
                    modeloProductos.Costo = Convert.ToSingle(reader["costo"]);
                    modeloProductos.Existencia = Convert.ToInt32(reader["existencia"]);
                    modeloProductos.Unidad_medida = reader["unidad_medida"].ToString();
                    modeloProductos.Fecha_caducidad = Convert.ToDateTime(reader["fecha_caducidad"]);
                    modeloProductos.Proveedor = reader["id_proveedor"].ToString();
                    modeloProductos.Categoria = reader["id_categoria"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el producto por ID: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void consultaProveedores(ComboBox cbProveedores) 
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtProveedores = new DataTable();

            try
            {
                // Configurar DataTable
                dtProveedores.Columns.Add("ID", typeof(int));
                dtProveedores.Columns.Add("Nombre", typeof(string));

                // Obtener conexión
                MySqlConnection sqlConexion = conexion.establecerConexion();

                // Crear y ejecutar comando
                string sql = "SELECT id_proveedor, nombre FROM proveedores";
                MySqlCommand cmd = new MySqlCommand(sql, sqlConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                // Llenar DataTable
                adaptador.Fill(dtProveedores);

                // Configurar ComboBox
                cbProveedores.DataSource = dtProveedores;
                cbProveedores.ValueMember = "ID";
                cbProveedores.DisplayMember = "Nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar los proveedores: " + e.Message);
            }
            finally
            {
                
                conexion.cerrarConexion();
            }
        }

        public void consultaCategorias(ComboBox cbCategorias)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            Modelos.ModeloProductos objetoCategorias = new Modelos.ModeloProductos();
            DataTable dtModelo = new DataTable();

            dtModelo.Columns.Add("ID", typeof(int));
            dtModelo.Columns.Add("Nombre", typeof(string));

            string sql = "SELECT id_categoria, nombre FROM categorias";
            DataTable dt = dtModelo;
            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable dtDatos = ds.Tables[0];
                foreach (DataRow row in dtDatos.Rows)
                {
                    objetoCategorias.IdProducto = Convert.ToInt32(row["id_categoria"]);
                    objetoCategorias.Nombre = row["nombre"].ToString();
                    dtModelo.Rows.Add(objetoCategorias.IdProducto, objetoCategorias.Nombre);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar las categorias: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
            cbCategorias.DataSource = dtModelo;
            cbCategorias.ValueMember = "ID";
            cbCategorias.DisplayMember = "Nombre";
        }

        public void agregarProducto(ModeloProductos objetoProducto)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "INSERT INTO productos (nombre, descripcion, precio, costo, existencia, unidad_medida, fecha_caducidad, id_proveedor, id_categoria) VALUES (@nombre, @descripcion, @precio, @costo, @existencia, @unidad_medida, @fecha_caducidad, @id_proveedor, @id_categoria)";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", objetoProducto.Nombre);
                sqlCommand.Parameters.AddWithValue("@descripcion", objetoProducto.Descripcion);
                sqlCommand.Parameters.AddWithValue("@precio", objetoProducto.Precio);
                sqlCommand.Parameters.AddWithValue("@costo", objetoProducto.Costo);
                sqlCommand.Parameters.AddWithValue("@existencia", objetoProducto.Existencia);
                sqlCommand.Parameters.AddWithValue("@unidad_medida", objetoProducto.Unidad_medida);
                sqlCommand.Parameters.AddWithValue("@fecha_caducidad", objetoProducto.Fecha_caducidad);
                sqlCommand.Parameters.AddWithValue("@id_proveedor", objetoProducto.Proveedor);
                sqlCommand.Parameters.AddWithValue("@id_categoria", objetoProducto.Categoria);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto agregado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }

        }

        public void actualizarProducto(ModeloProductos objetoProducto)
        {
            if (objetoProducto == null)
            {
                MessageBox.Show("El producto no puede ser nulo.");
                return;
            }
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, precio = @precio, costo = @costo, existencia = @existencia, unidad_medida = @unidad_medida, fecha_caducidad = @fecha_caducidad, id_proveedor = @id_proveedor, id_categoria = @id_categoria WHERE id_producto = @id_producto";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_producto", objetoProducto.IdProducto);
                sqlCommand.Parameters.AddWithValue("@nombre", objetoProducto.Nombre);
                sqlCommand.Parameters.AddWithValue("@descripcion", objetoProducto.Descripcion);
                sqlCommand.Parameters.AddWithValue("@precio", objetoProducto.Precio);
                sqlCommand.Parameters.AddWithValue("@costo", objetoProducto.Costo);
                sqlCommand.Parameters.AddWithValue("@existencia", objetoProducto.Existencia);
                sqlCommand.Parameters.AddWithValue("@unidad_medida", objetoProducto.Unidad_medida);
                sqlCommand.Parameters.AddWithValue("@fecha_caducidad", objetoProducto.Fecha_caducidad);
                sqlCommand.Parameters.AddWithValue("@id_proveedor", objetoProducto.Proveedor);
                sqlCommand.Parameters.AddWithValue("@id_categoria", objetoProducto.Categoria);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
            finally
            {
                if (conexion != null) conexion.cerrarConexion();

            }
        }

        public void eliminarProducto(int idProducto)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "DELETE FROM productos WHERE id_producto = @id_producto";
            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_producto", idProducto);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0) MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}