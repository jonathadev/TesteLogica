using System;

namespace Teste3._0
{
    public class Program
    {
        static void Main(string[] args)
        {

            Rede rede1 = new Rede();

            Console.WriteLine("Digite a quantidade de elementos da rede: ");
            rede1.QuantidadeElementos = int.Parse(Console.ReadLine());

            Console.Clear();
            int[,] matriz = new int[rede1.QuantidadeElementos, rede1.QuantidadeElementos];


        }
    }
}
