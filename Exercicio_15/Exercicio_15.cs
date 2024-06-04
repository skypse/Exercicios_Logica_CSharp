using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 15) Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria: 
// Abaixo do peso: IMC < 18.5
// Peso normal: 18.5 <= IMC < 24.9
// Sobrepeso: 25 <= IMC < 29.9
// Obesidade grau I: 30 <= IMC < 34.9
// Obesidade grau II: 35 <= IMC < 39.9
// Obesidade grau III: IMC >= 40

namespace Exercicio_15
{
    internal class Exercicio_15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê o peso e altura de uma pessoa e informa categoria do IMC");

            Console.Write("Digite o peso em KG (Exemplo = 65): ");
            string? inputKG = Console.ReadLine();

            Console.Write("Digite a altura em M (Exemplo = 1.75) : ");
            string? inputAltura = Console.ReadLine();

            // Verificando se o inputKG e inputAltura não está nulo ou vazio
            if (string.IsNullOrWhiteSpace(inputKG) && (string.IsNullOrWhiteSpace(inputAltura)))
            {
                Console.WriteLine("Por favor, coloque um número válido!");
            }
            // Converter 'string' para 'float' | E setando para que utilize os padrões de separacão de número usando o `.`
            else if (double.TryParse(inputKG,NumberStyles.Float, CultureInfo.InvariantCulture, out double peso) && double.TryParse(inputAltura, NumberStyles.Float, CultureInfo.InvariantCulture, out double altura))
            {
                // IMC
                double imc = peso / (altura * altura);
                Console.WriteLine($"Seu IMC é: {imc:F2}");

                string categoria;

                if (imc < 18.5)
                {
                    categoria = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc < 24.9)
                {
                    categoria = "Peso normal";
                }
                else if (imc >= 25 && imc < 29.9)
                {
                    categoria = "Sobrepeso";
                }
                else if (imc >= 30 && imc < 34.9)
                {
                    categoria = "Obesidade grau I";
                }
                else if (imc >= 35 && imc < 39.9)
                {
                    categoria = "Obesidade grau II";
                }
                else
                {
                    categoria = "Obesidade grau III";
                }
                // Categoria do IMC
                Console.WriteLine($"Categoria: {categoria}");
            }
        }
    }
}