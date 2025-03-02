using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1144
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um valor de 1 a 1000: ");
            n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 1000)
            {
                Console.WriteLine("Número fora do intervalo mencionado!");
                Console.ReadKey();
                return;
            } else
            {
                for (int i = 1; i <= n; i++)
                {
                    int[] sequencia1 = new int[3];
                    sequencia1[0] = i;
                    sequencia1[1] = i * i;
                    sequencia1[2] = i * i * i;

                    int[] sequencia2 = new int[3];
                    sequencia2[0] = sequencia1[0];
                    sequencia2[1] = sequencia1[1] + 1;
                    sequencia2[2] = sequencia1[2] + 1;

                    Console.WriteLine(string.Join(" ", sequencia1));
                    Console.WriteLine(string.Join(" ", sequencia2));
                }
            }
            
            Console.ReadKey();
        }
    }
}
