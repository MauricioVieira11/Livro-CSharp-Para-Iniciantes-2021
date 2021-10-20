using System;
using static System.Console;
using System.Globalization;

namespace Course
{
    class Program
    {
        static decimal Faturamento(decimal qtd = 50, decimal preco = 10, decimal bonus = 5) => qtd * preco + bonus;

        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.FormatarData("dd/MMM/yyyy"));
            Console.WriteLine(DateTime.Today.FormatarData("dddddd/MMM/yyyy"));
            Console.WriteLine(DateTime.Today.FormatarData("MMMM yyyy"));
            Console.WriteLine(DateTime.Today.FormatarData("yyyy"));

            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Parâmetro opcionais: ");
            Console.WriteLine(Faturamento(500, 5,10));
            Console.WriteLine("Paramertos 1 e 2");
            Console.WriteLine(Faturamento(50,12));
            Console.WriteLine("Parâmetros 1 e 3");
            Console.WriteLine(Faturamento(50, bonus:10));
        }
    }
}
