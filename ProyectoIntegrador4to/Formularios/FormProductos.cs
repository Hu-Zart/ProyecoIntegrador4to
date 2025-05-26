
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to
{
    public partial class FormProductos: Form
    {
        public FormProductos()
        {
            InitializeComponent();
            Controladores.ControladorProductos controladorProveedore = new Controladores.ControladorProductos();
            Controladores.ControladorProductos controladorCategoria = new Controladores.ControladorProductos();

            controladorProveedore.consultaProveedores(cbProveedores);
            controladorCategoria.consultaCategorias(cbCategorias);
            cargarDatos();
        }

        public void cargarDatos()
        {
            Controladores.ControladorProductos objetoControlador = new Controladores.ControladorProductos();
            objetoControlador.consultarProductos(dgProductos);
        }

        public void datosFormulario(Modelos.ModeloProductos objetoProducto)
        {
            objetoProducto.Nombre = tbNombre.Text;
            objetoProducto.Descripcion = tbDescripcion.Text;
            objetoProducto.Precio = (float)numPrecio.Value;
            objetoProducto.Costo = (float)numCosto.Value;
            objetoProducto.Existencia = (int)numExistencia.Value;
            objetoProducto.Unidad_medida = tbMedida.Text;
            objetoProducto.Fecha_caducidad = dtpCaducidad.Value;
            objetoProducto.Proveedor = cbProveedores.SelectedValue.ToString();
            objetoProducto.Categoria = cbCategorias.SelectedValue.ToString();
        }

        private bool validarCampos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbDescripcion.Text))
            {
                MessageBox.Show("La descripción es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (numPrecio.Value <= 0)
            {
                MessageBox.Show("El precio es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (numCosto.Value <= 0)
            {
                MessageBox.Show("La cantidad es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if(numExistencia.Value <= 0)
            {
                MessageBox.Show("La existencia es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if(string.IsNullOrEmpty(tbMedida.Text))
            {
                MessageBox.Show("La medida es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if(string.IsNullOrEmpty(dtpCaducidad.Text))
            {
                MessageBox.Show("La caducidad es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if(string.IsNullOrEmpty(cbProveedores.Text))
            {
                MessageBox.Show("El proveedor es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(cbCategorias.Text))
            {
                MessageBox.Show("La categoria es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            return valido;
        }

        private void Form4Inventario_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!validarCampos())
                    return;
                Modelos.ModeloProductos datosProducto = new Modelos.ModeloProductos();
                datosFormulario(datosProducto);
                Controladores.ControladorProductos objetoControlador = new Controladores.ControladorProductos();
                objetoControlador.agregarProducto(datosProducto);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int idProducto;

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Modelos.ModeloProductos objetoProducto = new Modelos.ModeloProductos();
                objetoProducto.IdProducto = idProducto;
                objetoProducto.Nombre = tbNombre.Text;
                objetoProducto.Descripcion = tbDescripcion.Text;
                objetoProducto.Precio = (float)numPrecio.Value;
                objetoProducto.Costo = (float)numCosto.Value;
                objetoProducto.Existencia = (int)numExistencia.Value;
                objetoProducto.Unidad_medida = tbMedida.Text;
                objetoProducto.Fecha_caducidad = dtpCaducidad.Value;
                objetoProducto.Proveedor = cbProveedores.SelectedValue.ToString();
                objetoProducto.Categoria = cbCategorias.SelectedValue.ToString();

                Controladores.ControladorProductos controladorProducto = new Controladores.ControladorProductos();
                controladorProducto.actualizarProducto(objetoProducto);

                cargarDatos();
            }
        }

        private void dgProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex < 0) return; // Verifica si la fila es válida

            var fila = dgProductos.Rows[e.RowIndex];

            idProducto = Convert.ToInt32(fila.Cells[0].Value);
            tbNombre.Text = fila.Cells[1].Value.ToString();
            tbDescripcion.Text = fila.Cells[2].Value.ToString();
            numPrecio.Value = Convert.ToDecimal(fila.Cells[3].Value);
            numCosto.Value = Convert.ToDecimal(fila.Cells[4].Value);
            numExistencia.Value = Convert.ToDecimal(fila.Cells[5].Value);
            tbMedida.Text = fila.Cells[6].Value.ToString();
            dtpCaducidad.Value = Convert.ToDateTime(fila.Cells[7].Value);
            SeleccionarItemPorValor(cbProveedores, fila.Cells[8].Value.ToString());
            SeleccionarItemPorValor(cbCategorias, fila.Cells[9].Value.ToString());

            
        }

        private void SeleccionarItemPorValor(ComboBox comboBox, string valor)
        {
            foreach(DataRowView item in comboBox.Items)
            {
                if (item.Row.ItemArray[0].ToString() == valor)
                {
                    comboBox.SelectedItem = item;
                    return;
                }
            }
            comboBox.SelectedIndex = -1; // Si no se encuentra el valor, deselecciona el ComboBox   
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(dgProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgProductos.SelectedRows[0];
                int idProducto = Convert.ToInt32(row.Cells[0].Value);
                string nombreProducto = row.Cells[1].Value.ToString();

                DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el producto {nombreProducto}?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(resultado == DialogResult.Yes)
                {
                    Controladores.ControladorProductos controladorProducto = new Controladores.ControladorProductos();
                    controladorProducto.eliminarProducto(idProducto);
                    cargarDatos();

                    tbNombre.Clear();
                    tbDescripcion.Clear();
                    numPrecio.Value = 0;
                    numCosto.Value = 0;
                    numExistencia.Value = 0;
                    tbMedida.Clear(); dtpCaducidad.Value = DateTime.Now;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
