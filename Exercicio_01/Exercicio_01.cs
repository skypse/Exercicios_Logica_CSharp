using System;
// Autor: Gabriel do Amaral Alves
// Data: 01/06/24
// Enunciado: 1) Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar.

namespace Exercicio_01
{
    internal class Exercicio_01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que verifica se o número digitado é par");
            Console.Write("Digite um número inteiro: ");
            string? input = Console.ReadLine();

            // Verifica se o 'input' está NULO ou VÁZIO
            if (input == null || input.Trim() == "")
            {
                Console.WriteLine("Por favor, digite um número inteiro!!");
            }

            // Transforma o valor recebido em STRING do 'input' para INT
            else if (int.TryParse(input, out int numero))
            {
                // Verificação se é par
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"O número {numero} é par!");
                }
                // Se não for par é ímpar
                else
                {
                    Console.WriteLine($"O número {numero} é ímpar!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite dois números inteiros válidos.");
            }
        }
    }
}
