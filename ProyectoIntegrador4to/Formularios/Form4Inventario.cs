
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
    public partial class Form4Inventario: Form
    {
        public Form4Inventario()
        {
            InitializeComponent();
            Controladores.ControladorProductos controladorProveedore = new Controladores.ControladorProductos();
            Controladores.ControladorProductos controladorCategoria = new Controladores.ControladorProductos();

            //controladorProveedor.consultarProveedores(cbProveedores);
            cargarDatos();
        }

        public void cargarDatos()
        {
            Controladores.ControladorProductos objetoControlador = new Controladores.ControladorProductos();
            objetoControlador.consultarProductos(dgProductos);
        }

        private void Form4Inventario_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
