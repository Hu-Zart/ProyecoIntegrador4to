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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            String usuario = tbUsuario.Text;
            String contraseña = tbContraseña.Text;
            if (usuario.Equals("Usuario1") && contraseña.Equals("12345") )
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
