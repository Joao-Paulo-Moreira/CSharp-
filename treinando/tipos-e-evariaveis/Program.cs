using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class tipe_variaveis
    {
        static void Main(string[] args)
        {
            int number = 10; //Declarei uma var que tem o valor de 10
            int numberDois = 20; // Declarei outra var que tem o valor de 20
            var soma = number + numberDois; // Declarei uma variavel que pega o valor atribuito ao number e numberDoise realiza um soma
            Console.WriteLine($"O valor da primeira variável é {number}\n e o valor da segunda variável é {numberDois}\n e o resultado de uma soma entre as duas é {soma}");

            int copiaDoNumeroUm = number; // cópia do número 1
            copiaDoNumeroUm = 11;

            Console.WriteLine($"{number} e {copiaDoNumeroUm}");

            var quadrado = new Quadrado();
            quadrado.lado = 10;

            var segundoQuadrado = quadrado;
            segundoQuadrado.lado = 11;

            Console.WriteLine(quadrado.lado);
            Console.WriteLine(segundoQuadrado.lado);

        }
    }

    class Quadrado
    {
        public int lado;
    }
}
