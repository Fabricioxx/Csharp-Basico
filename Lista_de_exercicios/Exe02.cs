using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicios
{
    internal class Exe02
    {

        //Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:
        //a) Dólar(1 dólar = 5,17 reais)
        //b) Euro(1 euro = 6,14 reais)
        //c) Peso argentino(1 peso argentino = 0,05 reais)

        public void ConversaoMonetaria()
        {

            double dolar =5.17, euro=6.14, pesoArgentino=0.05;
            double realDolar, realEuro, realPessoargentino;


            Console.WriteLine("Digite a Valor em real (R$) : ");
            double valor = Convert.ToDouble(Console.ReadLine());

            realDolar = valor;
            realDolar /= dolar;

            realEuro = valor;
            realEuro /= euro;

            realPessoargentino = valor;
            realPessoargentino /= pesoArgentino;



            Console.WriteLine("Real para Dolar :" + realDolar);
            Console.WriteLine("Real para Euro : {0}",realEuro);
            Console.WriteLine($"Real para peso Argentino : {realPessoargentino}");


        }



    }
}
