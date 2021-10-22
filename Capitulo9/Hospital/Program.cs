using System;
using System.Collections.Generic;
using System.Linq;
using Hospital;

namespace Hospital
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var med = new Medico() { ID = 1, Nome = "Rodrigo" };

            Console.WriteLine($"Dr(a) {med.Nome} tem {med.Pacientes?.Count()?? 0} pacientes");

            var objM = new Medico()
            {
                ID = 1,
                Nome = "Mauricio",
                Pacientes = new List<Paciente>
                {
                    new Paciente
                    {
                        ID = 1,
                        NomePaciente = "Jeu",
                        ValorConsulta = 150 },
                    new Paciente
                    {
                        ID = 2,
                        NomePaciente = "Lucimara",
                        ValorConsulta = 180 },
                        //Remedios = "Simeco plus" },
                new Paciente
                {
                    ID = 3,
                    NomePaciente = "marcos",
                    ValorConsulta = 180,
                    Remedios = "neosaldina" },
                    new Paciente
                    {
                        ID = 4,
                        NomePaciente = "Jeu",
                        ValorConsulta = 320 },
                        //Internado = true,
                  //      Historico = "pé chato" },
                new Paciente
                {
                    ID = 5,
                    NomePaciente = "Lucas",
                    ValorConsulta = 100,
                    Internado = true,
                    Historico = "camisa de força" },

                }

            }; // a ?? verifica se o valor é ou não é nulo

            Console.WriteLine($"Histórico de pacientes: Dr(a) {objM.Nome}");
            objM.Pacientes?.ForEach(p => Console.WriteLine($"{p.NomePaciente} - Remedios: " +
                $"{p.Remedios ?? "sem remédios"} - histórico: {p.Historico} - " +
                $"consulta: {p.ValorConsulta:n2}"));

            Console.WriteLine("-----------");
            Console.WriteLine($"Faturamento: {objM.Pacientes?.Sum(v=>v.ValorConsulta):n2}");
            Console.WriteLine($"Qtd internados: {objM.Pacientes?.Count(i=>i.Internado)}");
            Console.WriteLine($"Qtd tomam remédios (!=null):" +
                $"{objM.Pacientes?.Count(r=> r.Remedios != null)}");
            Console.WriteLine($"Qtd tomam remédios (!String):" +
                $"{objM.Pacientes?.Count(r=>!String.IsNullOrEmpty(r.Remedios))}");

        }
    }
}
