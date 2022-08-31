using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("loginha da 10");
            Console.WriteLine("Insira o seu saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("valor do produto");
            double valordoproduto = double.Parse(Console.ReadLine());


            double troco = saldo - valordoproduto;

            Console.WriteLine("troco: R$" + troco);
        }
    }
}
