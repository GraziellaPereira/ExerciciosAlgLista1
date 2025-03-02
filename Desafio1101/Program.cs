using System;

namespace Desafio1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite dois pares de números, até um chegar no 0: ");
                string[] pares = Console.ReadLine().Split();
                int m = int.Parse(pares[0]);
                int n = int.Parse(pares[1]);

                if (m <= 0 || n <= 0)
                {
                    break;
                }
                    
                if (m > n)
                {
                    int newM;
                    newM = n;
                    n = m;
                    m = newM;
                }

                int soma = 0;

                for (int i = m; i <= n; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }

                Console.WriteLine($"Sum={soma}");
                Console.ReadKey();
            }
            
        }
    }
}
