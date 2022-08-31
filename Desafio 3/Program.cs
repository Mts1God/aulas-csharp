using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("===============");
            Console.WriteLine("Calculo da Área");
            Console.WriteLine("===============");
            double largura;
            double comprimento;
            double valordom2;
            double area;
            double valorTotal;
            Console.WriteLine("valor da largura do terreno");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do comprimento");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do m²");
            valordom2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = largura * comprimento;
            valorTotal = area * valordom2;
            Console.Clear();
            Console.WriteLine("============ Resutados ==========");
            Console.WriteLine("Area do terreno é: " + area.ToString("F2"), CultureInfo.InvariantCulture + "m²");
            Console.WriteLine("valor total do terreno é R$: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
