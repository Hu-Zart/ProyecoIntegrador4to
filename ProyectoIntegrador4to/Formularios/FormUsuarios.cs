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
    public partial class FormUsuarios : Form
    {
        public static int idUsuario;

        public FormUsuarios()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            Controladores.ControladorUsuarios objetoControlador = new Controladores.ControladorUsuarios();
            objetoControlador.consultarUsuarios(dgUsuarios);
        }

        private void datosFormulario(Modelos.ModeloUsuarios objetoUsuario)
        {
            objetoUsuario.Nombre = tbNombre.Text;
            objetoUsuario.FechaRegistro = dtpRegistro.Value;
            objetoUsuario.Direccion = tbDireccion.Text;
            objetoUsuario.PermisoInventario = cbInventario.Checked;
            objetoUsuario.PermisoRegistro = cbAdministrar.Checked;
            objetoUsuario.PermisoVeterinario = cbConsulta.Checked;
            objetoUsuario.PermisoVenta = cbVentas.Checked;
            objetoUsuario.Telefono = tbTelefono.Text;
            objetoUsuario.Contrasena = tbContrasena.Text;
        }

        private bool validarCampos()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbDireccion.Text))
            {
                MessageBox.Show("La dirección es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            // La fecha de registro siempre estará presente (Value de DateTimePicker)
            if (!cbInventario.Checked && !cbAdministrar.Checked && !cbConsulta.Checked && !cbVentas.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbTelefono.Text))
            {
                MessageBox.Show("El teléfono es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbContrasena.Text))
            {
                MessageBox.Show("La contraseña es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            return valido;
        }

       

        private void btEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        

        private void LimpiarFormulario()
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            dtpRegistro.Value = DateTime.Now;
            cbInventario.Checked = false;
            cbAdministrar.Checked = false;
            cbConsulta.Checked = false;
            cbVentas.Checked = false;
            tbTelefono.Clear();
            tbContrasena.Clear();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgUsuarios_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgUsuarios.Rows[e.RowIndex];

            // Almacenar ID del usuario seleccionado
            idUsuario = Convert.ToInt32(fila.Cells["ID"].Value);

            // Cargar datos en los controles
            tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
            dtpRegistro.Value = Convert.ToDateTime(fila.Cells["Fecha Ingreso"].Value);
            tbDireccion.Text = fila.Cells["Dirección"].Value.ToString();
            cbInventario.Checked = Convert.ToBoolean(fila.Cells["Priv. Inventario"].Value);
            cbAdministrar.Checked = Convert.ToBoolean(fila.Cells["Priv. Administrativo"].Value);
            cbConsulta.Checked = Convert.ToBoolean(fila.Cells["Priv. Veterinario"].Value);
            cbVentas.Checked = Convert.ToBoolean(fila.Cells["Priv. Venta"].Value);
            tbTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            tbContrasena.Text = fila.Cells["Contraseña"].Value.ToString();
        }

        private void btAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validarCampos())
                    return;

                Modelos.ModeloUsuarios datosUsuario = new Modelos.ModeloUsuarios();
                datosFormulario(datosUsuario);

                Controladores.ControladorUsuarios objetoControlador = new Controladores.ControladorUsuarios();
                objetoControlador.agregarUsuario(datosUsuario);
                cargarDatos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validarCampos())
                    return;

                Modelos.ModeloUsuarios objetoUsuario = new Modelos.ModeloUsuarios();
                objetoUsuario.IdUsuario = idUsuario;
                datosFormulario(objetoUsuario);

                Controladores.ControladorUsuarios controlador = new Controladores.ControladorUsuarios();
                controlador.actualizarUsuario(objetoUsuario);

                cargarDatos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgUsuarios.SelectedRows[0];
                int idUsuarioEliminar = Convert.ToInt32(row.Cells["ID"].Value);
                string nombreUsuario = row.Cells["Nombre"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar al usuario {nombreUsuario}?",
                    "Eliminar Usuario",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    Controladores.ControladorUsuarios controlador = new Controladores.ControladorUsuarios();
                    controlador.eliminarUsuario(idUsuarioEliminar);
                    cargarDatos();
                    LimpiarFormulario();
                }
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un usuario para eliminar",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
