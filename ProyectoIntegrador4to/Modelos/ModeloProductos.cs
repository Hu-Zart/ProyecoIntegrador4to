using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador4to.Modelos
{
    public class ModeloProductos
    {
        int idProducto;
        string nombre;
        string descripcion;
        float precio;
        float costo;
        int existencia;
        string unidad_medida;
        DateTime fecha_caducidad;
        string categoria;
        string proveedor;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Costo { get => costo; set => costo = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public string Unidad_medida { get => unidad_medida; set => unidad_medida = value; }
        public DateTime Fecha_caducidad { get => fecha_caducidad; set => fecha_caducidad = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
    }
}
