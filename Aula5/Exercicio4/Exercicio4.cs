/*
Exercício 4)
ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Solicite ao usuário para inserir
um número e calcule a soma dos dígitos do
quadrado desse número. Por exemplo, se o
número fornecido for 123, calcule 123² =
15129 e então a soma dos seus dígitos: 1 +
5 + 1 + 2 + 9 = 18.
*/

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 4 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.WriteLine("");

int num, resposta, somaD;

Console.Write("Insira um número: ");
num = Convert.ToInt32(Console.ReadLine());

resposta = num * num;  // Calcula o quadrado do número

somaD = 0;  // Inicializa acumulador da soma dos dígitos

// Loop para extrair e somar cada dígito do quadrado
while (resposta > 0)
{
    int digito = resposta % 10;  // Extrai o último dígito
    somaD += digito;             // Adiciona à soma
    resposta /= 10;              // Remove o último dígito
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("A soma dos dígitos do quadrado é: " + somaD);
Console.ResetColor();