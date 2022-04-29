using System;

namespace AlturaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de pessoas: ");
            int quantidade = int.Parse(Console.ReadLine());

            double[] vetor = new double[quantidade];

            Console.WriteLine("\nInforme abaixo as alturas (em metros) de cada pessoa!");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("#{0}: ", i);
                vetor[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0.0;
            for (int i = 0; i < quantidade; i++)
            {
                soma += vetor[i];
            }

            double media = soma / quantidade;
            Console.WriteLine("\nA média das alturas é " + media.ToString("F2"));
            Console.ReadKey();
        }
    }
}
