using System;
using System.Collections.Generic; // Biblioteca utilizada para trabalhar com listas

namespace Exercicio1074
{
    internal class Program
    {
        static void Main()
        {
            int n, x;
            string validaPositivo, validaPar;


            Console.WriteLine("Digite o número de valores que serão digitados: ");
            n = int.Parse(Console.ReadLine());

            if (n >= 10000)
            {
                Console.WriteLine("Valor muito alto, favor digitar um valor menor!");
            }
            else
            {
                Console.WriteLine("Digite os números:");

                List<int> numeros = new List<int>();
                List<string> resultados = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    numeros.Add(int.Parse(Console.ReadLine()));
                }

                foreach (int num in numeros) 
                {
                    x = num;

                    if (x == 0)
                    {
                        resultados.Add("NULL");
                    }
                    else
                    {
                        validaPar = (x % 2 == 0) ? "EVEN" : "ODD";
                        validaPositivo = (x > 0) ? "POSITIVE" : "NEGATIVE";

                        resultados.Add($"{validaPar} {validaPositivo}");
                    }
                }

                Console.WriteLine("Resultados:");
                foreach (string resultado in resultados)
                {
                    Console.WriteLine(resultado);
                }

                Console.ReadKey(); 
            }
        }
    }
}