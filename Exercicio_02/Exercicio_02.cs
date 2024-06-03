using System;
// Autor: Gabriel do Amaral Alves
// Data: 01/06/24
// Enunciado: 2) Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero. 

namespace Exercicio_02
{
    internal class Exercicio_02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que faz a verificação se o número é: Positivo, Negativo ou Zero");
            Console.Write("Digite um número inteiro para a verificação: ");
            string? input = Console.ReadLine();

            // Verificar se o 'input' está VÁZIO ou NULO
            if (input == null || input.Trim() == "")
            {
                Console.WriteLine("Porfavor, digite um número inteiro!!");
            }
            else if (int.TryParse(input, out int numero))
            {
                if (numero < 0)
                {
                    Console.WriteLine($"O número digitado é negativo: {numero}");
                }
                else if (numero == 0)
                {
                    Console.WriteLine($"O número digitado é zero!");
                }
                else
                {
                    Console.WriteLine($"O número digitado é positivo!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite dois números inteiros válidos.");
            }
        }
    }
}
