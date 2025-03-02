using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número inteiro para mostrar todos os seus divisores positivos: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) { 
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
