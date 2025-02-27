using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1073
{
   class Program
    {
        static void Main()
        {
            int n;
            double quadrado;

            quadrado = 0;

            Console.WriteLine("Digite um valor de 5 a 2000: ");
            n = int.Parse(Console.ReadLine());

            if (n < 5 || n > 2000)
            {
                Console.WriteLine("O número infornado não faz parte do intervalo mencionado!");
            } else
            {
                for(int i = 2; i <= n; i++)
                {
                    if(i % 2 == 0) {
                        quadrado = Math.Pow(i, 2);
                        Console.WriteLine($"{i}^2 = {quadrado}");
                    }
                }
            } Console.ReadKey();
        }
    }
}
