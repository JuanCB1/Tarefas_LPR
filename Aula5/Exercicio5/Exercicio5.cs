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

hs = hd * 5;
total = 0;
dia = 0;

while (total < 1000)
{
    total += hs;
    dia += 5;
}

semana = dia / 5;
meses = semana / 4.5;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Para alcançar 1000 horas de treinamento serão necessários:");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{dia} dias");
Console.WriteLine($"{semana} semanas");
Console.WriteLine($"{meses:F2} meses");
Console.ResetColor();
