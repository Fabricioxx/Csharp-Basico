using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Fluxo_SWITCH_CASE
{
    internal class Program
    {
        static void Main(string[] args)
        {


            String nome;

            Console.WriteLine("Informe o NOME do peixe : ");
            nome = Console.ReadLine();

            switch (nome.ToLower()) //ToLower() - Metodo para trasforma toda a entrada de dados em "minusculo"
            {

                case "tilapia":

                    Console.WriteLine(" {0} - Preço: R$10 Kg", nome);
                    break;

                case "traira":

                    Console.WriteLine(" {0} - Preço: R$15 Kg", nome);
                    break;

                case "barigui":

                    Console.WriteLine(" {0} - Preço: R$12 Kg" , nome);
                    break;

                default:

                    Console.WriteLine("PEIXE Não Cadastrado ");

                    break;
            }



            Console.ReadLine();
        }
    }
}
