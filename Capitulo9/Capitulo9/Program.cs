using System;
using static System.Console;
using static System.Math;
using static System.String;


namespace Capitulo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Raiz quadrada: {Sqrt(3*3+4*4)} ");
            Console.WriteLine($"Valor absoluto: {Abs(1234.78)}");
            Console.WriteLine($"Valor absoluto negativo: {Abs(-1234.78)}");
            Console.WriteLine($"Valor máximo: {Max(100, 590)}");
            Console.WriteLine($"Valor mínimo: {Min(100, 590)}");
            Console.WriteLine($"Arredonda 1 casa decimal: {Round(3250.895m,1)}");
            Console.WriteLine($"Arredonda 2 casas decimais: {Round(3250.895m, 2)}");
            Console.WriteLine("---------------------------");

            Console.WriteLine($"Tamanho da string: {("Livro de c#.Lenght").Length}");
            Console.WriteLine($"Concatena 2 strings: {Concat("Livro de c# e ","Livro de EF core")}");
            string livro = "Livro de EF Core";
            Console.WriteLine($"{livro.Insert(6,"avançado ").ToUpper()}");


        }
    }
}
