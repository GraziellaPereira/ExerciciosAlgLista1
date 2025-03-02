using System;

namespace Exercicio1156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            int numerador = 1;
            int denominador = 1;

            while (numerador <= 39)
            {
                s += (double)numerador / denominador;
                numerador += 2; 
                denominador *= 2; 
            }

            Console.WriteLine($"{s:F2}");

            Console.ReadKey();
        }
    }
}
