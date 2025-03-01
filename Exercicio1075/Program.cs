﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número entre 1 e 10000");
            n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 10000)
            {
                Console.WriteLine("Digite um número dentro do intervalo informado!");
                return; // Encerra o código quando digita um número inválido.
            } else
            {
                for (int i = 1; i < 10000; i++)
                {
                    if (i % n == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}