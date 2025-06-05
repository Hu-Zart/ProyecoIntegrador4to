using MySql.Data.MySqlClient;
using ProyectoIntegrador4to.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Controladores
{
    internal class ControladorConsultas
    {

        public void consultarConsultas(DataGridView dgConsultas)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtConsultas = new DataTable();

            // Columnas visibles
            dtConsultas.Columns.Add("ID", typeof(int));
            dtConsultas.Columns.Add("Fecha Consulta", typeof(DateTime));
            dtConsultas.Columns.Add("Paciente", typeof(string));
            dtConsultas.Columns.Add("Tutor", typeof(string)); 
            dtConsultas.Columns.Add("Motivo", typeof(string));
            dtConsultas.Columns.Add("Anamnesis", typeof(string)); 
            dtConsultas.Columns.Add("Diagnóstico", typeof(string));
            dtConsultas.Columns.Add("Tratamiento", typeof(string)); 
            dtConsultas.Columns.Add("Peso Actual", typeof(float));
            dtConsultas.Columns.Add("Temperatura", typeof(float));
            dtConsultas.Columns.Add("Frecuencia Cardíaca", typeof(string));
            dtConsultas.Columns.Add("Frecuencia Respiratoria", typeof(string));
            dtConsultas.Columns.Add("Veterinario", typeof(string));

            // Columnas ocultas para IDs
            dtConsultas.Columns.Add("id_paciente", typeof(int));
            dtConsultas.Columns.Add("id_usuario", typeof(int));
            dtConsultas.Columns.Add("id_tutor", typeof(int));

            string sql = @"SELECT 
                    t.id_tutor,
                    c.id_consulta,
                    c.fecha_consulta,
                    c.motivo,
                    c.anamnesis,       
                    c.diagnostico,
                    c.tratamiento,    
                    p.peso AS peso_actual,
                    c.temperatura,
                    c.frecuencia_cardiaca,
                    c.frecuencia_respiratoria,
                    p.nombre AS nombre_paciente,
                    u.nombre AS nombre_veterinario,
                    t.nombre AS nombre_tutor,
                    c.id_paciente,

                    c.id_usuario
                FROM consultas c
                INNER JOIN pacientes p ON c.id_paciente = p.id_paciente
                INNER JOIN usuarios u ON c.id_usuario = u.id_usuario
                INNER JOIN tutores t ON p.id_tutor = t.id_tutor";

            try
            {
                using (MySqlConnection sqlConnection = conexion.establecerConexion())
                {
                    MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

                    DataTable dtDatos = new DataTable();
                    sqlDataAdapter.Fill(dtDatos);

                    foreach (DataRow row in dtDatos.Rows)
                    {
                        dtConsultas.Rows.Add(
                            Convert.ToInt32(row["id_consulta"]),
                            Convert.ToDateTime(row["fecha_consulta"]),
                            row["nombre_paciente"].ToString(),
                            row["nombre_tutor"].ToString(), 
                            row["motivo"].ToString(),
                            row["anamnesis"].ToString(),   
                            row["diagnostico"].ToString(),
                            row["tratamiento"].ToString(), 
                            Convert.ToSingle(row["peso_actual"]),
                            Convert.ToSingle(row["temperatura"]),
                            row["frecuencia_cardiaca"].ToString(),
                            row["frecuencia_respiratoria"].ToString(),
                            row["nombre_veterinario"].ToString(),
                            Convert.ToInt32(row["id_paciente"]),
                            Convert.ToInt32(row["id_usuario"]),
                            Convert.ToInt32(row["id_tutor"])
                        );
                    }

                    dgConsultas.DataSource = dtConsultas;

                    // Ocultar columnas de IDs y campos extensos
                    dgConsultas.Columns["id_paciente"].Visible = false;
                    dgConsultas.Columns["id_usuario"].Visible = false;
                    dgConsultas.Columns["id_tutor"].Visible = false;

                    // Configurar columnas para texto largo
                    dgConsultas.Columns["Anamnesis"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgConsultas.Columns["Diagnóstico"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgConsultas.Columns["Tratamiento"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgConsultas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las consultas: " + ex.Message);
            }
        }
        public void consultaConsultaPorId(int idConsulta, ModeloConsultas modeloConsulta)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = "SELECT * FROM consultas WHERE id_consulta = @id_consulta";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_consulta", idConsulta);

                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    // Asumiendo que ModeloConsultas tiene propiedades:
                    // IdConsulta, Paciente (string), FechaConsulta (DateTime),
                    // Motivo, Anamnesis, Diagnostico, Tratamiento,
                    // PesoActual (float), Temperatura (float),
                    // FrecuenciaCardiaca, FrecuenciaRespiratoria (string),
                    // Veterinario (string)

                    modeloConsulta.IdConsulta = Convert.ToInt32(reader["id_consulta"]);
                    modeloConsulta.Paciente = reader["id_paciente"].ToString();
                    modeloConsulta.FechaConsulta = Convert.ToDateTime(reader["fecha_consulta"]);
                    modeloConsulta.Motivo = reader["motivo"].ToString();
                    modeloConsulta.Anamnesis = reader["anamnesis"].ToString();
                    modeloConsulta.Diagnostico = reader["diagnostico"] == DBNull.Value
                                                              ? ""
                                                              : reader["diagnostico"].ToString();
                    modeloConsulta.Tratamiento = reader["tratamiento"] == DBNull.Value
                                                              ? ""
                                                              : reader["tratamiento"].ToString();
                    modeloConsulta.PesoActual = reader["peso_actual"] == DBNull.Value
                                                              ? 0f
                                                              : Convert.ToSingle(reader["peso_actual"]);
                    modeloConsulta.Temperatura = reader["temperatura"] == DBNull.Value
                                                              ? 0f
                                                              : Convert.ToSingle(reader["temperatura"]);
                    modeloConsulta.FrecuenciaCardiaca = reader["frecuencia_cardiaca"] == DBNull.Value
                                                              ? ""
                                                              : reader["frecuencia_cardiaca"].ToString();
                    modeloConsulta.FrecuenciaRespiratoria = reader["frecuencia_respiratoria"] == DBNull.Value
                                                              ? ""
                                                              : reader["frecuencia_respiratoria"].ToString();
                    modeloConsulta.Veterinario = reader["id_usuario"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la consulta por ID: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
        public void agregarConsulta(ModeloConsultas modeloConsulta)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"
                INSERT INTO consultas 
                  (
                    id_paciente,
                    fecha_consulta,
                    motivo,
                    anamnesis,
                    diagnostico,
                    tratamiento,
                    peso_actual,
                    temperatura,
                    frecuencia_cardiaca,
                    frecuencia_respiratoria,
                    id_usuario
                  ) 
                VALUES 
                  (
                    @id_paciente,
                    @fecha_consulta,
                    @motivo,
                    @anamnesis,
                    @diagnostico,
                    @tratamiento,
                    @peso_actual,
                    @temperatura,
                    @frecuencia_cardiaca,
                    @frecuencia_respiratoria,
                    @id_usuario
                  )";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);

                // 1) Convertir las propiedades de ModeloConsultas a parámetros
                sqlCommand.Parameters.AddWithValue("@id_paciente", modeloConsulta.Paciente);
                sqlCommand.Parameters.AddWithValue("@fecha_consulta", modeloConsulta.FechaConsulta);
                sqlCommand.Parameters.AddWithValue("@motivo", modeloConsulta.Motivo);
                sqlCommand.Parameters.AddWithValue("@anamnesis", modeloConsulta.Anamnesis);
                sqlCommand.Parameters.AddWithValue("@diagnostico", modeloConsulta.Diagnostico ?? "");
                sqlCommand.Parameters.AddWithValue("@tratamiento", modeloConsulta.Tratamiento ?? "");
                sqlCommand.Parameters.AddWithValue("@peso_actual", modeloConsulta.PesoActual);
                sqlCommand.Parameters.AddWithValue("@temperatura", modeloConsulta.Temperatura);
                sqlCommand.Parameters.AddWithValue("@frecuencia_cardiaca", modeloConsulta.FrecuenciaCardiaca ?? "");
                sqlCommand.Parameters.AddWithValue("@frecuencia_respiratoria", modeloConsulta.FrecuenciaRespiratoria ?? "");
                sqlCommand.Parameters.AddWithValue("@id_usuario", modeloConsulta.Veterinario);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Consulta agregada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la consulta: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void actualizarConsulta(ModeloConsultas modeloConsulta)
        {
            if (modeloConsulta == null)
            {
                MessageBox.Show("La consulta no puede ser nula.");
                return;
            }

            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"
                UPDATE consultas SET
                    id_paciente             = @id_paciente,
                    fecha_consulta          = @fecha_consulta,
                    motivo                  = @motivo,
                    anamnesis               = @anamnesis,
                    diagnostico             = @diagnostico,
                    tratamiento             = @tratamiento,
                    peso_actual             = @peso_actual,
                    temperatura             = @temperatura,
                    frecuencia_cardiaca     = @frecuencia_cardiaca,
                    frecuencia_respiratoria = @frecuencia_respiratoria,
                    id_usuario              = @id_usuario
                WHERE id_consulta = @id_consulta";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);

                // 1) Parámetros para actualizar
                sqlCommand.Parameters.AddWithValue("@id_consulta", modeloConsulta.IdConsulta);
                sqlCommand.Parameters.AddWithValue("@id_paciente", modeloConsulta.Paciente);
                sqlCommand.Parameters.AddWithValue("@fecha_consulta", modeloConsulta.FechaConsulta);
                sqlCommand.Parameters.AddWithValue("@motivo", modeloConsulta.Motivo);
                sqlCommand.Parameters.AddWithValue("@anamnesis", modeloConsulta.Anamnesis);
                sqlCommand.Parameters.AddWithValue("@diagnostico", modeloConsulta.Diagnostico ?? "");
                sqlCommand.Parameters.AddWithValue("@tratamiento", modeloConsulta.Tratamiento ?? "");
                sqlCommand.Parameters.AddWithValue("@peso_actual", modeloConsulta.PesoActual);
                sqlCommand.Parameters.AddWithValue("@temperatura", modeloConsulta.Temperatura);
                sqlCommand.Parameters.AddWithValue("@frecuencia_cardiaca", modeloConsulta.FrecuenciaCardiaca ?? "");
                sqlCommand.Parameters.AddWithValue("@frecuencia_respiratoria", modeloConsulta.FrecuenciaRespiratoria ?? "");
                sqlCommand.Parameters.AddWithValue("@id_usuario", modeloConsulta.Veterinario);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Consulta actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la consulta con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la consulta: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void eliminarConsulta(int idConsulta)
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
        public void consultaTutores(ComboBox cbTutores)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtModelo = new DataTable();

            dtModelo.Columns.Add("Id", typeof(int));
            dtModelo.Columns.Add("Nombre", typeof(string));

            string sql = "SELECT id_tutor, nombre FROM tutores";

            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable dtEspecies = ds.Tables[0];

                foreach (DataRow row in dtEspecies.Rows)
                {
                    int id = Convert.ToInt32(row["id_tutor"]);
                    string nombre = row["nombre"].ToString();
                    dtModelo.Rows.Add(id, nombre);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar los tutores: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            cbTutores.DataSource = dtModelo;
            cbTutores.DisplayMember = "Nombre";
            cbTutores.ValueMember = "Id";
        }

        public void consultaInfoTutor(TextBox tbInfo, int idTutor)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();

            string sql = "SELECT CONCAT(nombre, ' / ', direccion, ' / ', telefono) AS info FROM tutores WHERE id_tutor = @id_tutor";

            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                comando.Parameters.AddWithValue("@id_tutor", idTutor);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    tbInfo.Text = reader["info"].ToString();
                }
                else
                {
                    tbInfo.Text = "Tutor no encontrado.";
                }

                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar el tutor: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void consultaInfoPaciente(TextBox tbInfo, int idPaciente)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();

            string sql = @"
        SELECT 
            CONCAT(
                p.nombre, ' / ',
                e.nombre, ' / ',
                p.raza, ' / ',
                IF(p.sexo = 1, 'Macho', 'Hembra'), ' / Condición corporal: ',
                p.peso, 'kg / ',
                p.id_condicionCorporal
            ) AS info
        FROM pacientes p
        JOIN especies e ON p.id_especie = e.id_especie
        WHERE id_paciente = @id_paciente";

            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                comando.Parameters.AddWithValue("@id_paciente", idPaciente);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    tbInfo.Text = reader["info"].ToString();
                }
                else
                {
                    tbInfo.Text = "Paciente no encontrado.";
                }

                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar el paciente: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void consultaPacientes(ComboBox cbPacientes, int idTutor)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtModelo = new DataTable();

            dtModelo.Columns.Add("Id", typeof(int));
            dtModelo.Columns.Add("Nombre", typeof(string));

            string sql = "SELECT id_paciente, nombre FROM pacientes where id_tutor = @id_tutor";

            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                comando.Parameters.AddWithValue("@id_tutor", idTutor);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable dtEspecies = ds.Tables[0];

                foreach (DataRow row in dtEspecies.Rows)
                {
                    int id = Convert.ToInt32(row["id_paciente"]);
                    string nombre = row["nombre"].ToString();
                    dtModelo.Rows.Add(id, nombre);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar los pacientes: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            cbPacientes.DataSource = dtModelo;
            cbPacientes.DisplayMember = "Nombre";
            cbPacientes.ValueMember = "Id";
        }
    }
}

