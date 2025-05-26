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
            Conexion.Conexion conexion= new Conexion.Conexion();
            Modelos.ModeloPacientes objetoPacientes = new ModeloPacientes();
            DataTable dtPacientes = new DataTable();

            dtPacientes.Columns.Add("ID", typeof(int));
            dtPacientes.Columns.Add("Nombre", typeof(string));
            dtPacientes.Columns.Add("Especie", typeof(string));
            dtPacientes.Columns.Add("Raza", typeof(string));
            dtPacientes.Columns.Add("Sexo", typeof(string));
            dtPacientes.Columns.Add("SeñasParticulares", typeof(string));
            dtPacientes.Columns.Add("Peso", typeof(double));
            dtPacientes.Columns.Add("FechaNacimiento", typeof(DateTime));
            dtPacientes.Columns.Add("CondicionCorporal", typeof(string));
            dtPacientes.Columns.Add("Tutor", typeof(string));
            dtPacientes.Columns.Add("Esterilizado", typeof(bool));

            string sql = @"
                SELECT p.id_paciente, p.nombre, e.nombre AS especie,
                       p.raza,  CASE WHEN p.sexo = 1 THEN 'M' ELSE 'F' END AS sexo, p.señas_particulares,
                       p.peso, p.fecha_nacimiento,
                       cc.descripcion AS condicionCorporal,
                       t.nombre AS nombre_tutor,
                       p.esterilizado
                FROM pacientes p
                INNER JOIN especies e ON p.id_especie = e.id_especie
                INNER JOIN condicionescorporales cc ON p.id_condicionCorporal = cc.id_condicionCorporal
                INNER JOIN tutores t ON p.id_tutor = t.id_tutor";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataSet dt = new DataSet();
                adapter.Fill(dt);

                DataTable dtDatos = dt.Tables[0];

                foreach (DataRow row in dtDatos.Rows)
                {
                    objetoPacientes.IdPaciente = Convert.ToInt32(row["id_paciente"]);
                    objetoPacientes.Nombre = row["nombre"].ToString();
                    objetoPacientes.Especie = row["especie"].ToString();
                    objetoPacientes.Raza = row["raza"].ToString();
                    objetoPacientes.Sexo = row["sexo"].ToString();
                    objetoPacientes.SeñasParticulares = row["señas_particulares"].ToString();
                    objetoPacientes.Peso = !row.IsNull("peso") ? Convert.ToDouble(row["peso"]) : 0;
                    objetoPacientes.FechaNacimiento = !row.IsNull("fecha_nacimiento") ? Convert.ToDateTime(row["fecha_nacimiento"]) : DateTime.MinValue;
                    objetoPacientes.CondicionCorporal= row["condicionCorporal"].ToString();
                    objetoPacientes.Tutor = row["nombre_tutor"].ToString();
                    objetoPacientes.Esterilizado = Convert.ToBoolean(row["esterilizado"]);
                    dtPacientes.Rows.Add(objetoPacientes.IdPaciente, objetoPacientes.Nombre, objetoPacientes.Especie,
                        objetoPacientes.Raza, objetoPacientes.Sexo, objetoPacientes.SeñasParticulares,
                        objetoPacientes.Peso, objetoPacientes.FechaNacimiento, objetoPacientes.CondicionCorporal,
                        objetoPacientes.Tutor, objetoPacientes.Esterilizado);
                }
                dgPacientes.DataSource = dtPacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los pacientes: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
