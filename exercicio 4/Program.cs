using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            // Adição
            int Adicao = a + b;
            Console.WriteLine("Adição:" + Adicao);
            // Subtração
            int Subtracao = a - b;
            Console.WriteLine("Subtração:" + Subtracao);
            // Multiplicação
            int Multiplicacao = a * b;
            Console.WriteLine("Multiplicação:" + Multiplicacao);
            // Divisão
            int Divisao = a / b;
            Console.WriteLine("Divisão:" + Divisao);
            // Resto  
            int Resto = a % b;
            Console.WriteLine("Resto:" + Resto);
            // Incremento
            int Incremento1 = a;
            Incremento1 = 10 + 1;
            Console.WriteLine("Incremento 1: " + Incremento1);
            int Incremento2 = b;
            Incremento2 = 20 + 1;
            Console.WriteLine("Incremento 2: " + Incremento2);
            // Decremento
            int Decremento1 = a;
            Decremento1 = 10 - 1;
            Console.WriteLine("Decremento 1: " + Decremento1);
            int Decremento2 = b;
            Decremento2 = 20 - 1;
        }
    }
}
