using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Controle_de_Fluxo_IF_else
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Operadores de comparação
            * 
            * == igual
            * != diferente
            * > maior
            * < menor
            * >= maior ou igual
            * <= menor ou igual
            * 
            */

            /* Operadores lógicos
             * 
             * && e
             * || ou
             * ! não
             * 
             */

            //--------------------------

            int notaAluno = 0;

            Console.WriteLine("Informe a Nota do Aluno");
            notaAluno = (int)Convert.ToSingle(Console.ReadLine()); //paga o resultado da tela converte e quarda na variavel


            if(notaAluno < 50 )
            {

                Console.WriteLine("Aluno REPROVADO !");

            }else if(notaAluno >= 50 && notaAluno < 60)
            {

                Console.WriteLine("Aluno RECUPERAÇÃO !");
            }
            else
            {

                Console.WriteLine("Aluno APROVADO !");
            }



            Console.ReadLine(); //PALSA A TELA
        }
    }
}
