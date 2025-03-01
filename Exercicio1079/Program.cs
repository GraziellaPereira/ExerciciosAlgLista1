using System;
using System.Globalization;

namespace Exercicio1079
{
    internal class Program
    {
        static void Main()
        {
            int n;

            Console.WriteLine("Digite o número de casos de testes que serão realizados: ");
            n = int.Parse(Console.ReadLine());

            double[] casosTeste = new double[3];
            double mediaPonderada;
            for (int i = 1; i< n; i++) {
                Console.WriteLine($"Digite os 3 números do caso de teste de número {i} ");

                for (int j = 0; j < 3; j++)
                {
                    casosTeste[j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                }
                mediaPonderada = ((casosTeste[0] * 2) + (casosTeste[1] * 3) + (casosTeste[2] * 5)) / 10;
                Console.WriteLine($"Média ponderada: {mediaPonderada:F1}");
            }
            Console.ReadKey();
        }
    }
}