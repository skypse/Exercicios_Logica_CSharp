using System;
// Autor: Gabriel do Amaral Alves
// Data: 01/06/24
// Enunciado: 3) Escreva um programa que leia dois números inteiros e informe qual deles é o maior.

namespace Exercicio_03
{
    internal class Exercicio_03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê dois números, e informa qual deles é o maior!");

            Console.Write("Digite um número inteiro: ");
            string? input01 = Console.ReadLine();

            Console.Write("Digite mais um número inteiro: ");
            string? input02 = Console.ReadLine();

            // Verificação dos 'input01 && input02' sendo NULOS ou VÁZIOS
            if (input01 == null || input01.Trim() == "" || input02 == null || input02.Trim() == "")
            {
                Console.WriteLine("Por favor, digite dois números inteiros!!");
            }
            // Convertendo valores dos 'input01 && input02' de STRING para INT
            else if (int.TryParse(input01, out int numero01) && int.TryParse(input02, out int numero02))
            {
                if (numero01 > numero02)
                {
                    Console.WriteLine($"O número {numero01} é o maior");
                }
                else
                {
                    Console.WriteLine($"O número {numero02} é o maior");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite dois números inteiros válidos.");
            }
        }
    }
}
