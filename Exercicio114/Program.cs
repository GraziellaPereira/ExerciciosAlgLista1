using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            for (int i = 1; i <= 100; i++)
            {
                s += 1.0 / i;
            }
            Console.WriteLine($"{s:F2}");
            Console.ReadKey();
        }
       
    }
}
