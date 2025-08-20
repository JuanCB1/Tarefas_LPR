/*
Exercício 4) MATRIZ Crie um algoritmo que
leia duas matrizes A e B, de tamanho 3x3, e
calcule A*B. Dica abaixo:
*/

// Declaração das três matrizes 3x3
int[,] A = new int[3, 3];
int[,] B = new int[3, 3];
int[,] C = new int[3, 3];

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 4 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Digite os elementos da matriz A (3x3):");
Console.ResetColor();

// Lê os elementos da matriz A
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"A[{i},{j}]: ");
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nDigite os elementos da matriz B (3x3):");
Console.ResetColor();

// Lê os elementos da matriz B
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"B[{i},{j}]: ");
        B[i, j] = int.Parse(Console.ReadLine());
    }
}

// Multiplicação das matrizes A e B
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        C[i, j] = 0; // Inicializa o elemento
        // Calcula o produto escalar linha x coluna
        for (int k = 0; k < 3; k++)
        {
            C[i, j] += A[i, k] * B[k, j];
        }
    }
}

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("\nResultado da multiplicação A * B (matriz C):");
Console.ResetColor();

// Exibe a matriz resultado
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(C[i, j].ToString().PadLeft(6));
    }
    Console.WriteLine();
}