using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicios
{
    internal class Exe01
    {


        // Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.

        public void AreaRetangulo()
        {
            Console.WriteLine("Digite a altura do retângulo: ");
            double altura = Convert.ToDouble(Console.ReadLine()); //quarda na variavel altura o valor digitado pelo usuario já convertido de string para double

            Console.WriteLine("Digite a largura do retângulo: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            
            double area = altura * largura; //calcula a area
            
            
            Console.WriteLine("A área do retângulo é: " + area); //printa na tela ( com concatenação + )
            Console.WriteLine($"Área: {area}"); //outra forma de concatenar
        }




    }
}
