using System;

namespace Teste
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("tamanhoVetor");

            // Network elemento = new Network();

            //elemento.InserirTamanhoVetor();



            // int tamanhoVetor = int.Parse(Console.ReadLine());

            int tamanhoVetor = 5;
            int opcao = 0;
            //Console.WriteLine(tamanhoVetor);

            //int[] numElementos[tamanhoVetor];

            //preencher vetor
            int[] elementos = new int[tamanhoVetor];
            // int count = 1;
            //int countj = 1;

            /*
            for (int i = 0; i < tamanhoVetor; i++)
            {
                for (int j = 0; j < tamanhoVetor; j++)
                {

                    elementos[i] = count;

                    Console.WriteLine(elementos[i]);


                    count++;
                    countj++;

                }

            }
            */


            int[,] array2D = new int[5, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 } };

            //  Listar();
            void Listar()
            {
                System.Console.Write(array2D[0, 0]);
                System.Console.WriteLine(array2D[0, 1]);

                System.Console.Write(array2D[1, 0]);
                System.Console.WriteLine(array2D[1, 1]);

                System.Console.Write(array2D[2, 0]);
                System.Console.WriteLine(array2D[2, 1]);

                System.Console.Write(array2D[3, 0]);
                System.Console.WriteLine(array2D[3, 1]);

                System.Console.Write(array2D[4, 0]);
                System.Console.WriteLine(array2D[4, 1]);

            }

            // System.Console.WriteLine(array2D[1, 0]);
            //  System.Console.WriteLine(array2D[1, 1]);
            // System.Console.WriteLine(array2D[3, 0]);
            // System.Console.WriteLine(array2D[1, 0]);

            int elemento1;
            int elemento2;


            // Conectar();

            void Conectar()
            {
                System.Console.Write(" digite o primeiro elemento: ");
                elemento1 = int.Parse(Console.ReadLine());
                System.Console.Write(" digite o segundo elemento: ");
                elemento2 = int.Parse(Console.ReadLine());


                System.Console.Write(elemento1);
                System.Console.WriteLine(elemento2);



                //ler a array2D


                //procurar valor e se tem conenexao***************

                //buscar cada elemento nas linhas na array2d
                for (int i = 0; i < tamanhoVetor; i++)
                {


                    if (array2D[i, 1] == elemento1)
                    {
                        System.Console.WriteLine($"existe na posicao: linha {i} e coluna 0");
                    }
                    else
                        System.Console.WriteLine($"nao existe conexao com nenhum outro apenas com ele mesmo!");


                }

                //inserir conexao na array 2d
                array2D[4, 0] = elemento1;
                array2D[4, 1] = elemento2;


            }




            void ImprimirMenu()
            {

                System.Console.WriteLine("1. Listar");
                System.Console.WriteLine("2. Conectar");
                //System.Console.WriteLine("3. Exibir menu");

                System.Console.Write("Digite a opcao: ");

                do
                {
                    opcao = int.Parse(Console.ReadLine());

                    //   if (opcao == 1 || opcao == 2 || opcao == 3)
                    //   {


                    switch (opcao)
                    {
                        case 1:
                            Listar();
                            break;
                        case 2:
                            Conectar();
                            break;
                        case 3:
                            ImprimirMenu();
                            break;



                    }
                    //   }
                    //  else
                    //  {
                    //      System.Console.WriteLine("Opcao invalida!");

                    //  }
                } while (opcao != 9);
            }


            //menu sem parar

            /*

                        do
                        {
                            Imprimirmenu();

                                        System.Console.Write(" digite a opcao ");
                                        opcao = int.Parse(Console.ReadLine());

                        } while (opcao != 9);
            */

            ImprimirMenu();








        }
    }
}
