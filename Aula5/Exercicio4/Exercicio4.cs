Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 4 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.WriteLine("");

int num, resposta ,somaD;

Console.Write("Insira um número: ");
num = Convert.ToInt32(Console.ReadLine());

resposta = num * num;

somaD = 0;

while (resposta > 0)
{
    int digito = resposta % 10;
    somaD += digito;
    resposta /= 10;
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("A soma dos dígitos do quadrado é: " + somaD);
Console.ResetColor();