using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador4to.Modelos
{
    public class ModeloCategorias
    {
        int idCategoria;
        string nombre;
        string descripcion;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
