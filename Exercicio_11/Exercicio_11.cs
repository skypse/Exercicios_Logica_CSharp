using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: Escreva um programa que leia um número e verifique se ele está
// no intervalo de 10 a 20 (inclusive).

namespace Exercicio_11
{
    internal class Exercicio_11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que verifica se um número está no intervalo de 10 a 20 (inclusive).");

            Console.Write("Digite um número: ");
            string? inputNumero = Console.ReadLine();

            // Verificando se o input não está nulo ou vazio
            if (string.IsNullOrWhiteSpace(inputNumero))
            {
                Console.WriteLine("Por favor, coloque um número válido!");
            }
            // Converter string para int
            else if (int.TryParse(inputNumero, out int numero))
            {
                if (numero >= 10 && numero <= 20)
                {
                    Console.WriteLine("O número está no intervalo de 10 a 20 (inclusive).");
                }
                else
                {
                    Console.WriteLine("O número NÃO está no intervalo de 10 a 20 (inclusive).");
                }
            }
            else
            {
                Console.WriteLine("Por favor, coloque um número válido!");
            }
        }
    }
}
