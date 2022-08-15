using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste3._0
{
    public class Rede
    {

        public int QuantidadeElementos { get; set; }


        int opcao = 0;
        // int [,] matriz = new int[QuantidadeElementos, QuantidadeElementos];


        /*
        public void CriarRede();
        {
       int QuantidadeElementos = int.Parse(Console.ReadLine());

        int tamanhoLinhasMatriz = QuantidadeElementos;
        int tamanhoColunasMatriz = tamanhoLinhasMatriz;
        int[,] matriz = new int[tamanhoLinhasMatriz, tamanhoColunasMatriz];
        }

        */



        ImprimirMenu();

        public void ImprimirMenu()
        {
            do
            {
                Console.Clear();
                ExibirNetwork();

                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Conectar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Ajuda");

                Console.Write("\nDigite a opcao: ");


                opcao = int.Parse(Console.ReadLine());

                //Console.Clear();
                //   if (opcao == 1 || opcao == 2 || opcao == 3)
                //   {


                switch (opcao)
                {
                    case 1:
                        Conectar();
                        break;
                    case 2:

                        if (Consultar())
                        {
                            Console.WriteLine("O elemento está conectado");
                            //Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("O elemento não está conectado");
                            //  Console.ReadLine();
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Tem que ter um padrão de escolha e elemento e suas conexões! \n" +
                            "Exemplo: O elemento de linha com conexões de colunas" +
                            "\n ou elemento de coluna com conexões de linhas");
                        Console.ReadLine();
                        break;
                    case 4:
                        ExibirNetwork();
                        break;
                    default:
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




        void ExibirTitulosColunas()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            ///Console.WriteLine("COLUNAS");

            for (int i = 0; i < QuantidadeElementos; i++)
            {
                if (i == 0)
                    Console.Write("  ");


                Console.Write($"{i} ");
            }

            Console.Write("\n");

            for (int i = 0; i < QuantidadeElementos; i++)
            {
                Console.Write("---");
            }
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.White;

        }

        void ExibirNetwork()
        {
            ExibirTitulosColunas();

            int[,] matriz = new int[QuantidadeElementos, QuantidadeElementos];//declarando mas nao vai salvar?

            for (int linha = 0; linha < QuantidadeElementos; linha++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(linha + "|");

                Console.ForegroundColor = ConsoleColor.White;




                for (int coluna = 0; coluna < QuantidadeElementos; coluna++)
                {

                    // Console.Write($"{j}"); //linhas e colunas
                    Console.Write($"{matriz[linha, coluna]} "); // valor do elemento da matriz

                }

                Console.WriteLine(" ");
            }
        }

        //conectar                  
        public void Conectar()
        {
            int elemento1;
            int elemento2;

            int[,] matriz = new int[QuantidadeElementos, QuantidadeElementos];//declarando mas nao vai salvar?

            System.Console.Write("Digite o primeiro elemento(linha) que vc quer fazer conecxao: ");
            elemento1 = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o segundo elemento(coluna) que voce quer conectar com ele: ");
            elemento2 = int.Parse(Console.ReadLine());

            // System.Console.Write(elemento1);
            // System.Console.WriteLine(elemento2);


            ExibirTitulosColunas();

            for (int linha = 0; linha < QuantidadeElementos; linha++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(linha + "|");

                Console.ForegroundColor = ConsoleColor.White;

                for (int coluna = 0; coluna < QuantidadeElementos; coluna++)
                {

                    if ((linha == elemento1) && (coluna == elemento2))
                    {
                        matriz[linha, coluna] = 1;
                    }
                    /*else   //para a mesma coluna com o mesma a linha, porque o elemento nao conecta com ele mesmo
                     {
                         if((linha == coluna))
                             {
                             matriz[linha, coluna] = coluna;
                         }
                     }
                     */
                    // Console.Write($"{j}"); //linhas e colunas
                    Console.Write($"{matriz[linha, coluna]} "); // valor do elemento da matriz]

                }

                Console.WriteLine(" ");
            }

        }



        //consultar
        bool Consultar()
        {
            int elemento1;
            int elemento2;

            System.Console.Write("Digite o primeiro elemento(linha) que você quer consutar a conecxao: ");
            elemento1 = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o segundo elemento(coluna) que voce quer consutar a conecxao com ele: ");
            elemento2 = int.Parse(Console.ReadLine());

            ExibirTitulosColunas();

            for (int linha = 0; linha < QuantidadeElementos; linha++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(linha + "|");

                Console.ForegroundColor = ConsoleColor.White;

                for (int coluna = 0; coluna < QuantidadeElementos; coluna++)
                {

                    if (matriz[linha, coluna] == 1)
                    {
                        return true;
                    }
                    // else
                    //{ 
                    //    return false;
                    // }



                    Console.Write($"{matriz[linha, coluna]} "); // valor do elemento da matriz]

                }


                Console.WriteLine(" ");

            }
            return false;
        }

    }
}
