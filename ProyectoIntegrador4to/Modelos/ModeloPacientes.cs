using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador4to.Modelos
{
    public class ModeloPacientes
    {
        int idPaciente;
        string nombre;
        string especie;
        string raza;
        bool sexo;
        string señasParticulares;
        double peso;
        DateTime fechaNacimiento;
        string condicionCorporal;
        string tutor;
        bool esterilizado;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }
        public bool Sexo { get => sexo; set => sexo = value; }
        public string SeñasParticulares { get => señasParticulares; set => señasParticulares = value; }
        public double Peso { get => peso; set => peso = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string CondicionCorporal { get => condicionCorporal; set => condicionCorporal = value; }
        public string Tutor { get => tutor; set => tutor = value; }
        public bool Esterilizado { get => esterilizado; set => esterilizado = value; }
    }
}
