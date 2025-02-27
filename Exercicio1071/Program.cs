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
            if (y > x) {
                int newY;
                newY = x;
                x = y;
                y = newY;
            }

            for (int i = y +1; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                    
                }
                
            }
            Console.WriteLine($"Soma dos números ímpares entre {y} e {x} é igual a: {soma}");
            Console.ReadKey();
        }
    }
}
