using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 9)Escreva um programa que leia o código de um produto e informe a sua categoria: 
//1 a 10: Alimento não-perecível 
//11 a 20: Alimento perecível 
//21 a 30: Vestuário
//31 a 40: Eletrônicos
//Outros: Código inválido

namespace Exercicio_09
{
    internal class Exercicio_09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê o código de um produto e informa sua categoria");

            Console.Write("Digite o código do produto: ");
            string? input01 = Console.ReadLine();

            // Verificar se o input está vázio ou nulo
            if (string.IsNullOrWhiteSpace(input01))
            {
                Console.WriteLine("Insira algum código válido");
            }

            // Conversão de 'String' para 'Int'
            if (int.TryParse(input01, out int codigo_produto))
            {
                if (codigo_produto == 0)
                {
                    Console.WriteLine("Código Inválido!");
                }
                else if (codigo_produto <= 10)
                {
                    Console.WriteLine("Alimento Não-Perecível");
                }
                else if (codigo_produto <= 20)
                {
                    Console.WriteLine("Alimento Perecível");
                }
                else if (codigo_produto <= 30)
                {
                    Console.WriteLine("Vestuário");
                }
                else if (codigo_produto <= 40)
                {
                    Console.WriteLine("Eletrônicos");
                }
                else
                {
                    Console.WriteLine("Não existe nenhum código vinculado neste número");
                }
            }
            else
            {
                Console.WriteLine("Insira um código válido!");
            }
        }
    }
}
