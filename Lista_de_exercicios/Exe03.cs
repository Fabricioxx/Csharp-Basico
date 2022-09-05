using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicios
{
    internal class Exe03
    {

        // Escreva um algoritimo que Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior. 

        public void MenorEMaiorValor()
        {

            int valor1, valor2;

            Console.WriteLine("Informe o numero VALOR 1 :");
            valor1 = Int32.Parse(Console.ReadLine()); //Conversão de String para um valor inteiro

            Console.WriteLine("Informe o numero VALOR 2 :");
            valor2 = Convert.ToInt32(Console.ReadLine()); //Conversão de String para um valor inteiro com o Convert


            if(valor1 > valor2)
            {

                Console.WriteLine("VALOR 1 É MAIOR QUE O VALOR 2");

            }else if(valor1 < valor2)
            {

                Console.WriteLine("VALOR 1 É MENOR QUE O VALOR 2");

            }
            else
            {

                Console.WriteLine(" VALOR 1 E O VALOR 2 SÃO IGUAIS");


            }



        }





    }
}
