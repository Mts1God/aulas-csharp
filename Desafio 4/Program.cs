using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quantos metros ² wxiste em um apartamento se o apartamento for menor que 50² o programa deve retornar apartamento compacto caso seja maior apartamento super luxo

            double largura, comprimento, area, valorTotal;


            Console.WriteLine("largura do apartamento");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("comprimento do apartamento");
            comprimento = double.Parse(Console.ReadLine());

            area = largura * comprimento;

            if (area <= 50)
            {
                Console.WriteLine("Apartamento para guardar balões");
            }
            else Console.WriteLine("Apartamento do vitor");
        
        }
    }
}
