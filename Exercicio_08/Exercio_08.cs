using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 03/06/24
// Enunciado: 8) Escreva um programa que leia a nota de um aluno e converta-a para conceito:
// A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3). 

namespace Exercicio_08
{
    internal class Exercio_08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê a nota do aluno, converte em LETRAS!");
            Console.WriteLine("A = (nota >= 9), B = (7 <= nota < 9), C = (5 <= nota < 7), D = (3 <= nota < 5) e F = (nota < 3)");

            // Armazenar Nome
            Console.Write("Digite o nome do aluno: ");
            string? nome_aluno = Console.ReadLine();

            // Armazenar Nota
            Console.Write($"Digite a nota do {nome_aluno}: ");
            string? input01 = Console.ReadLine();

            // Verificação se 'nome_aluno' = Nullo ou Vázio e o mesmo para 'input01'
            if (string.IsNullOrWhiteSpace(nome_aluno) || string.IsNullOrWhiteSpace(input01))
            {
                Console.WriteLine("Nenhum campo pode deixar de ser preenchido!");
            }
            // Converter 'string' para 'float' | E setando para que utilize os padrões de separacão de número usando o `.`
            else if (float.TryParse(input01,NumberStyles.Float, CultureInfo.InvariantCulture, out float nota))
            {
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Nota inválida, a nota digitada deve estar entre 0 e 10");
                }
                // CONCEITO A
                else if (nota >= 9)
                {
                    Console.WriteLine($"Aluno, {nome_aluno} se encaixa no Conceito A");
                }
                // CONCEITO B
                else if (nota >= 7)
                {
                    Console.WriteLine($"Aluno, {nome_aluno} se encaixa no Conceito B");
                }
                // CONCEITO C
                else if (nota >= 5)
                {
                    Console.WriteLine($"Aluno, {nome_aluno} se encaixa no Conceito C");
                }
                // CONCEITO D
                else if (nota >= 3)
                {
                    Console.WriteLine($"Aluno, {nome_aluno} se encaixa no Conceito D");
                }
                // CONCEITO F
                else
                {
                    Console.WriteLine($"Aluno, {nome_aluno} se encaixa no Conceito F");
                }
            }
            else
            {
                Console.WriteLine("Porfavor, coloque uma noa válida!");
            }
        }
    }
}
