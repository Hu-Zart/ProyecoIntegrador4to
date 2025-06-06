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
    public partial class FormRegistro: Form
    {
        public Modelos.ModeloUsuarios UsuarioActual { get; private set; }
        public FormRegistro(Modelos.ModeloUsuarios usuario)
        {
            UsuarioActual = usuario;
            InitializeComponent();
            if(panel1 != null)
            {

            panel1.Controls.Clear();

            Label lblMensaje = new Label();
            lblMensaje.Text = "Seleccione una opción del menú";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.Font = new Font("Segoe UI", 37, FontStyle.Regular);
            lblMensaje.ForeColor = SystemColors.ControlDarkDark;

            panel1.Controls.Add(lblMensaje);
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new FormTutores());
        }

        public void mostrarFormulario(Form formulario)
        {

            panel1.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panel1.Controls.Add(formulario);
            formulario.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new FormPacientes());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new FormConsultas(UsuarioActual));
        }

    }
}
