using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace aula_29._08._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
## OPERADORES LÓGICOS ##
            operador E(&&) -Retorna true se for verdadeiro dos dois lados: 
            true && true = true
            true && false = false
            false && true = false
            false && false = false



            operador OU(||) - Retorna true se pelomenos um dos lados for verdadeiro:
            true || true = true
            true || false = true
            false || true = true
            false || false = false



            operador NÃO(!) - Retorna o oposto:
            !true = false
            !false = true

            -- EXEMPLO--



            var a = 3;
            var b = 5;

            // Operador lógico E
            a > 2 && b > 4 // A = Verdadeiro  B = Verdadeiro ** Retorna True
            a > 4 && b > 4 // A = Falso  B = Verdadeiro ** Retorna False
            a > 2 && b > 6 // A = Verdadeiro  B = Falso ** Retorna False
            a > 4 && b > 6 // A = Falso  B = Falso ** Retorna False

            // Operador lógico OU
            a > 2 || b > 4}"); // A = Verdadeiro  B = Verdadeiro ** Retorna True
            a > 4 || b > 4}"); // A = Falso  B = Verdadeiro ** Retorna True
            a > 2 || b > 6}
"); // A = Verdadeiro  B = Falso ** Retorna True
            a > 4 || b > 6}"); // A = Falso  B = Falso ** Retorna False

            // Operador lógico NÃO
            !(a != b) // Retorna False

            ## LAÇO DE CONDIÇÃO SWITCH (escolha) ##

            sintaxe:
switch (variável)
{
    case 1:
        faça alguma coisa;
        break;
    case 2:
        faça outra coisa;
        break;
    default:
        senão, faça isso;
        break;
}

--EXEMPLO--

var diaDaSemana = Console.ReadLine();

switch (diaDaSemana)
{
    case "1":
        Console.WriteLine("Domingo");
        break;
    case "2":
        Console.WriteLine("Segunda-feira");
        break;
    case "3":
        Console.WriteLine("Terça-feira");
        break;
    case "4":
        Console.WriteLine("Quarta-feira");
        break;
    case "5":
        Console.WriteLine("Quinta-feira");
        break;
    case "6":
        Console.WriteLine("Sexta-feira");
        break;
    case "7":
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Digite um número entre 1 e 7");
        break;
}


## LAÇO DE REPETIÇÃO WHILE (enquanto) ##

sintaxe:
while (condição)
{
    Código a ser executado.
}

--EXEMPLO--

var cont = 1;

// Contagem de 1 à 10
while (cont <= 10)
{
    Console.WriteLine(cont);
    cont++; // incrementa +1 no valor da variável cont
}

## LAÇO DE REPETIÇÃO DO WHILE (faça enquanto) ##

sintaxe:
do
{
    Código a ser executado.
}
while (condição);

--EXEMPLO--

var cont = 1;

// Contagem de 1 à 10
do
{
    Console.WriteLine(cont);
    cont++; // incrementa +1 no valor da variável cont
}
while (cont <= 10);

## PERCORRER VETORES COM O LAÇO WHILE ##

var indice = 0;
var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };

// Jeito não prático: 
// Console.WriteLine(versoes[0]);
// Console.WriteLine(versoes[1]);
// Console.WriteLine(versoes[2]);
// Console.WriteLine(versoes[3]);


while (indice < versoes.Length) // versoes.length é a quantidade de item que o vetor possui.
{
    Console.WriteLine(versoes[indice]); // acessa o vetor "versoes" pelo valor atual do indice.
    indice++;
}

## PERCORRENDO VETORES COM O LAÇO FOR ##

var carros = new[] { "Celta", "Gol", "Corsa", "Renegade", "Fusca", "Palio", "UP" };

for (int indice = 0; indice < carros.Length; indice++)
{
    Console.WriteLine(carros[indice]);
}

## PERCORRENDO VETORES COM O LAÇO FOREACH ##

foreach (var carro in carros)
{
    Console.WriteLine(carro);
}
        }
    }
}
