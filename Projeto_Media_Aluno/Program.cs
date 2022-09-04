using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Media_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            string pergunta = "s";
            float nota1, nota2, nota3, nota4, media;

            while(pergunta == "s")
            {


            
             Console.Clear(); //limpa a tela do console


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


            media = (nota1 + nota2 + nota3 + nota4) / 4;  // calcula a media



            switch (media)
            {
                case float n when n >= 5: //** uma forma de comparar direto no case ( n é a variavel media )

                    // c# precisa criar indices "{0} {1}" para mostar a informação da variavel 
                    Console.WriteLine("A média do aluno {0} é {1} [ APROVADO ! ]", nomeAluno, media);
                    break;

                case float n when ( n >= 4 && n < 5 ):

                    Console.WriteLine("A média do aluno {0} é {1} [ RECUPERAÇÃO ! ]", nomeAluno, media);
                    break;

                default:

                    Console.WriteLine("A média do aluno {0} é {1} [ REPROVADO ! ]", nomeAluno, media);

                    break;
            }


                Console.Write("Deseja calcular outra média? (s/n): ");
                pergunta = Console.ReadLine().ToLower(); //ToLower(); - metodo para transformar toda entrada de caracteres em minusculo


                //para garantir que aceita apenas s ou n
                while (true)
                {
                    
                    Console.Write("Deseja calcular outra média? (s/n): ");
                    pergunta = Console.ReadLine().ToLower(); //ToLower(); - metodo para transformar toda entrada de caracteres em minusculo

                    if(pergunta != "n" && pergunta != "s")
                    {
                        Console.Clear(); //limpa a tela do console

                        Console.WriteLine("Digite apenas n ou s.");
                    }
                    else
                    {
                        break;
                    }

                }






            }//-- fim do while
            Console.ReadKey(); //brack
        }
    }
}
