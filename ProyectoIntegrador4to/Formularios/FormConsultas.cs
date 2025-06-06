using MySql.Data.MySqlClient;
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
    public partial class FormConsultas : Form
    {
        public Modelos.ModeloUsuarios UsuarioActual { get; private set; }
        public FormConsultas(Modelos.ModeloUsuarios usuario)
        {
            UsuarioActual = usuario;
            InitializeComponent();
            Modelos.ModeloUsuarios usuarioActual = usuario;
            Controladores.ControladorConsultas controladorConsultas = new Controladores.ControladorConsultas();
            controladorConsultas.consultaTutores(cbTutores);

            cargarDatos();
        }

        public void cargarDatos()
        {
            Controladores.ControladorConsultas objetoControlador = new Controladores.ControladorConsultas();
            objetoControlador.consultarConsultas(dgConsultas);
        }

        public void datosFormulario(Modelos.ModeloConsultas objetoConsulta)
        {
            objetoConsulta.FechaConsulta = DateTime.Now;
            objetoConsulta.Paciente = ((DataRowView)cbPacientes.SelectedItem)["Id"].ToString();
            objetoConsulta.Veterinario = UsuarioActual.IdUsuario.ToString();
            objetoConsulta.Motivo = tbMotivo.Text;
            objetoConsulta.Anamnesis = tbAnamesis.Text;
            objetoConsulta.Diagnostico = tbDiagnostico.Text;
            objetoConsulta.Tratamiento = tbTratamiento.Text;
            objetoConsulta.PesoActual = 0;
            objetoConsulta.Temperatura = (float)numTemperatura.Value;
            objetoConsulta.FrecuenciaCardiaca = numLpm.Value.ToString() + " lpm";
            objetoConsulta.FrecuenciaRespiratoria = numRpm.Value.ToString() + " rpm";
            objetoConsulta.CondicionCorporal = "";

        }

        private bool validarCampos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(tbMotivo.Text))
            {
                MessageBox.Show("El motivo es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbAnamesis.Text))
            {
                MessageBox.Show("La anamnesis es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbDiagnostico.Text))
            {
                MessageBox.Show("El diagnóstico es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (string.IsNullOrEmpty(tbTratamiento.Text))
            {
                MessageBox.Show("El tratamiento es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (cbPacientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (numTemperatura.Value <= 0)
            {
                MessageBox.Show("La temperatura debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (numLpm.Value <= 0)
            {
                MessageBox.Show("La frecuencia cardiaca debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (numRpm.Value <= 0)
            {
                MessageBox.Show("La frecuencia respiratoria debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            if (cbTutores.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un tutor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            return valido;
        }

        private void cbTutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTutores.SelectedValue == null) return;
            if (!(cbTutores.SelectedValue is int)) return;
            int idTutor = (int)cbTutores.SelectedValue;
            Controladores.ControladorConsultas controladorConsultas = new Controladores.ControladorConsultas();
            controladorConsultas.consultaPacientes(cbPacientes, idTutor);
            controladorConsultas.consultaInfoTutor(tbInfoTutor, idTutor);
        }

        private void cbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPacientes.SelectedValue == null) return;
            if (!(cbPacientes.SelectedValue is int)) return;
            int idPaciente = (int)cbPacientes.SelectedValue;
            Controladores.ControladorConsultas controladorConsultas = new Controladores.ControladorConsultas();
            controladorConsultas.consultaInfoPaciente(tbInfoPaciente, idPaciente);
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarCampos())
                    return;
                Modelos.ModeloConsultas datosConsulta = new Modelos.ModeloConsultas();
                datosFormulario(datosConsulta);
                Controladores.ControladorConsultas objetoControlador = new Controladores.ControladorConsultas();
                objetoControlador.agregarConsulta(datosConsulta);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int idConsulta;
        private void btEditar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Modelos.ModeloConsultas objetoConsulta = new Modelos.ModeloConsultas();
                objetoConsulta.IdConsulta = idConsulta;
                objetoConsulta.FechaConsulta = DateTime.Now;
                objetoConsulta.Paciente = cbPacientes.SelectedValue.ToString();
                objetoConsulta.Veterinario = UsuarioActual.IdUsuario.ToString();
                objetoConsulta.Motivo = tbMotivo.Text;
                objetoConsulta.Anamnesis = tbAnamesis.Text;
                objetoConsulta.Diagnostico = tbDiagnostico.Text;
                objetoConsulta.Tratamiento = tbTratamiento.Text;
                objetoConsulta.PesoActual = 0;
                objetoConsulta.Temperatura = (float)numTemperatura.Value;
                objetoConsulta.FrecuenciaCardiaca = numLpm.Value.ToString() + " lpm";
                objetoConsulta.FrecuenciaRespiratoria = numRpm.Value.ToString() + " rpm";
                objetoConsulta.CondicionCorporal = "";
                Controladores.ControladorConsultas controladorConsulta = new Controladores.ControladorConsultas();
                controladorConsulta.actualizarConsulta(objetoConsulta);
                cargarDatos();
            }
        }

        private void dgConsultas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgConsultas.Rows[e.RowIndex];

            idConsulta = Convert.ToInt32(fila.Cells[0].Value);
            cbPacientes.SelectedValue = fila.Cells["id_paciente"].Value;
            cbTutores.SelectedValue = fila.Cells["id_tutor"].Value;
            tbMotivo.Text = fila.Cells["Motivo"].Value.ToString();
            tbAnamesis.Text = fila.Cells["Anamnesis"].Value.ToString();
            tbDiagnostico.Text = fila.Cells["Diagnóstico"].Value.ToString();
            tbTratamiento.Text = fila.Cells["Tratamiento"].Value.ToString();
            numTemperatura.Value = Convert.ToDecimal(fila.Cells["Temperatura"].Value);
            numLpm.Value = Convert.ToDecimal(fila.Cells["Frecuencia Cardíaca"].Value.ToString().Replace(" lpm", ""));
            numRpm.Value = Convert.ToDecimal(fila.Cells["Frecuencia Respiratoria"].Value.ToString().Replace(" rpm", ""));
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "DELETE FROM consultas WHERE id_consulta = @id_consulta";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_consulta", idConsulta);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Consulta eliminada correctamente.");
                    cargarDatos();

                    tbMotivo.Clear();
                    tbAnamesis.Clear();
                    tbDiagnostico.Clear();
                    tbTratamiento.Clear();
                    numTemperatura.Value = 0;
                    numLpm.Value = 0;
                    numRpm.Value = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la consulta: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
