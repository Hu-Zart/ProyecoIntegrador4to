using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador4to.Modelos
{
    public class ModeloUsuarios
    {
        int idUsuario;
        string nombre;
        string direccion;
        string telefono;
        string contrasena;
        DateTime fechaRegistro;
        bool permisoInventario;
        bool permisoRegistro;
        bool permisoVeterinario;
        bool permisoVenta;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public bool PermisoInventario { get => permisoInventario; set => permisoInventario = value; }
        public bool PermisoRegistro { get => permisoRegistro; set => permisoRegistro = value; }
        public bool PermisoVeterinario { get => permisoVeterinario; set => permisoVeterinario = value; }
        public bool PermisoVenta { get => permisoVenta; set => permisoVenta = value; }
    }
}
