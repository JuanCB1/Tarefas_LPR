/*
Exercício 5)
ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Crie um programa que simula
o treinamento de um Jedi. O usuário deve
inserir o número de horas de treinamento
por dia. O programa deve calcular o total
de horas de treinamento em uma semana,
desconsiderando sábados e domingos, e
informar quantos dias, semanas e meses
seriam necessários para alcançar o total de
1000 horas de treinamento. Considere 1
mês = 4,5 semanas.

*/
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 5 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.WriteLine("");

int hd, hs, total, dia, semana;
double meses;

Console.Write("Insira o número de horas de treinamento por dia: ");
hd = Convert.ToInt32(Console.ReadLine());

hs = hd * 5;  // Horas por semana (5 dias úteis)
total = 0;    // Total de horas acumuladas
dia = 0;      // Contador de dias

// Loop para calcular quantos dias são necessários para 1000 horas
while (total < 1000)
{
    total += hs;  // Adiciona horas semanais ao total
    dia += 5;     // Adiciona 5 dias (uma semana)
}

// Converte dias em semanas e meses
semana = dia / 5;        // Divide por 5 dias úteis
meses = semana / 4.5;    // Aproximadamente 4.5 semanas por mês

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Para alcançar 1000 horas de treinamento serão necessários:");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{dia} dias");
Console.WriteLine($"{semana} semanas");
Console.WriteLine($"{meses:F2} meses");
Console.ResetColor();