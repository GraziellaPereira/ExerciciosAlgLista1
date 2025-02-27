using System;
using System.Collections.Generic; // Biblioteca utilizada para trabalhar com listas

namespace Exercicio1074
{
    internal class Program
    {
        static void Main()
        {
            int n;
            double x;


            Console.WriteLine("Digite o número de casos de testes: ");
            n = int.Parse(Console.ReadLine());
            List<double> numeros = new List<double>();
            List<double> media = new List<double>();

                for (int i = 1; i <+ n; i++)
                {
                Console.WriteLine($"Digite os 3 números para o caso de teste de número {i}:");
                numeros.Add(double.Parse(Console.ReadLine()));
                numeros.Add(double.Parse(Console.ReadLine()));
                numeros.Add(double.Parse(Console.ReadLine()));
            }

                foreach (double num in numeros)
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