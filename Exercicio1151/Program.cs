using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1151
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número inteiro de 1 a 45: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0 || n >= 46)
            {
                Console.WriteLine("Número fora do intervalo mencionado!");
            }
            else
            {
                int[] fibonacci = new int[n];
                fibonacci[0] = 0;
                if (n > 1)
                {
                    fibonacci[1] = 1;
                    
                }
                for (int i = 2; i < n; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

                }
                Console.WriteLine(string.Join(" ", fibonacci));
                Console.ReadKey();
            }
        }
    }
}
