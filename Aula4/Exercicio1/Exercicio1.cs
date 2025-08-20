/*
Exercício 1) C#
Fazer um programa para ler um número
inteiro, e depois dizer se este número é par
ou não.
*/

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 1 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.WriteLine("");

// Variável para armazenar o número
int num;

// Lê o número do usuário
Console.Write("Digite um número inteiro: ");
num = Convert.ToInt32(Console.ReadLine());

// Verifica se é par ou ímpar usando operador módulo
if (num % 2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("O número é PAR.");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("O número é ÍMPAR.");
}
Console.ResetColor();