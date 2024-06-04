using System;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 7) Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos),
// adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais). 

namespace Exercicio_07
{
    internal class Exercicio_07
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Programa que lê a idade da pessoa e informa classificação");

            Console.Write("Digite sua idade: ");
            string? input01 = Console.ReadLine();

            // Verificando se o input não está nulo ou vázio
            if (string.IsNullOrWhiteSpace(input01))
            {
                Console.WriteLine("Porfavor, coloque uma idade válida!");
            }
            // Converter string para int
            else if (int.TryParse(input01, out int idade))
            {
                if (idade < 0)
                {
                    Console.WriteLine("Idade inválida");
                }
                else if (idade <= 12)
                {
                    Console.WriteLine("A idade digitada cai na classificação de 'Criança' (0 à 12 anos)");
                }
                else if (idade <= 17)
                {
                    Console.WriteLine("A idade digitada cai na classificação de 'Adolescente' (13 à 17 anos)");
                }
                else if (idade <= 59)
                {
                    Console.WriteLine("A idade digitada cai na classificação de 'Adulto' (17 à 59 anos)");
                }
                else
                {
                    Console.WriteLine("A idade digitada cai na classificação de 'Idoso' (60 à  anos)");
                }
            }
        }
    }
}
