using System;
using System.Collections.Generic;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Func<int> numero = () => ++contador;

            Console.WriteLine($"Chamada 1: {numero()}");
            Console.WriteLine($"Chamada 2: {numero()}");
            Console.WriteLine($"Contador: {contador}");
            Console.WriteLine("-----------------");
            Func<string, int> MetodoContaCaracter = (t) => t.Length; //conta caracteres com a função
            Console.WriteLine(MetodoContaCaracter("Mauricio Luis"));
        }
    }
}
