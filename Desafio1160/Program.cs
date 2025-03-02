using System;
using System.Globalization;

namespace CrescimentoPopulacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < t; i++)
            {

                string[] entrada = Console.ReadLine().Split();
                int pa = int.Parse(entrada[0]);  
                int pb = int.Parse(entrada[1]);  
                double g1 = double.Parse(entrada[2], CultureInfo.InvariantCulture);  
                double g2 = double.Parse(entrada[3], CultureInfo.InvariantCulture);  

                int anos = 0;

                while (pa <= pb)
                {
                    pa += (int)(pa * (g1 / 100)); 
                    pb += (int)(pb * (g2 / 100)); 
                    anos++;

                    if (anos > 100) 
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine($"{anos} anos.");
                }
            }
        }
    }
}
