using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 13) Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP). Aplique os seguintes descontos: 
//C omum: Sem desconto
// Associado: 10 % de desconto
// VIP: 20 % de desconto
// Informe o valor final da compra. 

namespace Exercicio_13
{
    internal class Exercicio_13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula o valor final da compra com base na categoria do cliente.");
            Console.WriteLine("Pode digitar o valor com a ',' Exemplo (50,05)");
            Console.Write("Digite o valor da compra: ");
            string? inputValorDaCompra = Console.ReadLine();

            Console.WriteLine("Categoria do cliente (1 para comum, 2 para associado, 3 para VIP): ");
            string? inputCategoriaCliente = Console.ReadLine();

            // Variável para o desconto
            double desconto = 0;

            // Verificando se o inputValorDaCompra e inputCategoriaCliente não está nulo ou vazio
            if (string.IsNullOrWhiteSpace(inputValorDaCompra) && (string.IsNullOrWhiteSpace(inputCategoriaCliente)))
            {
                Console.WriteLine("Por favor, coloque um número válido!");
            }
            else if (double.TryParse(inputValorDaCompra, out double valorTotalCompra) && (int.TryParse(inputCategoriaCliente, out int categoriaCliente)))
            {
                if (categoriaCliente == 1)
                {
                    // Cliente comum: Sem desconto
                    desconto = 0;
                }
                else if (categoriaCliente == 2)
                {
                    // Cliente associado: 10% de desconto
                    desconto = 0.10;
                }
                else if (categoriaCliente == 3)
                {
                    // Cliente VIP: 20% de desconto
                    desconto = 0.20;
                }
                else
                {
                    // Categoria inválida
                    Console.WriteLine("Categoria inválida!");
                }
                // Valor final da compra aplicando o desconto
                double valorFinal = valorTotalCompra * (1 - desconto);

                // Exibe o valor final da compra
                Console.WriteLine($"O valor final da compra é: {valorFinal:C2}");
            }
        }
    }
}