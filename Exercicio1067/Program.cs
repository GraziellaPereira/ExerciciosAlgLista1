using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercio1067
{
    class Program
    {
        static void Main()
        {
            int x;

            Console.WriteLine("Digite um número de 1 a 1000: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }


}
