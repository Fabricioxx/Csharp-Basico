using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Repetição_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------------------------------FOR--------------------------------------------

            //for simples com incremento ++ mas pode ser com decremento --
            for(int i = 0; i < 11; i++)
            {

                if(i == 5) // se i for igual a 5 vai pular esse loop e vai para o proximo ( não vai printar o 5)
                {
                    continue; //envez de decer ( o CONTINUE faz subir para o proximo incremento)

                    // break; //interrompe o FOR ( para de rodar o for )
                }

                Console.WriteLine(i);
            }

            //----------------------------FOR EACH-----------------------------------

            //classe Driveinfor mostra os drives de discos do computador
            foreach(var item in DriveInfo.GetDrives())
            {

                Console.WriteLine(item.Name); // printa o disco C , se tiver mais vai printar todos

            }





            Console.ReadKey();
        }
    }
}
