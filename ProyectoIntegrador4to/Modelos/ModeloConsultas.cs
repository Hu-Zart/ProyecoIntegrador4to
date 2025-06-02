using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador4to.Modelos
{
    public class ModeloConsultas
    {
        int idConsulta;
        string paciente;
        string veterinario;
        DateTime fechaConsulta;
        string motivo;
        string anamnesis;
        string diagnostico;
        string tratamiento;
        string observaciones;
        float pesoActual;
        float temperatura;
        string frecuenciaCardiaca;
        string frecuenciaRespiratoria;
        string condicionCorporal;

        public int IdConsulta { get => idConsulta; set => idConsulta = value; }
        public string Paciente { get => paciente; set => paciente = value; }
        public string Veterinario { get => veterinario; set => veterinario = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Anamnesis { get => anamnesis; set => anamnesis = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public float PesoActual { get => pesoActual; set => pesoActual = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public string FrecuenciaCardiaca { get => frecuenciaCardiaca; set => frecuenciaCardiaca = value; }
        public string FrecuenciaRespiratoria { get => frecuenciaRespiratoria; set => frecuenciaRespiratoria = value; }
        public string CondicionCorporal { get => condicionCorporal; set => condicionCorporal = value; }
    }
}
