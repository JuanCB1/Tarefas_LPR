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

        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        for (int i = 0; i < X; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Nome da pessoa #{0}: ", i + 1);
            Console.ResetColor();
            string nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Idade de {0}: ", nome);
            Console.ResetColor();
            int idade = int.Parse(Console.ReadLine());

            pessoas[nome] = idade;
        }

        double media = pessoas.Values.Average();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPessoas com idade acima da média ({0:F2}):", media);
        Console.ResetColor();
        foreach (var par in pessoas)
        {
            if (par.Value > media)
                Console.WriteLine($"{par.Key} - {par.Value} anos");
        }

        int idadeMax = pessoas.Values.Max();
        int idadeMin = pessoas.Values.Min();

        string maisVelha = pessoas.First(p => p.Value == idadeMax).Key;
        string maisNova = pessoas.First(p => p.Value == idadeMin).Key;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\nPessoa mais velha: {maisVelha} ({idadeMax} anos)");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"Pessoa mais nova: {maisNova} ({idadeMin} anos)");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("\nInforme uma idade para remover as pessoas que têm essa idade: ");
        Console.ResetColor();
        int Y = int.Parse(Console.ReadLine());

        var paraRemover = pessoas.Where(p => p.Value == Y).Select(p => p.Key).ToList();

        foreach (var nome in paraRemover)
        {
            pessoas.Remove(nome);
        }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\nDicionário atualizado:");
        Console.ResetColor();
        foreach (var par in pessoas)
        {
            Console.WriteLine($"{par.Key} - {par.Value} anos");
        }
    }
}
