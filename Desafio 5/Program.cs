using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESCREVA UM PROGRAMA QUE LEIA UM NUMERO E INDENTIFIQUE SE É POSITIVO OU NEGATIVO

            Console.WriteLine("Escreva um número");
            double num = double.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Negativo");
            }
            else if (num == 0)
            {
                Console.WriteLine("Neutro");
            }
            else
                Console.WriteLine("Positivo");
        }
    }
}
