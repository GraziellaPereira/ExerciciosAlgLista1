using System;

namespace Desafio1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de casos de teste: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor x e y: ");
            
            for (int j = 0; j < n; j++)
            {
                string[] pares = Console.ReadLine().Split();
                int x = int.Parse(pares[0]);
                int y = int.Parse(pares[1]);
               
                    if (x % 2 == 0)
                    {
                        x++; 
                    }
                    int soma = 0;

                    for (int i = 0; i < y; i++)
                    {
                        soma += x; 
                        x += 2;
                    }
                Console.WriteLine(soma);

            }
            
            Console.ReadKey();
        }
    }
}
