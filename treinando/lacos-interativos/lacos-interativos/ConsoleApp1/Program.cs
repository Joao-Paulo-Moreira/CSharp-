global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Text;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace lacosInteraivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laços interativos são estruturas que repetem um bloco do cógo determinado número de vezes
            //laço for
            for (int i = 0; i < 5; i++) //i++ significa que i++ vai aumentar de 1 em 1
            {
                Console.WriteLine($"A soma de {i} é {+i}");
            }

            //while
            int contador = 0;
            while (contador < 10)
            {
                contador++;
                Console.WriteLine(contador);
            }

            //do while

            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            //foreach
            //percorre todo elemento de um conjunto
            int[] conjunto = { 1, 2, 3, 4, 7};
            foreach(int numero in  conjunto)
            {
                Console.WriteLine($"Esse elemento tem o valor {numero}! E esse valor somado com 10 é {numero + 10}");
            }
        }
    }
}