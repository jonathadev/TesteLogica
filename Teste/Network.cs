using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Network
    {
        /*A classe pode ter
        quantos membros privados ou protegidos forem necessários para uma boa implementação*/

        int elemento1;
        int elemento2;


        //int numElementos;

        //fazer array? 
        //vetor?

        public int InserirTamanhoVetor()
        {
            int tamanhoVetor = Console.Read();
            return tamanhoVetor;

        }


        // tamanhoVetor = Console.ReadLine();

        //int numElementos[tamanhoVetor];


        /*
        public Network(int numElem)
        {
           

            try
            {
                //if??? (numElementos é inteiro >0)

                // Do not initialize this variable here.
                numElementos = numElem;
                
            }
            catch
            {
            }
            // Error: Use of unassigned local variable 'n'.


            public void Conectar(int elemento1, int elemento2)
            {

                try
                {
                    //if??? (numElementos é inteiro >0)CONVERTER PARA INT32 

                    // Do not initialize this variable here.
                    numElementos = numElem;

                }
                catch( Exception e)
                {
                }
                // Error: Use of unassigned local variable 'n'.
            }

            public bool Consultar(int elemento1, int elemento2)
            {

                try
                {
                    //if??? (numElementos é inteiro >0)

                    // Do not initialize this variable here.
                    numElementos = numElem;

                    return true;

                }
                catch
                {

                    return true;
                }
                // Error: Use of unassigned local variable 'n'.

                
            }
        
        }
        */
    }
}
