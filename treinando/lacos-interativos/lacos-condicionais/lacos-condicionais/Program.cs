using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços condicionais => execução mediante determinada condição/situação satisfeita

            int firstCarSpeed = 150;
            int secondCarSpeed = 145;

            if (firstCarSpeed >= secondCarSpeed)
            {
                Console.WriteLine("O carro 1 está mais rapido que o carro 2");
            }else
            {
                Console.WriteLine("Não consegui identificar qual carro está mais rápido");
            }

        }
    }
}