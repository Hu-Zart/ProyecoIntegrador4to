using ProyectoIntegrador4to.Formularios;
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

        public Modelos.ModeloUsuarios UsuarioActual { get; private set; }


        public Form2(Modelos.ModeloUsuarios usuarioActual)
        {
            InitializeComponent();
            UsuarioActual = usuarioActual;
        }

        private void btDirigirReg_Click(object sender, EventArgs e)
        {
            Form formRegistro = new FormRegistro(UsuarioActual);
            mOSTRARfORMULARIOeNpANEL(formRegistro);
        }

        private void btDirigirInv_Click(object sender, EventArgs e)
        {
            Form formInventario = new FormInventario();
            mOSTRARfORMULARIOeNpANEL(formInventario);
        }

        private void btRedirigirHis_Click(object sender, EventArgs e)
        {
            Form formReportes = new FormReportes();
            mOSTRARfORMULARIOeNpANEL(formReportes);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarMensajePorDefecto();
        }

        public void mOSTRARfORMULARIOeNpANEL(Form formulario)
        {

            panel2.Controls.Clear();

            formulario.TopLevel = false;                     
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;                

            panel2.Controls.Add(formulario);
            formulario.Show();
        }

        private void MostrarMensajePorDefecto()
        {
      
            panel2.Controls.Clear();

            Label lblMensaje = new Label();
            lblMensaje.Text = "Seleccione una opción del menú para comenzar";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.Font = new Font("Segoe UI", 37, FontStyle.Regular);
            lblMensaje.ForeColor = SystemColors.ControlDarkDark;

            panel2.Controls.Add(lblMensaje);
        }

        private void btRedirigirUsuarios_Click(object sender, EventArgs e)
        {
            Form formUsuarios = new FormUsuarios();
            mOSTRARfORMULARIOeNpANEL(formUsuarios);
        }

        private void btDirigriVentas_Click(object sender, EventArgs e)
        {
            Form formVentas = new FormVentas(UsuarioActual);
            mOSTRARfORMULARIOeNpANEL(formVentas);
        }
    }
}
