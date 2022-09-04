using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_e_Expressões
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Operadores aritméticos
             * 
             * + soma
             * - subtração
             * * multiplicação
             * / divisão
             * % resto da divisão
             * 
             */

            /* Operador para concatenar
             * 
             * + Concatena Strings
             * 
             */

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

            /* Operadores de atribuição
             * 
             * = atribuição
             * += soma e atribuição
             * -= subtração e atribuição ( var1 -= var2 é o mesmo que var1 = var1 - var2 )
             * *= multiplicação e atribuição (var1 *= var2 - é o mesmo que var1 = var1 * var2)
             * /= divisão e atribuição
             * %= resto da divisão e atribuição (var1 %= var2 - é o mesmo que var1 = var1 % var2)
             * 
             */

            /* Operadores de incremento e decremento 
             * 
             * ++ incremento ( var1 = ++var2 ) var1 vai receber var2+1
             * -- decremento ( var1 = --var2 ) var1 recebe var2-1
             * ++ incremento ( var1 = var2++ ) var2 incrementa 1 e var1 recebe var2
             * -- decremento ( var1 = var2-- ) var2 decrementa 1 e var1 recebe var2
             * 
             */

            /* Operadores de bit a bit 
             * 
             * & e
             * | ou
             * ^ ou exclusivo
             * ~ não
             * << deslocamento para a esquerda
             * >> deslocamento para a direita
             * 
             */

            //----------------------Calculadora Média--------------------------------------------------

            string nomeAluno;
            float nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine(); // recebe o dado e guada na variavel nomeAluno
            
            Console.Write("Informe a nota1 : ");
            nota1 = float.Parse(Console.ReadLine()); //uma forma de converter a string para guardar na variavel nota

            Console.Write("Informe a nota2 : ");
            nota2 = Convert.ToSingle(Console.ReadLine()); //outra forma de converter a string para guardar na variavel nota

            Console.Write("Informe a nota3 : ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Informe a nota4 : ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            
           
            media = ( nota1 + nota2 + nota3 + nota4 ) / 4;  // calcula a media


            // c# precisa criar indices "{0} {1}" para mostar a informação da variavel 
            Console.WriteLine("A média do aluno {0} é {1}", nomeAluno, media);

            

            Console.ReadKey(); //brack
        }
    }
}
