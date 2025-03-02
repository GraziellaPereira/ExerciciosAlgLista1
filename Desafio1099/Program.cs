using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;
            Console.WriteLine("Digite o número de casos de teste: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite dois números inteiros: ");
                string[] conjunto = Console.ReadLine().Split();
                x = int.Parse(conjunto[0]);
                y = int.Parse(conjunto[1]);
                int soma = 0;
                if (x > y)
                {
                    int newX;
                    newX = y;
                    y = x;
                    x = newX;
                }

                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0) 
                    {
                        soma += j;
                        
                    }
                }
                Console.WriteLine(soma);
            }
            
            Console.ReadKey();
        }
    }
}
