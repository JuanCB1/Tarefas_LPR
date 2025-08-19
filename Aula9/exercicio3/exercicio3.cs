/*Exercício 3) RESOLVA EM C#
Construa um dicionário de X pares chave-valor onde as chaves são nomes de pessoas e os
valores são suas respectivas idades.
Encontre e imprima todos os nomes de pessoas com idade acima da média.
Encontre e imprima o nome da pessoa mais velha e o nome da pessoa mais nova.
Remova todas as pessoas com idade igual a um valor Y (fornecido pelo usuário) e imprima
o dicionário atualizado.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("-------------");
        Console.WriteLine(" Exercício 3 ");
        Console.WriteLine("-------------");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Quantas pessoas deseja cadastrar? ");
        Console.ResetColor();
        int X = int.Parse(Console.ReadLine());

        // Dicionário para armazenar Nome -> Idade
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        // Cadastro das pessoas
        for (int i = 0; i < X; i++)
        {
            // Lê o nome
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Nome da pessoa #{0}: ", i + 1);
            Console.ResetColor();
            string nome = Console.ReadLine();

            // Lê a idade
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Idade de {0}: ", nome);
            Console.ResetColor();
            int idade = int.Parse(Console.ReadLine());

            pessoas[nome] = idade; // Armazena no dicionário
        }

        // Calcula a média das idades
        double media = pessoas.Values.Average();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPessoas com idade acima da média ({0:F2}):", media);
        Console.ResetColor();
        foreach (var par in pessoas)
        {
            if (par.Value > media)
                Console.WriteLine($"{par.Key} - {par.Value} anos");
        }

        // Descobre a maior e menor idade
        int idadeMax = pessoas.Values.Max();
        int idadeMin = pessoas.Values.Min();

        // Descobre quem é a pessoa mais velha e mais nova
        string maisVelha = pessoas.First(p => p.Value == idadeMax).Key;
        string maisNova = pessoas.First(p => p.Value == idadeMin).Key;

        // Mostra os resultados
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\nPessoa mais velha: {maisVelha} ({idadeMax} anos)");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"Pessoa mais nova: {maisNova} ({idadeMin} anos)");
        Console.ResetColor();

        // Permite remover pessoas com uma idade específica
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("\nInforme uma idade para remover as pessoas que têm essa idade: ");
        Console.ResetColor();
        int Y = int.Parse(Console.ReadLine());

        // Busca todas as pessoas com a idade escolhida
        var paraRemover = pessoas.Where(p => p.Value == Y).Select(p => p.Key).ToList();

        foreach (var nome in paraRemover)
        {
            pessoas.Remove(nome);
        }

        // Mostra o dicionário atualizado
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\nDicionário atualizado:");
        Console.ResetColor();
        foreach (var par in pessoas)
        {
            Console.WriteLine($"{par.Key} - {par.Value} anos");
        }
    }
}
