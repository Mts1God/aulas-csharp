using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Fazer um programa para calcular o aumento de salario de um funcionario x exibindo
               - % de aumento do salário
               - Aumento em Reais
               - Salário Final
            */

            Console.WriteLine("======================================");
            Console.WriteLine("===Programa de aumento de salário===");
            Console.WriteLine("======================================");

            Console.WriteLine("Insira o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionario: ");
            double SalarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual % de aumento deseja para o funcionario " + nome + " ?");
            double perc = double.Parse(Console.ReadLine());
            double percemdecimal = perc / 100;

            double SalarioFinal = SalarioInicial + SalarioInicial * percemdecimal;
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("===Resultado===");
            Console.WriteLine("======================================");

            Console.WriteLine("Salario Inicial" + "R$" + SalarioInicial);
            Console.WriteLine("Percentual de aumento :" + perc + "%");
            Console.WriteLine("Salario Final: " + "R$" + SalarioFinal);
            Console.WriteLine("Salario Final: " + "R$" + SalarioFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
