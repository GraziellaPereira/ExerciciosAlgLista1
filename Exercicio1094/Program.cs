using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int totalCobaias = 0;
            int totalCoelhos = 0;
            int totalRatos = 0;
            int totalSapos = 0;
            double percentualC;
            double percentualR;
            double percentualS;
            Console.WriteLine("Digite o número de experimentos: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a quantidade e a cobaia realizada em cada teste (c = coelho, r = rato, s = sapo)");
                string[] cobaias = Console.ReadLine().ToUpper().Split();
                int quantidade = int.Parse(cobaias[0]);
                char animais = char.Parse(cobaias[1]);
                
                totalCobaias += quantidade;
                if (animais == 'C')
                {
                    totalCoelhos += quantidade;
                } else if (animais == 'R')
                {
                    totalRatos += quantidade;
                } else if (animais == 'S') {
                    totalSapos += quantidade; 
                } else
                {
                    Console.WriteLine("Animal inválido.");
                }
                

            }

            percentualC = ((totalCoelhos / (double)totalCobaias) * 100);
            percentualR = ((totalRatos / (double)totalCobaias) * 100);
            percentualS = ((totalSapos / (double)totalCobaias) * 100);
            Console.WriteLine($"Total: {totalCobaias} cobaias.");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");
            Console.WriteLine($"Percentual de coelhos: {percentualC:F2} %");
            Console.WriteLine($"Percentual de ratos: {percentualR:F2} %");
            Console.WriteLine($"Percentual de sapos: {percentualS:F2} %");

            Console.ReadKey();
        }
    }
}
