using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            var sexo = new Dictionary<string, string>();
            sexo.Add("M", "Masculino");
            sexo.Add("F", "Faminino");
            Console.WriteLine(sexo["F"]);
            Console.WriteLine(sexo["M"]);
            Console.WriteLine("------------------------");

            var cidades = new Dictionary<string, string>
            {
                ["MG"] = "Minas Gerais",
                ["SC"] = "Santa Catarina",
                ["SP"] = "São Paulo",
                ["RS"] = "Rio Grande do Sul"

            };
            Console.WriteLine($"---Dicionario com {cidades.Count()} cidades---");
            Console.WriteLine(cidades["MG"]);
            foreach(var cidade in cidades)
            {
                Console.WriteLine($"sigla: {cidades} - {cidades}");
            }
        }
    }
}
