using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1072
{
    class Program
    {
        static void Main()
        {
            int n, x, dentro, fora; // n = quantidade de valores que serão lidos | x = valores que serão lidos

            dentro = 0;
            fora = 0;

            Console.WriteLine("Digite a quantidade de números que serão digitados: ");
            n = int.Parse(Console.ReadLine());
                

            if (n > 10000) {
                Console.WriteLine("Digite uma quantidade de números menor!");
                return;
             } else
            {   for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Digite um número: ");
                    x = int.Parse(Console.ReadLine());
                        if (x > 10 && x <20) {
                        dentro++;
                         } else
                    {
                        fora++;
                    }
                }
                Console.WriteLine($"{dentro} in");
                Console.WriteLine($"{fora} out");
                Console.ReadKey();
            }
        }
    }
}
