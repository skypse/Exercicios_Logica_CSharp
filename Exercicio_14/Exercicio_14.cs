using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 14) Escreva um programa que leia um número e informe se ele é positivo ou negativo.
// Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado.

namespace Exercicio_14
{
    internal class Exercicio_14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informa se é positivo ou negativo; Postivo = calcule a raiz quadrada; Negativo = informe o número ao quadrado");

            Console.Write("Digite um número: ");
            string? inputNumero = Console.ReadLine();

            // Verificando se o inputValorDaCompra e inputCategoriaCliente não está nulo ou vazio
            if (string.IsNullOrWhiteSpace(inputNumero))
            {
                Console.WriteLine("Por favor, coloque um número válido!");
            }
            else if (double.TryParse(inputNumero, out double numero))
            {
                if (numero >= 0)
                {
                    double raizQuadrada = Math.Sqrt(numero);
                    Console.WriteLine($"O número é positivo. A raiz quadrada de {numero} é {raizQuadrada:F2}.");
                }
                {
                    double quadrado = Math.Pow(numero, 2);
                    Console.WriteLine($"O número é negativo. O quadrado de {numero} é {quadrado:F2}.");
                }
            }
        }
    }
}
