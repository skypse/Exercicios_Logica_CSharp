using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 6) Escreva um programa que leia um ano e verifique se ele é bissexto.
// Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400. 

namespace Exercicio_06
{
    internal class Exercicio_06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê e verifica se o ano é bissexto");

            Console.Write("Digite algum ano (inteiro), para a verificação: ");
            string? input01 = Console.ReadLine();

            // Verificação se o input está null
            if (string.IsNullOrWhiteSpace(input01))
            {
                Console.WriteLine("Insira um valor válido!");
            }

            // Converter de 'String' para 'Int'
            if (int.TryParse(input01, out int ano))
            {   // Verificação do ano Bissexto
                if ((ano % 4 == 0 && ano % 100 != 0))
                {
                    Console.WriteLine($"O {ano} é um ano bissexto!");
                }
                else
                {
                    Console.WriteLine($"O {ano} é um ano comum!");
                }
            }
        }
    }
}
