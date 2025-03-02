using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;
            double resultado;
            Console.WriteLine("Digite o número de divisões que serão realizadas: ");
            n = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Agora digite primeiramente o dividendo e depois o divisor (números inteiros): ");
                string[] pares = Console.ReadLine().Split();
                x = int.Parse(pares[0]);
                y = int.Parse(pares[1]);

                if (y  == 0)
                {
                    Console.WriteLine("Divisão impossível.");
                } else
                {
                    resultado = (double)x / y;
                    Console.WriteLine(resultado.ToString("F1"));
                }
            } Console.ReadKey();
        }
    }
}
