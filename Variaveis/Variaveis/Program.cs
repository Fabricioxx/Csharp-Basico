using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {

        /*Variável é um espaço reservado
            * na memória do computador para armazenarmos
            * um valor / objeto.
            * Esse valor/objeto pode ser alterado no
            * decorrer da execução do sistema */

        static void Main(string[] args)
        {

            //serve para criar uma região(bloco) de codigos especificos para separar e organizar o codigo
            #region MyVariaveis

            // tipos de variaveis
            int idade = 32;
            double salario = 1200.50;
            float altura = 1.80f;
            char sexo = 'M';
            string nome = "João";
            bool casado = false;

            #endregion // fecha a região


            Console.WriteLine($"salario :{salario}"); //precisa colocar o $ no começo para interpolar
            Console.WriteLine($"idade : {idade}");
            Console.WriteLine($"Altura : {altura}");
            Console.WriteLine(sexo);
            Console.WriteLine(nome);
            Console.WriteLine(casado);
            Console.ReadKey();// palsa o console
            
            
            /*Tipo Inteiro
             *sbyte - 128 a 127
             *byte - 0 a 255
             *short - -32768 a 32767
             *ushort - 0 a 65535
             *int - -2147483648 a 2147483647
             *uint - 0 a 4294967295
             *long - -9223372036854775808 a 9223372036854775807
             *ulong - 0 a 18446744073709551615
             */
            
            /*Tipo Pontos Flutuantes
             * flaot - 0 a 22 elevado a 4
             * double - 0 a 25 elevado a 3
             * decimal - 0 a 29 elvado a 6
             */
            
            /* Tipos Texto e Boolean
             * char - 0 a 65535
             * bool - true ou false
             * string - sequência de caracteres
             */






        }
    }
}
