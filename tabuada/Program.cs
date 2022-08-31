using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            int n = int.Parse(Console.ReadLine());


            Console.Clear();

            Console.WriteLine("=============");
            Console.WriteLine("T A B U A D A");
            Console.WriteLine("=============");

            Console.WriteLine(" 01 x " + n + "=" + (1 * n));
            Console.WriteLine(" 02 x " + n + "=" + (2 * n));
            Console.WriteLine(" 03 x " + n + "=" + (3 * n));
            Console.WriteLine(" 04 x " + n + "=" + (4 * n));
            Console.WriteLine(" 05 x " + n + "=" + (5 * n));
            Console.WriteLine(" 06 x " + n + "=" + (6 * n));
            Console.WriteLine(" 07 x " + n + "=" + (7 * n));
            Console.WriteLine(" 08 x " + n + "=" + (8 * n));
            Console.WriteLine(" 09 x " + n + "=" + (9 * n));
            Console.WriteLine(" 10 x " + n + "=" + (10 * n));
        }
    }
}
