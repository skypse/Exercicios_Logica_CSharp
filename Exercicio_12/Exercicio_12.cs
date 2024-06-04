using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 12) Escreva um programa que leia um número e verifique se ele é maior que 100.
// Se não for, informe o dobro desse número.


namespace Exercicio_12
{
    internal class Exercicio_12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que leia um número e verifique se ele é maior que 100. Se não for, dobra esse número.");

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
                if (numero > 100)
                {
                    Console.WriteLine("O número informado é maoir a 100");
                }
                else
                {
                    Console.WriteLine($"O número por não ser maior que 100 será dobrado agora ele tem o valor de: {numero * 2}");
                }
            }
            else
            {
                Console.WriteLine("Por favor, coloque um número válido!");
            }
        }
    }
}
