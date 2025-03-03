using System;
using System.Globalization;

namespace CrescimentoPopulacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;

            Console.WriteLine("Digite o número de casos de teste: ");
            t = int.Parse(Console.ReadLine());

            if (t < 1 || t > 3000)
            {
                Console.WriteLine("Número de casos de teste fora do intervalo permitido.");
            }
            Console.WriteLine("Digite respectivamente: a população de A, a população de B, o crescimento populacional de A e o crescimento populacional de B: ");

            for (int i = 0; i < t; i++)
            {
                string[] amostra = Console.ReadLine().Split();
                int pa = int.Parse(amostra[0]);
                int pb = int.Parse(amostra[1]);
                double g1 = double.Parse(amostra[2], CultureInfo.InvariantCulture);
                double g2 = double.Parse(amostra[3], CultureInfo.InvariantCulture);

                if (pa < 100 || pa >= 1000000)
                {
                    Console.WriteLine("População de A inválida.");
                    continue;
                }
                else if (pb <= pa || pb > 1000000)
                {
                    Console.WriteLine("População de B inválida.");
                    continue;
                }
                else if (g1 < 0.1 || g1 > 10.0)
                {
                    Console.WriteLine("Crescimento populacional de A inválido.");
                    continue;
                }
                else if (g2 < 0.0 || g2 > 10.0 || g2 > g1)
                {
                    Console.WriteLine("Crescimento populacional de B inválido.");
                    continue;
                }

                int anos = 0;
                while (pa <= pb)
                {
                    pa += (int)(pa * (g1 / 100));
                    pb += (int)(pb * (g2 / 100));

                    anos++;
                    if (anos > 100) {
                        Console.WriteLine("Mais de um século.");
                        break;
                    } 
                } if (anos <= 100)
                {
                    Console.WriteLine($"{anos} anos.");
                }
                
            }
            Console.ReadKey();
        }
    }
}

