using System;

namespace Capitulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeiraArray = new int[100]; //criando array e deixando espaços disponíveis
            int[] segundoArray = new int[] { 1, 3, 5, 7, 9 }; //declarando array e atribuindo valores
            int[] terceiroArray = { 1, 2, 3, 4, 5, 6 };

            int[,] arrayMultidimensional = new int[2, 3]; //declarando array multidimensional
            int[,] arrayMultidimensional2 = { { 1,2,3}, {4,5,6 } }; //array multidimensional e atribuindo valores

            //declarando array e atribuindo valores
            int[] segundArray = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("Valor da Array na posição 0 -> {0} ", segundArray[0]);
            Console.WriteLine("Valor da Array na posição 1 -> {0} ", segundArray[1]);
            Console.WriteLine("Valor da Array na posição 1 -> {0} ", segundArray[2]);
            Console.WriteLine("Valor da Array na posição 3 -> {0} ", segundArray[3]);
            Console.WriteLine("Valor da Array na posição 4 -> {0} ", segundArray[4]);



        }
    }
}
