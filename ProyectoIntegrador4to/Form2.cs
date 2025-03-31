using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador4to
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btDirigirReg_Click(object sender, EventArgs e)
        {
            Form form3RegistrarConsulta = new Form3RegistrarConsulta();
            form3RegistrarConsulta.Owner = this;
            mOSTRARfORMULARIOeNpANEL(form3RegistrarConsulta);
        }

        private void btDirigirInv_Click(object sender, EventArgs e)
        {
            Form form4Inventario = new Form4Inventario();
            mOSTRARfORMULARIOeNpANEL(form4Inventario);
        }

        private void btRedirigirHis_Click(object sender, EventArgs e)
        {
            Form form5Historial = new Form5Historial();
            mOSTRARfORMULARIOeNpANEL(form5Historial);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarMensajePorDefecto();
        }

        public void mOSTRARfORMULARIOeNpANEL(Form formulario)
        {
            // Configurar el formulario hijo
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Ajustar el tamaño del formulario al panel contenedor
            formulario.Size = panel2.ClientSize; // Usar ClientSize para el área disponible

            // Centrar el formulario si es más pequeño (opcional)
            formulario.Location = new Point(
                (panel2.Width - formulario.Width) / 2,
                (panel2.Height - formulario.Height) / 2);

            // Configuración de redimensionamiento
            formulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                              | AnchorStyles.Left | AnchorStyles.Right;

            panel2.Controls.Clear();
            panel2.Controls.Add(formulario);
            formulario.Show();
        }

        private void MostrarMensajePorDefecto()
        {
            // Limpiar el panel primero
            panel2.Controls.Clear();

            // Crear y configurar la etiqueta de mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = "Seleccione una opción del menú para comenzar";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblMensaje.ForeColor = SystemColors.ControlDarkDark;

            // Agregar la etiqueta al panel
            panel2.Controls.Add(lblMensaje);
        }
    }
}
