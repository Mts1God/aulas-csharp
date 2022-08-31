using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5] { "Mateus", "Lucas", "Leticia", "Andre", "Marcia" };

            for (int cont = 0; cont < nomes.Length; cont++)
            {
                Console.WriteLine(nomes[cont]);
            }
            Console.ReadLine();
        }
    }
}
