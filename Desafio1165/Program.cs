using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            Console.WriteLine("Digite o número de casos de teste (de 1 a 100): ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0 || n >= 101)
            {
                Console.WriteLine("Número fora do intervalo mencionado!");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um número entre 1 até 10^7: ");
                x = int.Parse(Console.ReadLine());
                int qtdDivisores = 0;

                if (x < 1 || x >= 10000000) 
                {
                    Console.WriteLine("Número fora do intervalo mencionado!");
                }

                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                    {
                        qtdDivisores++;
                    }
                }

                if (qtdDivisores == 2)
                {
                    Console.WriteLine($"{x} eh primo");
                }
                else
                {
                    Console.WriteLine($"{x} nao eh primo");
                }
                Console.ReadKey();
            }
        }
    }
}
