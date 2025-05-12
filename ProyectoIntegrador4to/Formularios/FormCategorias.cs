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
    public partial class FormCategorias: Form
    {
        public FormCategorias()
        {
            InitializeComponent();
            cargarDatos();
            
        }

        public void cargarDatos()
        {
            Controladores.ControladorCategorias objetoControlador = new Controladores.ControladorCategorias();
            objetoControlador.consultarCategorias(dgCategorias);
        }

        public void datosFormulario(Modelos.ModeloCategorias objetoCategoria)
        {
            objetoCategoria.Nombre = tbNombre.Text;
            objetoCategoria.Descripcion = tbDescripcion.Text;
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

            return valido;

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarCampos())
                    return;

                Modelos.ModeloCategorias datosCategoria = new Modelos.ModeloCategorias();
                datosFormulario(datosCategoria);

                Controladores.ControladorCategorias controladorCategoria = new Controladores.ControladorCategorias();
                controladorCategoria.agregarCategoria(datosCategoria);

                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message);
            }
        }

        public static int idCategoria;

        public void llenarCampos(Modelos.ModeloCategorias categoria)
        {
            if (categoria != null) return;

            tbNombre.Text = categoria.Nombre;
            tbDescripcion.Text = categoria.Descripcion;
            idCategoria = categoria.IdCategoria;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Modelos.ModeloCategorias objetoCategoria = new Modelos.ModeloCategorias();
                objetoCategoria.IdCategoria = idCategoria;
                objetoCategoria.Nombre = tbNombre.Text;
                objetoCategoria.Descripcion = tbDescripcion.Text;

                Controladores.ControladorCategorias controladorCategoria = new Controladores.ControladorCategorias();
                controladorCategoria.actualizarCategoria(objetoCategoria);

                cargarDatos();
            }
        }

        private void dgCategorias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgCategorias.Rows[e.RowIndex];

            idCategoria = Convert.ToInt32(fila.Cells["ID"].Value);
            string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";
            string descripcion = fila.Cells["Descripción"].Value?.ToString() ?? "";

            tbNombre.Text = nombre;
            tbDescripcion.Text = descripcion; ;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(dgCategorias.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgCategorias.SelectedRows[0];
                int idCategoria = Convert.ToInt32(row.Cells["ID"].Value);
                string nombreCategoria = row.Cells["Nombre"].Value.ToString();

                DialogResult respuesta= MessageBox.Show(
                    $"¿Está seguro de eliminar la categoría '{nombreCategoria}'?",
                    "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    Controladores.ControladorCategorias controladorCategoria = new Controladores.ControladorCategorias();
                    controladorCategoria.eliminarCategoria(idCategoria);
                    cargarDatos();

                    tbNombre.Clear();
                    tbDescripcion.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
