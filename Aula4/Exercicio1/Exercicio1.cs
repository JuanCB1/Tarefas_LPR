
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 1 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.WriteLine("");

int num;

Console.Write("Digite um número inteiro: ");
num = Convert.ToInt32(Console.ReadLine());

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