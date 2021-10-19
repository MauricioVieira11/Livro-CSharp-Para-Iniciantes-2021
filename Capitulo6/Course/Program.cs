using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número:");
            var n1 = (Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            var n2 = (Console.ReadLine());

            try
            {
                int n3 = int.Parse(n1);
                int n4 = int.Parse(n2);
                var divisao = n3 / n4;
                Console.WriteLine($"A divisão de {n3} por {n4} é {divisao}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Erro de divisão por zero: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro de formatação: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro na divisão: {ex.Message}");
            }
            finally{
                Console.WriteLine("OBS: Sempre irá executar o comando finally");
            }
            Console.WriteLine("Final");
        }
    }
}
