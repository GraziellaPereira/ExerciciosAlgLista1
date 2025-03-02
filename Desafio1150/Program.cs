using System;

namespace Desafio1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, z;
            Console.WriteLine("Digite um valor x e z: ");
            x = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            while (z < x)
            {
            z = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            int contador = 0;
            int valorAtual = x;

            while (soma <= z) {
                soma += valorAtual;
                valorAtual++;
                contador++;
            }

            Console.WriteLine(contador);
            Console.ReadKey();
        }
    }
}
