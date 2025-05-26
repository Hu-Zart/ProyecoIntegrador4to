using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador4to.Modelos
{
    public class ModeloTutores
    {
        int idTutor;
        string nombre;
        string direccion;
        string telefono;

        public int IdTutor { get => idTutor; set => idTutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
