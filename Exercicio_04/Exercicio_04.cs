using System;
// Autor: Gabriel do Amaral Alves
// Data: 01/06/24
// Enunciado: 4) Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido.
// Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado.

namespace Exercicio_04
{
    internal class Exercicio_04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê os 3 lados de um triângulo, e verifica se eles formam um triângulo válido!");
            // LADO 01
            Console.Write("Digite o primeiro lado do triângulo: ");
            string? input01 = Console.ReadLine();

            // LADO 02
            Console.Write("Digite o segundo lado do triângulo: ");
            string? input02 = Console.ReadLine();

            // LADO 0
            Console.Write("Digite o segundo lado do triângulo: ");
            string? input03 = Console.ReadLine();

            // Verificação dos 'input01 && input02 && input03' sendo NULOS ou VÁZIOS
            if (input01 == null || input01.Trim() == "" || input02 == null || input02.Trim() == "" || input03 == null || input03.Trim() == "")
            {
                Console.WriteLine("Por favor, digite lados com números inteiros!!");
            }
            // Convertendo valores dos 'input01 && input02 && input03' de STRING para INT
            else if (int.TryParse(input01, out int lado01) && int.TryParse(input02, out int lado02) && int.TryParse(input03, out int lado03))
            {
                // Verificar os lados que formam um triâgulo válido chamando uma função
                if (VerificarTriangulo(lado01, lado02, lado03))
                {
                    Console.WriteLine("Os lados formam um triângulo válido");
                }
                else
                {
                    Console.WriteLine("Os lados não formam um triângulo válido!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite números inteiros válidos.");
            }
        }
        // Uma função que retorna valor booleano dos parâmetros (condições) passadas!
        // Para verificar se os lados formam um triângulo válido
        private static bool VerificarTriangulo(int lado01, int lado02, int lado03)
        {
            // Parâmetros da função
            bool condicao1 = lado01 + lado02 > lado03;
            bool condicao2 = lado01 + lado03 > lado02;
            bool condicao3 = lado02 + lado03 > lado01;

            return condicao1 && condicao2 && condicao3;
        }
    }
}
