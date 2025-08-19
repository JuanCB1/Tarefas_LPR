/* Exercício 1) RESOLVA EM C#
Construa uma lista de X nomes aleatórios
A saída deve ser mostrada em uma ou mais linhas. Cada linha tem uma lista de
nomes ordenados por tamanho, começando com o menor. Em cada linha,
só pode ser mostrado um nome de determinado tamanho, e os demais
nomes com o mesmo tamanho devem ser apresentados nas linhas seguintes. Você
deve seguir a ordem de digitação.
*/

using System;
using System.Collections.Generic;

class Program
{
    class Nome
    {
        public string Texto { get; set; }
        public int Tamanho { get { return Texto.Length; } } // Propriedade que calcula o tamanho do nome

        public Nome(string texto)
        {
            Texto = texto; // Construtor que recebe o nome digitado
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
        List<Nome> nomes = new List<Nome>(); // Lista principal de nomes

        // Laço para ler todos os nomes
        for (int i = 0; i < quantidade; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"Nome {i + 1}: ");
            Console.ResetColor();
            nomes.Add(new Nome(Console.ReadLine())); // Adiciona o nome na lista
        }

        // Cria uma cópia da lista de nomes para controlar os que ainda não foram usados
        List<Nome> nomesRestantes = new List<Nome>(nomes);

        // Enquanto ainda houver nomes não exibidos
        while (nomesRestantes.Count > 0)
        {
            List<int> tamanhosUsados = new List<int>(); // Guarda os tamanhos já usados na linha
            List<Nome> linha = new List<Nome>(); // Lista de nomes da linha atual

            // Percorre os nomes restantes
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

            // Ordena os nomes da linha pelo tamanho
            linha = linha.OrderBy(n => n.Tamanho).ToList();
            Console.WriteLine(string.Join(" , ", linha.Select(n => n.Texto)));
        }
    }
}
