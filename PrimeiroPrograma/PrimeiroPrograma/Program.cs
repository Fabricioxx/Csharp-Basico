using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá Mundo!");  //printa na tela
            Console.ReadKey(); // faz um break no programa


            
            Console.WriteLine("Digite um número:"); //Imprime uma mensagem na tela
            int numero1 = Convert.ToInt32(Console.ReadLine());
            
            
            //Interpolação de strings
            Console.WriteLine($"Número lido: {numero1} de novo: {numero1}");

            Console.ReadKey(); //palsa

        }

    }
}
