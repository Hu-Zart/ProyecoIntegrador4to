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
    public partial class FormTutores: Form
    {
        public FormTutores()
        {
            InitializeComponent(); 
            cargarDatos();
        }
        public void cargarDatos()
        {
            Controladores.ControladorTutores objetoControlador = new Controladores.ControladorTutores();
            objetoControlador.consultarTutores(dgConsultas);
        }

        public void datosFormulario(Modelos.ModeloTutores objetoTutor)
        {
            objetoTutor.Nombre = tbNombre.Text;
            objetoTutor.Direccion = tbDireccion.Text;
            objetoTutor.Telefono = tbTelefono.Text;
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
            if (string.IsNullOrEmpty(tbTelefono.Text))
            {
                MessageBox.Show("El teléfono es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Modelos.ModeloTutores datosTutor = new Modelos.ModeloTutores();
                datosFormulario(datosTutor);
                Controladores.ControladorTutores objetoControlador = new Controladores.ControladorTutores();
                objetoControlador.agregarTutor(datosTutor);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tutor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int idTutor;

        public void llenarCampos(Modelos.ModeloTutores tutor)
        {
            if (tutor != null) return;
            
            tbNombre.Text = tutor.Nombre;
            tbDireccion.Text = tutor.Direccion;
            tbTelefono.Text = tutor.Telefono;
            idTutor = tutor.IdTutor;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Modelos.ModeloTutores objetoTutor = new Modelos.ModeloTutores();
                objetoTutor.IdTutor = idTutor;
                objetoTutor.Nombre = tbNombre.Text;
                objetoTutor.Direccion = tbDireccion.Text;
                objetoTutor.Telefono = tbTelefono.Text;

                Controladores.ControladorTutores objetoControlador = new Controladores.ControladorTutores();
                objetoControlador.actualizarTutor(objetoTutor);

                cargarDatos();
            }
        }

        private void dgTutores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgConsultas.Rows[e.RowIndex];

            idTutor = Convert.ToInt32(fila.Cells["ID"].Value);
            string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";
            string direccion = fila.Cells["Dirección"].Value?.ToString() ?? "";
            string telefono = fila.Cells["Telefono"].Value?.ToString() ?? "";

            tbNombre.Text = nombre;
            tbDireccion.Text = direccion;
            tbTelefono.Text = telefono;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgConsultas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgConsultas.SelectedRows[0];
                int idTutor = Convert.ToInt32(row.Cells["ID"].Value);
                string nombreTutor = row.Cells["Nombre"].Value?.ToString() ?? "";

                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar al tutor '{nombreTutor}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Controladores.ControladorTutores objetoControlador = new Controladores.ControladorTutores();
                    objetoControlador.eliminarTutor(idTutor);
                    cargarDatos();

                    tbNombre.Clear();
                    tbDireccion.Clear();
                    tbTelefono.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tutor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
