using System;

using System.Collections.Generic;
using System.Linq;
using static System.Console;



namespace Dicionario2
{
    class Program
    {
        static void Main(string[] args)
        {
            var paises = new Dictionary<int, string>
            {
                [01] = "Brasil",
                [10] = "HOlanda",
                [100] = "EUA"
            };

            foreach (var pais in paises)
            {
                Console.WriteLine($"{pais.Key} - {pais.Value}");
            }
            
        }
    }
}
