using System.Linq;
using static System.Console;

namespace Cap3FuncoesInternas
{
     class FuncoesTexto
    {   
        static void Main(string[] args)
        {
            WriteLine("-------Funções de Texto--------");
            string empresa = "Microsoft Corporation";

            System.Console.WriteLine("TRIM - retira os espaços em branco antes e depois da expressão");
            System.Console.WriteLine($"Nome sem espaços:{empresa.Trim()}");

            System.Console.WriteLine("Lenght - retorna a quantidade de caracteres");
            System.Console.WriteLine($"Tamanho do texto: {empresa.Length}");
            empresa = empresa.Trim();
            System.Console.WriteLine($"Tamanho do Texto spós o TRIM():{empresa.Length}");

            System.Console.WriteLine("ToUpper - converte todos os caracteres em maiúsculo");
            System.Console.WriteLine($"Converte para maiúsculo: {empresa.ToUpper()}");

            System.Console.WriteLine("ToLower - converte todos os caracteres em minúsculo");
            System.Console.WriteLine($"Converte para minúsculo: {empresa.ToLower()}");

            System.Console.WriteLine("Remove - extrai caracteres a partir das esquerda da empressão");
            System.Console.WriteLine($"texto esquerdo: {empresa.Remove(9)}");
            string[] nomes = { "Fabrício dos Santos", "José da Silva", "Roberta Brasil" };
            foreach (var n in nomes)
            {
                System.Console.WriteLine($"{n.Remove(n.IndexOf(" "))}");
            }
          
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Replace - Troca o Conteúdo da expressão");
            System.Console.WriteLine($"Texto atual:{empresa}");
            var novaEmpresa = empresa.Replace("Microsoft", "Google");
            System.Console.WriteLine($"texto trocado: {novaEmpresa}");
           
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Split - divide e extrai cada palavra em um array");
            string NivelLivro = "Este Livro é básico em C#.";
            string[] blocos = NivelLivro.Split();
            var contador = 1;
            foreach(var exp in blocos)
            {
                System.Console.WriteLine($"texto {contador++}: {exp}");
            }
            System.Console.WriteLine($"Qtd de palavras: {blocos.Count()}"); //tive que colocar a diretiva: Using Ststem.Linq;


        }
    }
}
