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
    public partial class FormPacientes : Form
    {

        public static int idPaciente;
        public FormPacientes()
        {
            InitializeComponent();
            Controladores.ControladorPacientes controladorEspecie = new Controladores.ControladorPacientes();

            controladorEspecie.consultaEspecies(cbEspecies);
            controladorEspecie.consultaCondicionesCorporales(cbCondicion);
            controladorEspecie.consultaTutores(cbTutores);
            cargarDatos();
        }

        public void cargarDatos()
        {
            Controladores.ControladorPacientes objetoControlador = new Controladores.ControladorPacientes();
            objetoControlador.consultarPacientes(dgPacientes);
        }

        public void datosFormulario(Modelos.ModeloPacientes objetoPaciente)
        {
            objetoPaciente.Nombre = tbNombre.Text;
            //objetoPaciente.Especie = cbEspecies.SelectedValue.ToString();
            objetoPaciente.Especie = ((DataRowView)cbEspecies.SelectedItem)["Id"].ToString();
            objetoPaciente.Raza = tbRaza.Text;
            objetoPaciente.Sexo = cbSexo.SelectedItem == "Macho" ? true : false;
            objetoPaciente.SeñasParticulares = tbDescripcion.Text;
            objetoPaciente.Peso = (float)numPeso.Value;
            objetoPaciente.FechaNacimiento = dtpNacimiento.Value;
            objetoPaciente.CondicionCorporal = ((DataRowView)cbCondicion.SelectedItem)["Id"].ToString();
            //objetoPaciente.CondicionCorporal = ((DataRowView)cbCondicion.SelectedItem)["ID"].ToString();
            objetoPaciente.Tutor = ((DataRowView)cbTutores.SelectedItem)["Id"].ToString();
            //objetoPaciente.Tutor = ((DataRowView)cbTutores.SelectedItem)["ID"].ToString();
            objetoPaciente.Esterilizado = cbReproductividad.SelectedItem == "Esterilizado" ? true : false;
        }

        private bool validarCampos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(cbEspecies.Text))
            {
                MessageBox.Show("La especie es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbRaza.Text))
            {
                MessageBox.Show("La raza es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(cbSexo.Text))
            {
                MessageBox.Show("El sexo es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbDescripcion.Text))
            {
                MessageBox.Show("La descripción es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (numPeso.Value <= 0)
            {
                MessageBox.Show("El peso debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(cbCondicion.Text))
            {
                MessageBox.Show("La condición corporal es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(cbTutores.Text))
            {
                MessageBox.Show("El tutor es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(cbReproductividad.Text))
            {
                MessageBox.Show("La reproductividad es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            return valido;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!validarCampos())
                    return;

                Modelos.ModeloPacientes datosPaciente = new Modelos.ModeloPacientes();
                datosFormulario(datosPaciente);

                Controladores.ControladorPacientes objetoControlador = new Controladores.ControladorPacientes();
                objetoControlador.agregarPaciente(datosPaciente);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarCampos())
                    return;

                Modelos.ModeloPacientes objetoPaciente = new Modelos.ModeloPacientes();
                objetoPaciente.IdPaciente = idPaciente;
                datosFormulario(objetoPaciente);

                Controladores.ControladorPacientes controlador = new Controladores.ControladorPacientes();
                controlador.actualizarPaciente(objetoPaciente);

                cargarDatos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgPacientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgPacientes.Rows[e.RowIndex];

            // Almacenar ID del paciente seleccionado
            idPaciente = Convert.ToInt32(fila.Cells["ID"].Value);

            // Cargar datos en los controles
            tbNombre.Text = fila.Cells["nombre"].Value.ToString();
            tbRaza.Text = fila.Cells["raza"].Value.ToString();
            tbDescripcion.Text = fila.Cells["Señas Particulares"].Value?.ToString() ?? "";
            numPeso.Value = Convert.ToDecimal(fila.Cells["peso"].Value);
            dtpNacimiento.Value = Convert.ToDateTime(fila.Cells["fecha nacimiento"].Value);

            // Cargar ComboBoxes usando ValueMember
            cbEspecies.SelectedValue = Convert.ToInt32(fila.Cells["id_especie"].Value);
            cbCondicion.SelectedValue = Convert.ToInt32(fila.Cells["id_condicionCorporal"].Value);
            cbTutores.SelectedValue = Convert.ToInt32(fila.Cells["id_tutor"].Value);

            // Cargar valores booleanos
           
            cbSexo.SelectedItem = fila.Cells["sexo"].Value.ToString();


            cbReproductividad.SelectedItem = fila.Cells["reproductividad"].Value.ToString();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgPacientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPacientes.SelectedRows[0];
                int idPaciente = Convert.ToInt32(row.Cells["ID"].Value);
                string nombrePaciente = row.Cells["nombre"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar al paciente {nombrePaciente}?",
                    "Eliminar Paciente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    Controladores.ControladorPacientes controlador = new Controladores.ControladorPacientes();
                    controlador.eliminarPaciente(idPaciente);
                    cargarDatos();
                    LimpiarFormulario();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para eliminar",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            tbNombre.Clear();
            tbRaza.Clear();
            tbDescripcion.Clear();
            numPeso.Value = 0;
            dtpNacimiento.Value = DateTime.Now;
            cbEspecies.SelectedIndex = -1;
            cbCondicion.SelectedIndex = -1;
            cbTutores.SelectedIndex = -1;
            cbSexo.SelectedIndex = -1;
            cbReproductividad.SelectedIndex = -1;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
