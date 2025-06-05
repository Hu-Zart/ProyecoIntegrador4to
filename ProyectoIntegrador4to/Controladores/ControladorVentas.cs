using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Controladores
{
    internal class ControladorVentas
    {
        public void consultarVentas(DataGridView dgVentas)
        {
            // Instancia de tu clase de conexión
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtVentas = new DataTable();

            // Definimos las columnas que queremos mostrar en el DataGridView
            dtVentas.Columns.Add("ID_Venta", typeof(int));
            dtVentas.Columns.Add("ID_Tutor", typeof(int));
            dtVentas.Columns.Add("ID_Usuario", typeof(int));
            dtVentas.Columns.Add("Fecha_Venta", typeof(DateTime));
            dtVentas.Columns.Add("Subtotal", typeof(decimal));

            // Consulta SQL: traemos cada venta y le sumamos el subtotal de todos los detalles asociados
            string sql = @"
        SELECT 
            v.id_venta,
            v.id_tutor,
            v.id_usuario,
            v.fecha_venta,
            IFNULL(SUM(d.cantidad * d.precio_venta), 0) AS subtotal
        FROM ventas v
        LEFT JOIN detalle_ventas d ON v.id_venta = d.id_venta
        GROUP BY 
            v.id_venta, 
            v.id_tutor, 
            v.id_usuario, 
            v.fecha_venta
        ORDER BY v.id_venta;
    ";

            try
            {
                using (MySqlConnection sqlConnection = conexion.establecerConexion())
                {
                    MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

                    DataTable dtDatos = new DataTable();
                    sqlDataAdapter.Fill(dtDatos);

                    // Llenamos nuestro DataTable personalizado con los resultados de la consulta
                    foreach (DataRow row in dtDatos.Rows)
                    {
                        dtVentas.Rows.Add(
                            Convert.ToInt32(row["id_venta"]),
                            // El campo id_tutor puede ser NULL en la tabla, así que checamos antes de convertir
                            row["id_tutor"] != DBNull.Value ? Convert.ToInt32(row["id_tutor"]) : 0,
                            Convert.ToInt32(row["id_usuario"]),
                            Convert.ToDateTime(row["fecha_venta"]),
                            Convert.ToDecimal(row["subtotal"])
                        );
                    }

                    // Asignamos el DataTable al DataGridView
                    dgVentas.DataSource = dtVentas;

                    // No ocultamos ninguna columna (se mostrarán ID_Venta, ID_Tutor, ID_Usuario, Fecha_Venta y Subtotal)

                    // Opcional: Ajustar ancho o formato de columnas
                    dgVentas.Columns["Fecha_Venta"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                    dgVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las ventas: " + ex.Message);
            }
        }

        public void buscarProducto(DataGridView tablaTotalProductos, TextBox textoBuscar)
        {
            Conexion.Conexion objetoConexion = new Conexion.Conexion();
            Modelos.ModeloProductos objetoProducto = new Modelos.ModeloProductos();

            DataTable modelo = new DataTable();

            modelo.Columns.Add("ID", typeof(int));
            modelo.Columns.Add("Nombre", typeof(string));
            modelo.Columns.Add("Descripción", typeof(string));
            modelo.Columns.Add("Precio", typeof(float));
            //modelo.Columns.Add("Costo", typeof(float));
            modelo.Columns.Add("Existencia", typeof(int));
            modelo.Columns.Add("Medida", typeof(string));
            modelo.Columns.Add("Caducidad", typeof(DateTime));
            //modelo.Columns.Add("Proveedor", typeof(string));
            //modelo.Columns.Add("Categoria", typeof(string));

            // Ocultar columnas
            //modelo.Columns.Add("id_proveedor", typeof(int));
            //modelo.Columns.Add("id_categoria", typeof(int));

            tablaTotalProductos.DataSource = modelo;

            try
            {
                if(textoBuscar.Text == "")
                {
                    string sql = @"SELECT p.id_producto, p.nombre, p.descripcion, p.precio, p.costo, p.existencia, 
                          p.unidad_medida, p.fecha_caducidad, 
                          pr.nombre AS nombre_proveedor, pr.id_proveedor,
                          c.nombre AS nombre_categoria, c.id_categoria
                   FROM productos p 
                   INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor 
                   INNER JOIN categorias c ON p.id_categoria = c.id_categoria";

                    MySqlConnection conexion = objetoConexion.establecerConexion();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataSet ds = new DataSet();
                    adaptador.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        modelo.Rows.Add(
                                Convert.ToInt32(row["id_producto"]),
                                row["nombre"].ToString(),
                                row["descripcion"].ToString(),
                                Convert.ToSingle(row["precio"]),
                                //Convert.ToSingle(row["costo"]),
                                Convert.ToInt32(row["existencia"]),
                                row["unidad_medida"].ToString(),
                                Convert.ToDateTime(row["fecha_caducidad"])
                        //row["nombre_proveedor"].ToString(),
                        //row["nombre_categoria"].ToString(),
                        //Convert.ToInt32(row["id_proveedor"]),
                        //Convert.ToInt32(row["id_categoria"])
                        );
                        tablaTotalProductos.DataSource = modelo;
                        tablaTotalProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                }
                else
                {
                    string sql = @"SELECT p.id_producto, p.nombre, p.descripcion, p.precio, p.costo, p.existencia, 
                          p.unidad_medida, p.fecha_caducidad, 
                          pr.nombre AS nombre_proveedor, pr.id_proveedor,
                          c.nombre AS nombre_categoria, c.id_categoria
                   FROM productos p 
                   INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor 
                   INNER JOIN categorias c ON p.id_categoria = c.id_categoria where p.nombre LIKE concat('%',@nombre,'%')";

                    MySqlConnection conexion = objetoConexion.establecerConexion();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.Parameters.AddWithValue("@nombre", textoBuscar.Text);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataSet ds = new DataSet();
                    adaptador.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        modelo.Rows.Add(
                                Convert.ToInt32(row["id_producto"]),
                                row["nombre"].ToString(),
                                row["descripcion"].ToString(),
                                Convert.ToSingle(row["precio"]),
                                //Convert.ToSingle(row["costo"]),
                                Convert.ToInt32(row["existencia"]),
                                row["unidad_medida"].ToString(),
                                Convert.ToDateTime(row["fecha_caducidad"])
                        //row["nombre_proveedor"].ToString(),
                        //row["nombre_categoria"].ToString(),
                        //Convert.ToInt32(row["id_proveedor"]),
                        //Convert.ToInt32(row["id_categoria"])
                        );
                        tablaTotalProductos.DataSource = modelo;
                        tablaTotalProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }

                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }
        }

        public void seleccionarProductoVenta(DataGridView tablaProductos, TextBox id, TextBox nombre, TextBox precioProducto, TextBox stock, TextBox PrecioFinal)
        {
            int fila = tablaProductos.CurrentCell.RowIndex;

            try
            {
                id.Text = tablaProductos.Rows[fila].Cells[0].Value.ToString();
                nombre.Text = tablaProductos.Rows[fila].Cells[1].Value.ToString();
                precioProducto.Text = tablaProductos.Rows[fila].Cells[3].Value.ToString();
                stock.Text = tablaProductos.Rows[fila].Cells[4].Value.ToString();
                PrecioFinal.Text = tablaProductos.Rows[fila].Cells[3].Value.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buscarTutor(DataGridView tablaTotalTutores, TextBox textoBuscar)
        {
            Conexion.Conexion objetoConexion = new Conexion.Conexion();
            Modelos.ModeloTutores objetoTutor = new Modelos.ModeloTutores();

            DataTable modelo = new DataTable();

            modelo.Columns.Add("ID", typeof(int));
            modelo.Columns.Add("Nombre", typeof(string));
            modelo.Columns.Add("Dirección", typeof(string));
            modelo.Columns.Add("Teléfono", typeof(string));

            tablaTotalTutores.DataSource = modelo;

            try
            {
                if (textoBuscar.Text == "")
                {
                    string sql = @"
                SELECT 
                    id_tutor, 
                    nombre, 
                    direccion, 
                    telefono 
                FROM tutores";

                    MySqlConnection conexion = objetoConexion.establecerConexion();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataSet ds = new DataSet();
                    adaptador.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        modelo.Rows.Add(
                            Convert.ToInt32(row["id_tutor"]),
                            row["nombre"].ToString(),
                            row["direccion"].ToString(),
                            row["telefono"].ToString()
                        );

                        tablaTotalTutores.DataSource = modelo;
                        tablaTotalTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                else
                {
                    string sql = @"
                SELECT 
                    id_tutor, 
                    nombre, 
                    direccion, 
                    telefono 
                FROM tutores
                WHERE nombre LIKE CONCAT('%', @nombre, '%')";

                    MySqlConnection conexion = objetoConexion.establecerConexion();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.Parameters.AddWithValue("@nombre", textoBuscar.Text);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataSet ds = new DataSet();
                    adaptador.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        modelo.Rows.Add(
                            Convert.ToInt32(row["id_tutor"]),
                            row["nombre"].ToString(),
                            row["direccion"].ToString(),
                            row["telefono"].ToString()
                        );

                        tablaTotalTutores.DataSource = modelo;
                        tablaTotalTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el tutor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }
        }

        public void seleccionarTutorVenta(DataGridView tablaTutores, TextBox id, TextBox nombre, TextBox direccion, TextBox telefono)
        {
            int fila = tablaTutores.CurrentCell.RowIndex;

            try
            {
                id.Text = tablaTutores.Rows[fila].Cells[0].Value.ToString();
                nombre.Text = tablaTutores.Rows[fila].Cells[1].Value.ToString();
                direccion.Text = tablaTutores.Rows[fila].Cells[2].Value.ToString();
                telefono.Text = tablaTutores.Rows[fila].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el tutor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void pasarProductosVenta(DataGridView tablaResumen, TextBox idProducto, TextBox nombreProducto, TextBox precioProducto, TextBox cantidadVenta, TextBox stock)
        {
            try
            {
                DataTable modelo = (DataTable)tablaResumen.DataSource;

            if(modelo == null)
            {
                    modelo = new DataTable();
                    modelo.Columns.Add("ID", typeof(string));
                modelo.Columns.Add("Nombre", typeof(string));
                modelo.Columns.Add("Precio", typeof(double));
                modelo.Columns.Add("Cantidad", typeof(int));
                modelo.Columns.Add("Subtotal", typeof(double));
                tablaResumen.DataSource = modelo;
            }

            int stockDisponible = int.Parse(stock.Text);
            string idProductoText = idProducto.Text;

            foreach (DataRow row in modelo.Rows)
            {
                string idExistente = (string)row["ID"];

                if(idExistente.Equals(idProductoText))
                {
                    MessageBox.Show("El producto ya está en la lista de venta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            string nProducto = nombreProducto.Text;
            double precioUnitario = double.Parse(precioProducto.Text);
            int candidad = int.Parse(cantidadVenta.Text);

            if (candidad> stockDisponible)
            {
                MessageBox.Show("No hay suficiente stock disponible para este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double subtotal = precioUnitario * candidad;

            modelo.Rows.Add(
                int.Parse(idProductoText),
                nProducto,
                precioUnitario,
                candidad,
                subtotal
            );
            
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos registrados: " + ex.Message);
            }
        }

        public void eliminarProductoSeleccionado(DataGridView tablaResumen)
        {
            try
            {

                int indiceSeleccionado = tablaResumen.CurrentRow.Index;
                if (indiceSeleccionado >= 0)
                {
                    tablaResumen.Rows.RemoveAt(indiceSeleccionado);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto seleccionado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void calcularTotalPagar(DataGridView tablaResuemn, Label IVA, Label totalPagar)
        {
            double totalSubtotal = 0;
            double iva = 0.16;
            double totalIVA = 0;

            NumberFormatInfo formato = new NumberFormatInfo();
            formato.NumberDecimalDigits = 2;

            foreach (DataGridViewRow row in tablaResuemn.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    totalSubtotal += Convert.ToDouble(row.Cells[4].Value);
                }
            }

            totalIVA = totalSubtotal * iva;

            totalPagar.Text = totalSubtotal.ToString("N", formato);
            IVA.Text = totalIVA.ToString("N", formato);
        }

        public void crearFactura(int? idTutor, int idUsuario)
        {

            Conexion.Conexion objetoConexion = new Conexion.Conexion();


            string consulta = @"INSERT INTO ventas (fecha_venta, id_tutor, id_usuario) VALUES (NOW(), @tutor, @usuario);";

            try
            {
                using (MySqlConnection conn = objetoConexion.establecerConexion())
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {

                    if (idTutor != 0)
                        cmd.Parameters.AddWithValue("@tutor", idTutor.Value);
                    else
                        cmd.Parameters.AddWithValue("@tutor", DBNull.Value);


                    cmd.Parameters.AddWithValue("@usuario", idUsuario);


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("La venta se guardó correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la venta: " + ex.Message);
            }
        }

        public void realizarVenta(DataGridView tablaResumenVenta)
        {

            Conexion.Conexion objetoConexion = new Conexion.Conexion();


            string consultaDetalle = @"INSERT INTO detalle_ventas (id_venta, id_producto, cantidad, precio_venta) VALUES ((SELECT max(id_venta) FROM ventas), @producto, @cantidad, @precio)";
            string consultaStock = @"UPDATE productos SET existencia = existencia - @cantidad where id_producto = @producto";
            try
            {
                MySqlConnection conn = objetoConexion.establecerConexion();
                MySqlCommand cmdDetalle = new MySqlCommand(consultaDetalle, conn);
                MySqlCommand cmdStock = new MySqlCommand(consultaStock, conn);

                foreach (DataGridViewRow row in tablaResumenVenta.Rows)
                {
                    if (row.Cells[0].Value !=null)
                    {
                        int idProducto = Convert.ToInt32(row.Cells[0].Value);
                        int cantidad = Convert.ToInt32(row.Cells[3].Value);
                        double precioVenta = Convert.ToDouble(row.Cells[2].Value);

                        cmdDetalle.Parameters.Clear();
                        cmdDetalle.Parameters.AddWithValue("producto", idProducto);
                        cmdDetalle.Parameters.AddWithValue("cantidad", cantidad);
                        cmdDetalle.Parameters.AddWithValue("precio", precioVenta);
                        cmdDetalle.ExecuteNonQuery();

                        cmdStock.Parameters.Clear();
                        cmdStock.Parameters.AddWithValue("cantidad", cantidad);
                        cmdStock.Parameters.AddWithValue("producto", idProducto);
                        cmdStock.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta realizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la venta: " + ex.Message);
            }
        }

        public void limpiarCampos(
    TextBox idProducto, TextBox nombreProducto, TextBox precioProducto, TextBox stock, TextBox precioFinal,
    TextBox idTutor, TextBox nombreTutor, TextBox direccion, TextBox telefono,
    TextBox cantidadVenta,
    DataGridView tablaTotalProductos, DataGridView tablaTotalTutores, DataGridView tablaResumenVenta,
    Label IVA, Label totalPagar,
    TextBox textoBuscarProducto = null, TextBox textoBuscarTutor = null)
        {
            // Limpiar campos de producto
            idProducto.Clear();
            nombreProducto.Clear();
            precioProducto.Clear();
            stock.Clear();
            precioFinal.Clear();
            cantidadVenta.Clear();

            // Restaurar estado del precio final
            precioFinal.ReadOnly = true;
            precioFinal.BackColor = Color.Gray;

            // Limpiar campos de tutor
            idTutor.Clear();
            nombreTutor.Clear();
            direccion.Clear();
            telefono.Clear();

            // Limpiar tablas de datos
            tablaTotalProductos.DataSource = null;
            tablaTotalTutores.DataSource = null;

            // Reiniciar tabla de resumen de venta
            DataTable dtResumen = new DataTable();
            dtResumen.Columns.Add("ID", typeof(int));
            dtResumen.Columns.Add("Nombre", typeof(string));
            dtResumen.Columns.Add("Precio", typeof(double));
            dtResumen.Columns.Add("Cantidad", typeof(int));
            dtResumen.Columns.Add("Subtotal", typeof(double));
            tablaResumenVenta.DataSource = dtResumen;

            // Reiniciar totales
            IVA.Text = "0.00";
            totalPagar.Text = "0.00";

            // Limpiar campos de búsqueda
            if (textoBuscarProducto != null) textoBuscarProducto.Clear();
            if (textoBuscarTutor != null) textoBuscarTutor.Clear();
        }
    }
}
