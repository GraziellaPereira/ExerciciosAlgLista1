using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n , contador = 1;
            Console.WriteLine("Digite a quantidade de linhas: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] casos = new string[4];
                for (int j = 0; j <= 3; j++){
                    casos[j] = contador.ToString();
                    contador++;
                }
                casos[3] = "PUM";
                Console.WriteLine(string.Join(" ", casos));
            }
            Console.ReadKey();
        } 
    }
}
