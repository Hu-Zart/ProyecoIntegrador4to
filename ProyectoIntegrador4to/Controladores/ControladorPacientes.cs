using MySql.Data.MySqlClient;
using ProyectoIntegrador4to.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to.Controladores
{
    internal class ControladorPacientes
    {

        public void consultarPacientes(DataGridView dgPacientes)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtPacientes = new DataTable();

            // Columnas visibles
            dtPacientes.Columns.Add("ID", typeof(int));
            dtPacientes.Columns.Add("Nombre", typeof(string));
            dtPacientes.Columns.Add("Especie", typeof(string));
            dtPacientes.Columns.Add("Raza", typeof(string));
            dtPacientes.Columns.Add("Sexo", typeof(string));
            dtPacientes.Columns.Add("Señas Particulares", typeof(string));
            dtPacientes.Columns.Add("Peso", typeof(float));
            dtPacientes.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            dtPacientes.Columns.Add("Condición Corporal", typeof(string));
            dtPacientes.Columns.Add("Tutor", typeof(string));
            dtPacientes.Columns.Add("Reproductividad", typeof(string));

            // Columnas ocultas para IDs
            dtPacientes.Columns.Add("id_especie", typeof(int));
            dtPacientes.Columns.Add("id_tutor", typeof(int));
            dtPacientes.Columns.Add("id_condicionCorporal", typeof(int));

            string sql = @"SELECT pa.id_paciente, pa.nombre, pa.raza, pa.sexo, 
                          pa.señas_particulares, pa.peso, pa.fecha_nacimiento, pa.esterilizado,
                          e.nombre AS nombre_especie, e.id_especie,
                          cc.descripcion AS nombre_condicion_corporal, cc.id_condicionCorporal,
                          t.nombre AS nombre_tutor, t.id_tutor
                   FROM pacientes pa
                   INNER JOIN especies e ON pa.id_especie = e.id_especie
                   INNER JOIN condicionesCorporales cc ON pa.id_condicionCorporal = cc.id_condicionCorporal
                   INNER JOIN tutores t ON pa.id_tutor = t.id_tutor";

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
                        // Convertir datos a tipos específicos
                        string sexoTexto = Convert.ToBoolean(row["sexo"]) ? "Macho" : "Hembra";
                        string esterilizadoTexto = Convert.ToBoolean(row["esterilizado"]) ? "Esterilizado" : "No esterilizado";

                        dtPacientes.Rows.Add(
                            Convert.ToInt32(row["id_paciente"]),
                            row["nombre"].ToString(),
                            row["nombre_especie"].ToString(),
                            row["raza"].ToString(),
                            sexoTexto,
                            row["señas_particulares"].ToString(),
                            Convert.ToSingle(row["peso"]),
                            Convert.ToDateTime(row["fecha_nacimiento"]),
                            row["nombre_condicion_corporal"].ToString(),
                            row["nombre_tutor"].ToString(),
                            esterilizadoTexto,
                            Convert.ToInt32(row["id_especie"]),
                            Convert.ToInt32(row["id_tutor"]),
                            Convert.ToInt32(row["id_condicionCorporal"])
                        );
                    }

                    dgPacientes.DataSource = dtPacientes;


                    dgPacientes.Columns["id_especie"].Visible = false;
                    dgPacientes.Columns["id_tutor"].Visible = false;
                    dgPacientes.Columns["id_condicionCorporal"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los pacientes: " + ex.Message);
            }
        }
        public void consultarPacientesss(DataGridView dgPacientes)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();

            Modelos.ModeloPacientes objetoPacientes = new Modelos.ModeloPacientes();
            DataTable dtPacientes = new DataTable();

            dtPacientes.Columns.Add("ID", typeof(int));
            dtPacientes.Columns.Add("Nombre", typeof(string));
            dtPacientes.Columns.Add("Especie", typeof(string));
            dtPacientes.Columns.Add("Raza", typeof(string));
            dtPacientes.Columns.Add("Sexo", typeof(string));
            dtPacientes.Columns.Add("Señas Particulares", typeof(string));
            dtPacientes.Columns.Add("Peso", typeof(float));
            dtPacientes.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            dtPacientes.Columns.Add("Condición Corporal", typeof(string));
            dtPacientes.Columns.Add("Tutor", typeof(string));
            dtPacientes.Columns.Add("Esterilizado", typeof(string));

            string sql = @"SELECT pa.id_paciente, pa.nombre, pa.raza, pa.sexo, 
                          pa.señas_particulares, pa.peso, pa.fecha_nacimiento, pa.esterilizado,
                          e.nombre AS nombre_especie,
                          cc.descripcion AS nombre_condicion_corporal,
                          t.nombre AS nombre_tutor
                   FROM pacientes pa
                   INNER JOIN especies e ON pa.id_especie = e.id_especie
                   INNER JOIN condicionesCorporales cc ON pa.id_condicionCorporal = cc.id_condicionCorporal
                   INNER JOIN tutores t ON pa.id_tutor = t.id_tutor";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

                DataSet dt = new DataSet();
                sqlDataAdapter.Fill(dt);

                DataTable dtDatos = dt.Tables[0];

                foreach (DataRow row in dtDatos.Rows)
                {

                    objetoPacientes.IdPaciente = Convert.ToInt32(row["id_paciente"]);
                    objetoPacientes.Nombre = row["nombre"].ToString();
                    objetoPacientes.Raza = row["raza"] != DBNull.Value ? row["raza"].ToString() : "";
                    objetoPacientes.Sexo = Convert.ToBoolean(row["sexo"]);
                    objetoPacientes.SeñasParticulares = row["señas_particulares"] != DBNull.Value ? row["señas_particulares"].ToString() : "";
                    objetoPacientes.Peso = row["peso"] != DBNull.Value ? Convert.ToSingle(row["peso"]) : 0.0f;
                    objetoPacientes.FechaNacimiento = row["fecha_nacimiento"] != DBNull.Value ? Convert.ToDateTime(row["fecha_nacimiento"]) : DateTime.MinValue;
                    objetoPacientes.Esterilizado = Convert.ToBoolean(row["esterilizado"]);
                    objetoPacientes.Especie = row["nombre_especie"].ToString();
                    objetoPacientes.CondicionCorporal = row["nombre_condicion_corporal"].ToString();
                    objetoPacientes.Tutor = row["nombre_tutor"].ToString();

                    string sexoTexto = objetoPacientes.Sexo ? "Macho" : "Hembra";
                    string esterilizadoTexto = objetoPacientes.Esterilizado ? "Sí" : "No";

                    dtPacientes.Rows.Add(
                        objetoPacientes.IdPaciente,
                        objetoPacientes.Nombre,
                        objetoPacientes.Especie,
                        objetoPacientes.Raza,
                        sexoTexto,
                        objetoPacientes.SeñasParticulares,
                        objetoPacientes.Peso,
                        objetoPacientes.FechaNacimiento,
                        objetoPacientes.CondicionCorporal,
                        objetoPacientes.Tutor,
                        esterilizadoTexto
                    );
                }

                dgPacientes.DataSource = dtPacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los pacientes: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }


        public void consultaEspecies(ComboBox cbEspecies)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtModelo = new DataTable();

            dtModelo.Columns.Add("Id", typeof(int));
            dtModelo.Columns.Add("Nombre", typeof(string));

            string sql = "SELECT id_especie, nombre FROM especies";

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
                    int id = Convert.ToInt32(row["id_especie"]);
                    string nombre = row["nombre"].ToString();
                    dtModelo.Rows.Add(id, nombre);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar las especies: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            cbEspecies.DataSource = dtModelo;
            cbEspecies.DisplayMember = "Nombre";
            cbEspecies.ValueMember = "Id";
        }

        public void consultaCondicionesCorporales(ComboBox cbCondiciones)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtModelo = new DataTable();

            dtModelo.Columns.Add("ID", typeof(int));
            dtModelo.Columns.Add("Descripción", typeof(string));

            string sql = "SELECT id_condicionCorporal AS ID, descripcion AS Descripción FROM condicionesCorporales";

            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable dtCondiciones = ds.Tables[0];

                foreach (DataRow row in dtCondiciones.Rows)
                {
                    int id = Convert.ToInt32(row["ID"]);
                    string descripcion = row["Descripción"].ToString();
                    dtModelo.Rows.Add(id, descripcion);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar las condiciones corporales: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            cbCondiciones.DataSource = dtModelo;
            cbCondiciones.DisplayMember = "Descripción";
            cbCondiciones.ValueMember = "ID";
        }

        public void consultaTutores(ComboBox cbTutores)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            DataTable dtModelo = new DataTable();

            dtModelo.Columns.Add("ID", typeof(int));
            dtModelo.Columns.Add("Nombre", typeof(string));

            string sql = "SELECT id_tutor, nombre FROM tutores";

            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable dtTutores = ds.Tables[0];

                foreach (DataRow row in dtTutores.Rows)
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
            cbTutores.ValueMember = "ID";
        }

        public void agregarPaciente(ModeloPacientes paciente)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"INSERT INTO pacientes (nombre, id_especie, raza, sexo, señas_particulares, peso, fecha_nacimiento, id_condicionCorporal, id_tutor, esterilizado)
                               VALUES (@nombre, @id_especie, @raza, @sexo, @señas_particulares, @peso, @fecha_nacimiento, @id_condicionCorporal, @id_tutor, @esterilizado)";
            try
            {
                
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", paciente.Nombre);
                sqlCommand.Parameters.AddWithValue("@id_especie", paciente.Especie);
                sqlCommand.Parameters.AddWithValue("@raza", paciente.Raza);
                sqlCommand.Parameters.AddWithValue("@sexo", paciente.Sexo);
                sqlCommand.Parameters.AddWithValue("@señas_particulares", paciente.SeñasParticulares);
                sqlCommand.Parameters.AddWithValue("@peso", paciente.Peso);
                sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", paciente.FechaNacimiento);
                sqlCommand.Parameters.AddWithValue("@id_condicionCorporal", paciente.CondicionCorporal);
                sqlCommand.Parameters.AddWithValue("@id_tutor", paciente.Tutor);
                sqlCommand.Parameters.AddWithValue("@esterilizado", paciente.Esterilizado);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Paciente agregado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el pacientwe: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void actualizarPaciente(ModeloPacientes paciente)
        {
            if (paciente == null)
            {
                MessageBox.Show("El objeto paciente no puede ser nulo.");
                return;
            }

            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"UPDATE pacientes SET 
                    nombre = @nombre,
                    id_especie = @id_especie,
                    raza = @raza,
                    sexo = @sexo,
                    señas_particulares = @señas_particulares,
                    peso = @peso,
                    fecha_nacimiento = @fecha_nacimiento,
                    id_condicionCorporal = @id_condicionCorporal,
                    id_tutor = @id_tutor,
                    esterilizado = @esterilizado
                    WHERE id_paciente = @id_paciente";

            try
            {
                using (MySqlConnection sqlConexion = conexion.establecerConexion())
                {
                    MySqlCommand comando = new MySqlCommand(sql, sqlConexion);

                    comando.Parameters.AddWithValue("@nombre", paciente.Nombre);
                    comando.Parameters.AddWithValue("@id_especie", paciente.Especie);
                    comando.Parameters.AddWithValue("@raza", paciente.Raza);
                    comando.Parameters.AddWithValue("@sexo", paciente.Sexo);
                    comando.Parameters.AddWithValue("@señas_particulares", paciente.SeñasParticulares ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@peso", paciente.Peso);
                    comando.Parameters.AddWithValue("@fecha_nacimiento", paciente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@id_condicionCorporal", paciente.CondicionCorporal);
                    comando.Parameters.AddWithValue("@id_tutor", paciente.Tutor);
                    comando.Parameters.AddWithValue("@esterilizado", paciente.Esterilizado);
                    comando.Parameters.AddWithValue("@id_paciente", paciente.IdPaciente);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Paciente actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el paciente a actualizar.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar el paciente: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void eliminarPaciente(int idPaciente)
        {
            Conexion.Conexion conexion = new Conexion.Conexion();
            string sql = @"DELETE FROM pacientes WHERE id_paciente = @idPaciente";

            try
            {
                using (MySqlConnection sqlConexion = conexion.establecerConexion())
                {
                    MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                    comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Paciente eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el paciente con ID: " + idPaciente);
                    }
                }
            }
            catch (MySqlException e)
            {
                if (e.Number == 1451) // Error de clave foránea en MySQL
                {
                    MessageBox.Show("No se puede eliminar el paciente porque tiene registros relacionados (citas, historial médico, etc.).");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el paciente: " + e.Message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error general al eliminar el paciente: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

    }
}
