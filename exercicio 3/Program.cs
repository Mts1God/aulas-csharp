using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo, Indentificador.
            // Declaração de variáveis.

            char primeiraLetraNome;
            string nome;
            float valor;
            double valorALTO;
            bool primeraLetraComecaT;

            // Atribuir valor as variáveis.

            primeiraLetraNome = 'M';
            nome = "Mateus";
            valor = 0.4f;
            valorALTO = 1231.45;
            primeraLetraComecaT = false;


            Console.WriteLine(primeiraLetraNome);
            Console.WriteLine(nome);
            Console.WriteLine(valor);
            Console.WriteLine(valorALTO);
            Console.WriteLine(primeraLetraComecaT);
        }
    }
}
