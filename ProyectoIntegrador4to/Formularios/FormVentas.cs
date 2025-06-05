using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Formularios
{
    public partial class FormVentas: Form
    {
        public Modelos.ModeloUsuarios UsuarioActual { get; private set; }

        public int idCliente = 0;
        public FormVentas(Modelos.ModeloUsuarios usuarioActual)
        {
            UsuarioActual = usuarioActual;
            InitializeComponent();
            Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();
            objetoVenta.buscarProducto(dtgProductos, txtBuscarProductos);
            objetoVenta.buscarTutor(dgbClientes, txtBuscarCliente);

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();
            objetoVenta.buscarTutor(dgbClientes, txtBuscarCliente);

        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();
            objetoVenta.buscarProducto(dtgProductos, txtBuscarProductos);
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();
            objetoVenta.seleccionarProductoVenta(dtgProductos, txtIdProducto, txtNombreProducto, txtPrecioProducto, txtStockProducto, txtPrecioVentaFinal);
        }

        private void dgbClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();
            objetoVenta.seleccionarTutorVenta(dgbClientes, txtIdCliente, txtNombreCliente, txtDireccion, txtTelefono);
            idCliente = int.Parse(txtIdCliente.Text);
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtPrecioVentaFinal.ReadOnly = false;
            txtPrecioVentaFinal.BackColor = Color.White;
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            txtPrecioVentaFinal.ReadOnly = true;
            txtPrecioVentaFinal.BackColor = Color.Gray;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dtgProductos.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCantidadVenta.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();
                objetoVenta.pasarProductosVenta(dtgResumenVenta, txtIdProducto, txtNombreProducto, txtPrecioVentaFinal, txtCantidadVenta, txtStockProducto);
                objetoVenta.calcularTotalPagar(dtgResumenVenta, lblIva, lblTotalPagar);
            }

        }

        private void btnElimnarSeleccionProducto_Click(object sender, EventArgs e)
        {
            Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();
            objetoVenta.eliminarProductoSeleccionado(dtgResumenVenta);
            objetoVenta.calcularTotalPagar(dtgResumenVenta, lblIva, lblTotalPagar);

        }

        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            Controladores.ControladorVentas objetoVenta = new Controladores.ControladorVentas();

            int idTutorConvertido;
            // Intentamos convertir; si falla (cadena vacía o no-numérica), asignamos 0
            if (!int.TryParse(txtIdCliente.Text.Trim(), out idTutorConvertido))
            {
                idTutorConvertido = 0;
            }

            // Ahora sí llamamos al método sin que int.Parse dé excepción
            objetoVenta.crearFactura(idTutorConvertido, UsuarioActual.IdUsuario);
            objetoVenta.realizarVenta(dtgResumenVenta);
            objetoVenta.limpiarCampos(
        txtIdProducto, txtNombreProducto, txtPrecioProducto, txtStockProducto, txtPrecioVentaFinal,
        txtIdCliente, txtNombreCliente, txtDireccion, txtTelefono,
        txtCantidadVenta,  // Nuevo parámetro agregado
        dtgProductos, dgbClientes, dtgResumenVenta,
        lblIva, lblTotalPagar,
        txtBuscarProductos, txtBuscarCliente
    );
            objetoVenta.buscarProducto(dtgProductos, txtBuscarProductos);
            objetoVenta.buscarTutor(dgbClientes, txtBuscarCliente);
        }
    }
}
