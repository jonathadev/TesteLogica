using System;

namespace Teste2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Digite a quantidade de elementos da rede: ");
           
            int tamanhoLinhasMatriz = int.Parse(Console.ReadLine());

            int tamanhoColunasMatriz = tamanhoLinhasMatriz;

            int[,] matriz = new int[tamanhoLinhasMatriz, tamanhoColunasMatriz];

            Console.Clear();

            //ExibirNetwork();

            int opcao = 0;

            ImprimirMenu();

            void ImprimirMenu()
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

                    switch (opcao)
                    {
                        case 1:
                            Conectar();
                            break;
                        case 2:

                            if (Consultar())
                            {
                                Console.WriteLine("O elemento está conectado");                           
                            }
                            else
                            {
                                Console.WriteLine("O elemento não está conectado");                            
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
              
                } while (opcao != 9);
            }

            void ExibirNetwork()
            {
                ExibirTitulosColunas();

                for (int linha = 0; linha < tamanhoLinhasMatriz; linha++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(linha + "|");

                    Console.ForegroundColor = ConsoleColor.White;

                    for (int coluna = 0; coluna < tamanhoColunasMatriz; coluna++)
                    {                  
                        Console.Write($"{matriz[linha, coluna]} "); // valor do elemento da matriz
                    }

                    Console.WriteLine(" ");
                }
            }

            void ExibirTitulosColunas()
            {
                Console.ForegroundColor = ConsoleColor.Black;
                ///Console.WriteLine("COLUNAS");

                for (int i = 0; i < tamanhoColunasMatriz; i++)
                {
                    if (i == 0)
                        Console.Write("  ");


                    Console.Write($"{i} ");
                }

                Console.Write("\n");

                for (int i = 0; i < tamanhoColunasMatriz; i++)
                {
                    Console.Write("---");
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.White;

            }

            //conectar                  
            void Conectar()
            {
                int elemento1;
                int elemento2;

                System.Console.Write("Digite o primeiro elemento(linha) que vc quer fazer conecxao: ");
                elemento1 = int.Parse(Console.ReadLine());
                System.Console.Write("Digite o segundo elemento(coluna) que voce quer conectar com ele: ");
                elemento2 = int.Parse(Console.ReadLine());

                ExibirTitulosColunas();

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.White;

                    matriz[elemento1, elemento2] = 1;

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
       
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.White;
               
                        if (matriz[elemento1, elemento2] == 1)
                        {
                            return true;
                        }
                        else
               
                return false;
            }

        }
    }
}
