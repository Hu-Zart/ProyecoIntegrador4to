using System;
using System.Collections.Generic;
using System.Data;
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

            //Visibles
            dtConsultas.Columns.Add("ID", typeof(int));
            dtConsultas.Columns.Add("Paciente", typeof(string));

        }
    }
}
