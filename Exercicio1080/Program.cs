using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicao = 0;
            int maiorValor = int.MinValue;
            Console.WriteLine("Digite 100 valores inteiros: ");
            int[] valor = new int[5];
            for (int i =0; i < 5; i++)
            {
                valor[i] = int.Parse(Console.ReadLine());

                if (valor[i] > maiorValor)
                {
                    maiorValor = valor[i];
                    posicao = i + 1;

                }
                
            }
            Console.WriteLine($"O maior valor é {maiorValor} estando na posição {posicao}");
            Console.ReadKey();
        }
    }
}

