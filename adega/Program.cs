using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Adega da Sul---------------");
            Console.WriteLine();
            Console.WriteLine("----------------Dados do Usuário-------------");
            Console.Write("Digite seu Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu Saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("----------------lista de Produtos-------------");
            int whisky = 99, Vodka = 30, Rum = 40, Licor = 50, Energetico = 12, Gin = 100, Cerveja = 10, Agua = 2, Água_de_coco = 10, Gelo = 20, Gelo_de_sabor = 3, Suco = 5;
            string[] nomes = new string[12] { "[1] whisky = R$" + whisky, "[2] Vodka = R$ " + Vodka, "[3] Rum = R$ " + Rum, "[4] Licor = R$ " + Licor, "[5] Energetico = R$ " + Energetico, "[6] Gin = R$ " + Gin, "[7] Cerveja = R$ " + Cerveja, "[8] Água = R$ " + Agua, "[9] Água de coco = R$ " + Água_de_coco, "[10] Gelo = R$ " + Gelo, "[11] Gelo de sabor = R$ " + Gelo_de_sabor, "[12] Suco = R$ " + Suco };
            for (int cont = 0; cont < nomes.Length; cont++)
            {
                Console.WriteLine(nomes[cont]);
            }
            Console.WriteLine("----------------Dados do Produto-------------");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do Produto: ");
            string nomedoproduto = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            double valordoproduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double SaldoFinal = saldo - valordoproduto;
            bool compraRealizada = SaldoFinal >= 0;
            Console.WriteLine("------------------Resultado---------------------");
            if (compraRealizada)
            {
                Console.WriteLine("Compra realizada.");
            }
            else
            {
                Console.WriteLine("Compra não realizada.");
            }
            Console.ReadKey();

        }
    }
}
