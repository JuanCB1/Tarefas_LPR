using System;
using System.Collections.Generic;

class Program
{
    class Nome
    {
        public string Texto { get; set; }
        public int Tamanho { get { return Texto.Length; } }

        public Nome(string texto)
        {
            Texto = texto;
        }
    }

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("-------------");
        Console.WriteLine(" Exercício 1 ");
        Console.WriteLine("-------------");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Insira a quantidade de nomes na lista");
        Console.ResetColor();
        int quantidade = int.Parse(Console.ReadLine());
        List<Nome> nomes = new List<Nome>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"Nome {i + 1}: ");
            Console.ResetColor();
            nomes.Add(new Nome(Console.ReadLine()));
        }

        List<Nome> nomesRestantes = new List<Nome>(nomes);

        while (nomesRestantes.Count > 0)
        {
            List<int> tamanhosUsados = new List<int>();
            List<Nome> linha = new List<Nome>();

            for (int i = 0; i < nomesRestantes.Count; i++)
            {
                var nome = nomesRestantes[i];

                if (!tamanhosUsados.Contains(nome.Tamanho))
                {
                    linha.Add(nome);
                    tamanhosUsados.Add(nome.Tamanho);
                    nomesRestantes.RemoveAt(i);
                    i--;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Lista em ordem crescente ");
            Console.WriteLine("--------------------------");
            Console.ResetColor();

            linha = linha.OrderBy(n => n.Tamanho).ToList();
            Console.WriteLine(string.Join(" , ", linha.Select(n => n.Texto)));
        }
    }
}
