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
    public partial class FormReportes: Form
    {
        public FormReportes()
        {
            InitializeComponent();
            if (panel1 != null)
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

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new Form5Historial());
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

        private void reporteHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new FormReporteHistoria());
        }
    }
}
