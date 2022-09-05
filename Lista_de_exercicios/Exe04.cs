using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicios
{
    internal class Exe04
    {

        //Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: 
        //se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, 
        //se idade > 18 e <= 60: Adulto 
        //e se idade > 60: Idoso.

         public void IdadePessoa()
        {

            Console.WriteLine("Digite a idade:");
            int idade = Convert.ToInt32(Console.ReadLine());


            if (idade <= 13)
            {
                Console.WriteLine("Criança");
            }
            else if (idade >13 && idade <= 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade >18 && idade <= 60)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }


        }




    }
}
