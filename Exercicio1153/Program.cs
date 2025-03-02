using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, resultado = 1;
            Console.WriteLine("Digite um valor de 1 a 12: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0 || n >= 13)
            {
                Console.WriteLine("Número fora do intervalo informado!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }
                
            }
            Console.WriteLine($"O fatorial de {n} é igual a {resultado}");
            Console.ReadKey();
        }
    }
}
