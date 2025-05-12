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
    public partial class Form3RegistrarConsulta: Form
    {
        public Form3RegistrarConsulta()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6Datos_Consulta form6Datos_Consulta = new Form6Datos_Consulta();

            // Accede al formulario padre (Form2) y utiliza el método para mostrar el formulario en panel2
            if (this.Owner is Form2 frmPadre)
            {
                frmPadre.mOSTRARfORMULARIOeNpANEL(form6Datos_Consulta);
            }
            // Opcional: Si deseas cerrar o esconder el formulario actual:
            this.Close();
        }

    }
}
