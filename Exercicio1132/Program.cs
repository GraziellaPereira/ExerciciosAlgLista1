using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1071
{
    class Program
    {
        static void Main()
        {
            int x, y, soma = 0;

            Console.WriteLine("Digite dois números inteiros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                int newX;
                newX = y;
                y = x;
                x = newX;
            }

            for (int i = x; i <= y; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;

                }

            }
            Console.WriteLine($"Soma dos números entre {x} e {y} (incluindo os mesmos) que não são divisíveis por 13 é igual a: {soma}");
            Console.ReadKey();
        }
    }
}
