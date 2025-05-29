int[] numeros = new int[10];
int buscado, ocorrencia;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 2 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Digite 10 números inteiros:");
Console.ResetColor();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("\nDigite um número para pesquisar no vetor: ");
Console.ResetColor();

buscado = int.Parse(Console.ReadLine());

ocorrencia = 0;

Console.WriteLine($"\nProcurando o número {buscado}...");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] == buscado)
    {
        Console.WriteLine($"Encontrado na posição {i}.");
        ocorrencia++;
    }
}

if (ocorrencia > 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine($"\nO número {buscado} aparece {ocorrencia} vez(es) no vetor.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine($"\nO número {buscado} não foi encontrado no vetor.");
    Console.ResetColor();
}