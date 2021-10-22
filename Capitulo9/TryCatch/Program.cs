using System;
using static System.Console;


namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string produto = "peixe";
                DateTime lancto = new DateTime(2010, 5, 1);
                Console.WriteLine($"O {produto} tem {idade(lancto.Year)} anos");
                Console.WriteLine($"O {produto} tem {idade(2023)} anos");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            static int idade(int pAno)
            {
                if(pAno > DateTime.Today.Year)
                {
                    throw new Exception($"ano inválido {nameof(pAno)}");
                }
                return DateTime.Today.Year - pAno;
            }


        }
    }
}
