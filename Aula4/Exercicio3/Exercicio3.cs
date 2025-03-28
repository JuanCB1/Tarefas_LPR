Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 3 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Guerreiro");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Mago");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Arqueiro");
Console.ResetColor();

Console.WriteLine("");

string classe;
Console.Write("Digite o nome da classe desejada: ");
classe = Console.ReadLine();

switch (classe)
{
    case "Guerreiro":
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nClasse: Guerreiro");
        Console.WriteLine("Habilidades:");
        Console.WriteLine("- Ataque Pesado");
        Console.WriteLine("- Defesa Total");
        break;
    case "Mago":
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nClasse: Mago");
        Console.WriteLine("Habilidades:");
        Console.WriteLine("- Bola de Fogo");
        Console.WriteLine("- Escudo de Gelo");
        break;
    case "Arqueiro":
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nClasse: Arqueiro");
        Console.WriteLine("Habilidades:");
        Console.WriteLine("- Flecha Precisa");
        Console.WriteLine("- Disparo Triplo");
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nOpção inválida!");
        break;
}
Console.ResetColor();
