using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número inteiro");
            int numero = int.Parse(Console.ReadLine());

            string saida = "nulo";
            if ((numero % 2) != 0) {
                saida = "impar";
            }
            else {
                saida = "par";
            }

            Console.WriteLine(saida);
        }
    }
}