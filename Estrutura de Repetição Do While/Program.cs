using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Repetição_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            do
            {

                Console.WriteLine(i++); //printa o valor de ( i ) e incremneta para o proximo

                //continue; - pode ser usado o continue ( para subir para proximo)
                //breack; - pode ser utilizado o break ( para interromper o fluxo )

            }while(i <= 10);


            //-----------------------------------------------------------------------------------------------

            

            while(i <= 20)
            {

                Console.WriteLine(i++);
            }


            Console.ReadKey();
        }
    }
}
