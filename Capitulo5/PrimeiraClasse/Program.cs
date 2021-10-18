using System;
using PrimeiraClasse;

namespace PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            String Digitado = new String("");
            Digitado = Console.ReadLine();

            Console.WriteLine("Você digitou: "+ Digitado.ToUpper());

            InteracaoUsuario Pedido = new InteracaoUsuario();

            Pedido.SolicitarDigitacao();

            Pedido.MostrarDigitacao();

            Console.WriteLine("NOva digitação sem espaços: "+Digitado.ToUpper());
        }
    }
}
