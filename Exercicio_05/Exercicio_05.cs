using System;
using System.Globalization;

namespace Exercicio_05
{
    internal class Exercicio_05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê as notas do aluno, e calcula a média!");
            // NOME ALUNO
            Console.Write("Digite o nome do Aluno: ");
            string? nome_aluno = Console.ReadLine();
            // Verificação se o 'nome_aluno' está VÁZIO
            if (string.IsNullOrWhiteSpace(nome_aluno))
            {
                Console.WriteLine("Por favor, insira o nome do aluno!!");
            }
            else
            {
                // Separação
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"Digite as notas do {nome_aluno}");

                // NOTA01
                Console.Write("Digite a primeira nota: ");
                string? input01 = Console.ReadLine();

                // NOTA02
                Console.Write("Digite a segunda nota: ");
                string? input02 = Console.ReadLine();

                // NOTA03
                Console.Write("Digite a terceira nota: ");
                string? input03 = Console.ReadLine();

                // Separação
                Console.WriteLine("----------------------------------------------------");

                // Configura a cultura padrão para os Estados Unidos
                CultureInfo culture = new CultureInfo("en-US");



                // Verificação dos 'input01 && input02 && input03' sendo NULOS ou VÁZIOS
                if (string.IsNullOrWhiteSpace(input01) || string.IsNullOrWhiteSpace(input02) || string.IsNullOrWhiteSpace(input03))
                {
                    Console.WriteLine("Por favor, digite notas com números inteiros!!");
                }
                // Convertendo os valores do 'input01 && input02 && input03' para DOUBLE
                // Explicando o 'AllowDecimalPoint' permite a inclusão de um ponto decimal em números, como "12.34", "0.001"
                // Já o 'culture' especifica a cultura usada para a conversão. Nesse caso estamos usando a cultura padrão dos Estados Unidos, que usa o ponto como separador decimal.
                else if (double.TryParse(input01, NumberStyles.AllowDecimalPoint, culture, out double nota01) &&
                         double.TryParse(input02, NumberStyles.AllowDecimalPoint, culture, out double nota02) &&
                         double.TryParse(input03, NumberStyles.AllowDecimalPoint, culture, out double nota03))
                {
                    double media = (nota01 + nota02 + nota03) / 3.0;
                    // N2 = notação númerica indicando para exibir 2 números após a virgula somente
                    string mediaFormatada = media.ToString("N2", culture);
                    // Verificação 'aprovado'
                    if (media >= 7)
                    {
                        Console.WriteLine($"O aluno {nome_aluno}, foi aprovado!");
                        Console.WriteLine($"Com média final de: {mediaFormatada}");
                    }
                    // Verificação 'reprovado'
                    else if (media < 5)
                    {
                        Console.WriteLine($"O aluno {nome_aluno}, foi reprovado!");
                        Console.WriteLine($"Com média final de: {mediaFormatada}");
                    }
                    // Estado = 'recuperação'
                    else
                    {
                        Console.WriteLine($"O aluno {nome_aluno}, está em recuperação");
                        Console.WriteLine($"Com média final de: {mediaFormatada}");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite números válidos.");
                }
            }
        }
    }
}
