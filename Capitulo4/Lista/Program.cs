using System;
using System.Collections.Generic;


namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomesFuncionarios = new List<string>();
            nomesFuncionarios.Add("Maria");
            nomesFuncionarios.Add("João");
            nomesFuncionarios.Add("André");
            nomesFuncionarios.Add("Flávia");

            foreach(string pessoa in nomesFuncionarios)
            {
                Console.WriteLine(pessoa);
            }

           // Console.WriteLine(nomesFuncionarios[0]); //retorna a primeira da lista
            Console.WriteLine("-------------------------------------");

            nomesFuncionarios.RemoveAt(0); //removeu maria

            Console.WriteLine(nomesFuncionarios[0]); //joão passou a ser o indexador 0
            

        }
    }
}
