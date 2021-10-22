using System;
using System.Collections.Generic;

namespace Hospital
{
    class Medico
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        //o médico tem uma coleção de pacientes:
        public List<Paciente> Pacientes { get; set; }
    }
    public class Paciente
    {
        public int ID { get; set; }
        public string NomePaciente { get; set; }
        public string Historico { get; set; }
        public string Remedios { get; set; }
        public decimal ValorConsulta { get; set; } = 0;
        public bool Internado { get; set; } 
    }
}
