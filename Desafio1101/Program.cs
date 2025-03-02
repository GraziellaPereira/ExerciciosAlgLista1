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
            Console.WriteLine("Digite dois pares de números, até um chegar no 0: ");
            string[] pares = Console.ReadLine().Split();
            double m = double.Parse(pares[0]);
            double n = double.Parse(pares[1]);

            if (m > n)
            {
                double newM;
                newM = n;
                n = m;
                m = newM;
            }

            while (n != 0)
            {

                for (double i = m; i <= n; i++)
                {
                    double[] sequencia = new double[i];
                }
            }

            Console.ReadKey();
        }
    }
}
