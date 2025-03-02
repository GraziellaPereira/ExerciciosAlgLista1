using System;

namespace Desafio1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Digite um número x (entre 1 e 20) e um número y (entre x e 10000)");
            string[] numeros = Console.ReadLine().Split(); 
            x = int.Parse(numeros[0]);
            y = int.Parse(numeros[1]);

            if (x <= 1 || x >= 20 || y <= x || y >= 10000) {
                Console.WriteLine("Número fora do intervalo mencionado!");
                return;
            }
            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);

                if (i % x == 0)
                    Console.WriteLine();
                else
                    Console.Write(" "); 
            }

            Console.ReadKey();
            
            

        }
    }
}
