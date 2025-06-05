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
    public partial class FormProveedores: Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            Controladores.ControladorProveedoes objetoControlador = new Controladores.ControladorProveedoes();
            objetoControlador.consultarProveedores(dgProveedores);
        }

        public void datosFormulario(Modelos.ModeloProveedores objetoProveedor)
        {
            objetoProveedor.Nombre = tbNombre.Text;
            objetoProveedor.Contacto = tbContacto.Text;
            objetoProveedor.Telefono = tbTelefono.Text;
            objetoProveedor.Direccion = tbDireccion.Text;
            objetoProveedor.Email = tbEmail.Text;
        }

        private bool validarCampos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbContacto.Text))
            {
                MessageBox.Show("El contacto es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbTelefono.Text))
            {
                MessageBox.Show("El teléfono es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbDireccion.Text))
            {
                MessageBox.Show("La dirección es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("El email es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            return valido;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarCampos())
                    return;
                Modelos.ModeloProveedores datosProveedor = new Modelos.ModeloProveedores();
                datosFormulario(datosProveedor);
                Controladores.ControladorProveedoes objetoControlador = new Controladores.ControladorProveedoes();
                objetoControlador.agregarProveedor(datosProveedor);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el proveedor: " + ex.Message);
            }
        }

        public static int idPorveedor;

        public void llenarCampos(Modelos.ModeloProveedores proveedor)
        {
            if(proveedor != null)
            {
                tbNombre.Text = proveedor.Nombre;
                tbContacto.Text = proveedor.Contacto;
                tbTelefono.Text = proveedor.Telefono;
                tbDireccion.Text = proveedor.Direccion;
                tbEmail.Text = proveedor.Email;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Modelos.ModeloProveedores objetoProveedor = new Modelos.ModeloProveedores();
                objetoProveedor.IdProveedor = idPorveedor;
                objetoProveedor.Nombre = tbNombre.Text;
                objetoProveedor.Contacto = tbContacto.Text;
                objetoProveedor.Telefono = tbTelefono.Text;
                objetoProveedor.Direccion = tbDireccion.Text;
                objetoProveedor.Email = tbEmail.Text;

                Controladores.ControladorProveedoes controladorProveedor = new Controladores.ControladorProveedoes();
                controladorProveedor.actualizarProveedor(objetoProveedor);

                cargarDatos();
            }
        }

        private void dgProveedores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex < 0) return; 

            var fila = dgProveedores.Rows[e.RowIndex];

            idPorveedor = Convert.ToInt32(fila.Cells[0].Value);
            tbNombre.Text = fila.Cells[1].Value.ToString();
            tbContacto.Text = fila.Cells[2].Value.ToString();
            tbTelefono.Text = fila.Cells[3].Value.ToString();
            tbDireccion.Text = fila.Cells[4].Value.ToString();
            tbEmail.Text = fila.Cells[5].Value.ToString();

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(dgProveedores.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgProveedores.SelectedRows[0];
                int idProveedor = Convert.ToInt32(row.Cells["ID"].Value);
                string nombreProveedor = row.Cells["Nombre"].Value.ToString();

                DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el proveedor {nombreProveedor}?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    Controladores.ControladorProveedoes objetoControlador = new Controladores.ControladorProveedoes();
                    objetoControlador.eliminarProveedor(idProveedor);
                    cargarDatos();

                    tbNombre.Clear();
                    tbContacto.Clear();
                    tbTelefono.Clear();
                    tbDireccion.Clear();
                    tbEmail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
