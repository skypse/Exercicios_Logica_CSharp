using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 10) Escreva um programa que leia dois números e uma operação
// (adição, subtração, multiplicação ou divisão) e realize a operação correspondente.

namespace Exercicio_10
{
    internal class Exercicio_10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que leia dois números e uma operação (adicao, subtracao, multiplicacao ou divisao)");

            // Operações
            Console.Write("Digite o nome da operação que você queira realizar: ");
            string? operacao = Console.ReadLine();

            // Input01
            Console.Write("Digite o primeiro número: ");
            string? input01 = Console.ReadLine();

            // Input02
            Console.Write("Digite o segundo número: ");
            string? input02 = Console.ReadLine();

            // Verificando se há algo nulo ou vázio
            if (string.IsNullOrWhiteSpace(operacao) || (string.IsNullOrWhiteSpace(input01)) || (string.IsNullOrWhiteSpace(input02)))
            {
                Console.WriteLine("Não podem haver campos nulos!");
            }
            // Convertendo os inputs para int
            if (int.TryParse(input01, out int numero01) && (int.TryParse(input02, out int numero02)))
            {
                if (operacao == "adicao" || operacao == "adição")
                {
                    int resultado = numero01 + numero02;
                    Console.WriteLine($"A soma dos números digitados são: {resultado}");
                }
                else if (operacao == "subtracao" || operacao == "subtração")
                {
                    int resultado = numero01 - numero02;
                    Console.WriteLine($"A subtração dos números digitados são: {resultado}");
                }
                else if (operacao == "multiplicacao" || operacao == "multiplicação")
                {
                    int resultado = numero01 * numero02;
                    Console.WriteLine($"A multiplicação dos números digitados são: {resultado}");
                }
                else if (operacao == "divisao" || operacao == "divisão")
                {
                    int resultado = numero01 / numero02;
                    Console.WriteLine($"A divisão dos números digitados são: {resultado}");
                }
                else
                {
                    Console.WriteLine("Não existe nenhuma operação cadastrada com este nome!");
                }
            }
            else
            {
                Console.WriteLine("O valor digitado não corresponde a nenhuma das opções");
            }
        }
    }
}
