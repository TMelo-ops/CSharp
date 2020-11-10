using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 -  Criando conversões e outros tipos numéricos \n");


            //double um numero que suporta casa decimal.
            double salario = 1200.50;



            // int é um tipo de variavel que suporta valores de ate 32 bits.
            int salarioEmInterio = (int)salario;
            Console.WriteLine(salarioEmInterio + "\n");


            Console.WriteLine("O meu salario é " + salarioEmInterio + "\n");

            // long é uma variavel de 64 bits.
            long idade = 26;
            Console.WriteLine(idade + "\n");


            // short é um tipo de variavel de 16 bits.
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos + "\n");


            float altura = 1.80f;
            Console.WriteLine(altura + "\n");

            Console.WriteLine("Fim da Execusão do Projeto - Para finalizar a execusão tecle enter . . .  \n");
            Console.ReadLine();
        }
    }
}
