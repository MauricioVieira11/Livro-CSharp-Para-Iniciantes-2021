using System;
using BibliotecaV1;
using Biblioteca;


namespace Biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            LibraryClass Minhabiblioteca = new LibraryClass();
            Minhabiblioteca.Autor = "Des Dear Love";
            Minhabiblioteca.Titulo = "O Estilo Bill Gates de Gerir.";
            Minhabiblioteca.Paginas = 203;
            Minhabiblioteca.Status = true;

            Console.WriteLine("Autor: "+Minhabiblioteca.Autor);
            Console.WriteLine("Titulo: " + Minhabiblioteca.Titulo);
            Console.WriteLine("Paginas: " + Minhabiblioteca.Paginas);
            Console.WriteLine("Status: " + Minhabiblioteca.Status);
            Console.WriteLine();

            LibraryClass MeusLivros = new LibraryClass("Juan Garcia Sola","Linguagem C",296,true);
            Console.WriteLine("Autor: " + MeusLivros.Autor);
            Console.WriteLine("Titulo: " + MeusLivros.Titulo);
            Console.WriteLine("Paginas: " + MeusLivros.Paginas);
            Console.WriteLine("Status: " + MeusLivros.Status);
            Console.WriteLine();
            
            //Teste feito por mim
            LibraryClass teste = new LibraryClass();
            Console.Write("escreva o Autor: ");
            string Autor = Console.ReadLine();
            Console.Write("Escreva o Titulo: ");
            string Titulo = Console.ReadLine();
            Console.Write("Escreva n de páginas: ");
            string Paginas = Console.ReadLine();
            Console.Write("escreva o Status: ");
            string Status = Console.ReadLine();





        }
    }
}
