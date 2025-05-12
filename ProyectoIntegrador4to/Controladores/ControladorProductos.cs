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
            Modelos.ModeloProductos objetoProductos = new Modelos.ModeloProductos();
            DataTable dtProductos = new DataTable();

            dtProductos.Columns.Add("ID", typeof(int));
            dtProductos.Columns.Add("Nombre", typeof(string));
            dtProductos.Columns.Add("Descipción", typeof(string));
            dtProductos.Columns.Add("Precio", typeof(float));
            dtProductos.Columns.Add("Costo", typeof(float));
            dtProductos.Columns.Add("Existencia", typeof(int));
            dtProductos.Columns.Add("Medida", typeof(string));
            dtProductos.Columns.Add("Caducidad", typeof(DateTime));
            dtProductos.Columns.Add("Proveedor", typeof(string));
            dtProductos.Columns.Add("Categoria", typeof(string));

            string sql = @"SELECT p.id_producto, p.nombre, p.descripcion, p.precio, p.costo, p.existencia, p.unidad_medida, p.fecha_caducidad, pr.nombre, c.nombre
                         FROM productos p 
                         INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor 
                         INNER JOIN categorias c ON p.id_categoria = c.id_categoria";

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
                    objetoProductos.IdProducto = Convert.ToInt32(row["id_producto"]);
                    objetoProductos.Nombre = row["nombre"].ToString();
                    objetoProductos.Descripcion = row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : "";
                    objetoProductos.Precio = Convert.ToSingle(row["precio"]);
                    objetoProductos.Costo = Convert.ToSingle(row["costo"]);
                    objetoProductos.Existencia = Convert.ToInt32(row["existencia"]);
                    objetoProductos.Unidad_medida = row["unidad_medida"] != DBNull.Value ? row["unidad_medida"].ToString() : "";
                    objetoProductos.Fecha_caducidad = row["fecha_caducidad"] != DBNull.Value ? Convert.ToDateTime(row["fecha_caducidad"]) : DateTime.MinValue;
                    objetoProductos.Proveedor = row["nombre"].ToString();
                    objetoProductos.Categoria = row["nombre"].ToString();
                    dtProductos.Rows.Add(objetoProductos.IdProducto, objetoProductos.Nombre, objetoProductos.Descripcion,
                        objetoProductos.Precio, objetoProductos.Costo, objetoProductos.Existencia,
                        objetoProductos.Unidad_medida, objetoProductos.Fecha_caducidad, objetoProductos.Proveedor,
                        objetoProductos.Categoria);
                }

                dgProductos.DataSource = dtProductos; //asignasr los productos al datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los productos: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
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

        public void consultarProveedores(ComboBox cbProveedores)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            Modelos.ModeloProductos objetoProveedores = new Modelos.ModeloProductos();
        }
    }
}
