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
            Form formInventario = new FormInventario();
            mOSTRARfORMULARIOeNpANEL(formInventario);
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
            lblMensaje.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblMensaje.ForeColor = SystemColors.ControlDarkDark;

            panel2.Controls.Add(lblMensaje);
        }
    }
}
