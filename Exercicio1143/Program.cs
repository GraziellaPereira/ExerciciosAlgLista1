using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número de 1 a 1000 para calcular o quadrado e o cubo dos primeiros números da quantodade informada: ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 1000) {
                Console.WriteLine("Número fora do intervalo mencionado!");
                Console.ReadKey();
                return;
            } else
            {
                for (int i = 1; i <= n; i++)
                {
                    int[] potencia = new int[3];
                    potencia[0] = i;
                    potencia[1] = i * i;
                    potencia[2] = i * i * i;

                    Console.WriteLine(string.Join(" ", potencia));
                }
                Console.ReadKey();
            }

           
        }
    }
}
