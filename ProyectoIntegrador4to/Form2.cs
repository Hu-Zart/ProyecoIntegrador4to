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
            Form form3RegistrarConsulta = new Form();
            form3RegistrarConsulta.Show();
        }

        private void btDirigirInv_Click(object sender, EventArgs e)
        {
            Form form4Inventario = new Form();
            form4Inventario.Show();
        }

        private void btRedirigirHis_Click(object sender, EventArgs e)
        {
            Form form5Historial = new Form();
            form5Historial.Show();
        }
    }
}
