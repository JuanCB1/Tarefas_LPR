/*
Exercício 3) C#
Suponha que você está desenvolvendo um jogo
de RPG. Você é responsável por implementar a
mecânica de habilidades especiais para
diferentes classes de personagens. Cada classe
tem suas próprias habilidades especiais.
Crie um programa que permita ao jogador
escolher uma classe de personagem e, em
seguida, exiba suas habilidades especiais
correspondentes. 
*/

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-------------");
Console.WriteLine(" Exercício 3 ");
Console.WriteLine("-------------");
Console.ResetColor();

Console.WriteLine("");

// Exibe o menu de classes disponíveis
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Guerreiro");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Mago");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Arqueiro");
Console.ResetColor();

Console.WriteLine("");

// Lê a escolha do usuário
string classe;
Console.Write("Digite o nome da classe desejada: ");
classe = Console.ReadLine();

// Switch para exibir informações da classe escolhida
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
        // Caso a entrada não corresponda a nenhuma classe
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nOpção inválida!");
        break;
}
Console.ResetColor();