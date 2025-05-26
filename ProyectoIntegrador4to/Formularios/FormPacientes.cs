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
    public partial class FormPacientes: Form
    {
        public FormPacientes()
        {
            InitializeComponent(); 
            cargarDatos();
        }

        public void cargarDatos()
        {
            Controladores.ControladorPacientes objetoControlador = new Controladores.ControladorPacientes();
            objetoControlador.consultarPacientes(dgPacientes);
        }
    }
}
