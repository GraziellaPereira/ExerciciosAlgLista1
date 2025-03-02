using System;

namespace Desafio1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros: ");
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int n = int.Parse(valores[1]);


            int index = 2; 
            while (n <= 0)
            {
                n = int.Parse(valores[index]);
                index++;
            }

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += a + i; 
            }

            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
