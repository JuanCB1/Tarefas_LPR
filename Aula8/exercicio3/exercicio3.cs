struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}
class Program
{
    static Heroi[] herois = new Heroi[5];
    static int totalHerois = 0;
    static Heroi[] equipe = new Heroi[3];
    static int totalHeroisEquipe = 0;

    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("-------------");
        Console.WriteLine(" Exercício 3 ");
        Console.WriteLine("-------------");
        Console.ResetColor();

        int opcao;
        do
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=== Sistema de Seleção de Heróis Marvel ===");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. Cadastrar Herói");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("2. Selecionar Equipe");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("3. Exibir Equipe");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("4. Sair");
            Console.ResetColor();
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarHeroi();
                    break;
                case 2:
                    SelecionarEquipe();
                    break;
                case 3:
                    ExibirEquipe();
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 4);
    }

    static void CadastrarHeroi()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("------------------");
        Console.WriteLine(" Cadastre o Herói ");
        Console.WriteLine("------------------");
        Console.ResetColor();

        if (totalHerois >= 5)
        {
            Console.WriteLine("Limite de heróis cadastrados atingido.");
            return;
        }

        Console.Write("Nome do herói: ");
        herois[totalHerois].Nome = Console.ReadLine();
        Console.Write("Poder do herói: ");
        herois[totalHerois].Poder = Console.ReadLine();
        Console.Write("Pontuação do herói: ");
        herois[totalHerois].Pontuacao = int.Parse(Console.ReadLine());
        totalHerois++;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Herói cadastrado com sucesso!");
        Console.ResetColor();
    }

    static void SelecionarEquipe()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("-------------------");
        Console.WriteLine(" Selecionar Equipe ");
        Console.WriteLine("-------------------");
        Console.ResetColor();

        if (totalHerois < 3)
        {
            Console.WriteLine("É necessário cadastrar pelo menos 3 heróis para formar uma equipe!");
            return;
        }

        totalHeroisEquipe = 0;
        Console.WriteLine("\n--- Heróis Cadastrados ---");
        for (int i = 0; i < totalHerois; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].Nome} (Poder: {herois[i].Poder}, Pontuação: {herois[i].Pontuacao})");
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Selecione 3 heróis para sua equipe:");
        Console.ResetColor();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nEscolha o número do {i + 1}º herói da equipe: ");
            int indice = int.Parse(Console.ReadLine()) - 1;
            if (indice >= 0 && indice < totalHerois)
            {
                equipe[i] = herois[indice];
                totalHeroisEquipe++;
            }
            else
            {
                Console.WriteLine("Índice inválido. Tente novamente.");
                i--;
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Equipe selecionada com sucesso!");
        Console.ResetColor();
    }
    static int CalcularPontuacaoTotal()
    {
        int total = 0;
        for (int i = 0; i < totalHeroisEquipe; i++)
        {
            total += equipe[i].Pontuacao;
        }
        return total;
    }

    static void ExibirEquipe()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("------------------");
        Console.WriteLine("      Equipe      ");
        Console.WriteLine("------------------");
        Console.ResetColor();

        if (totalHeroisEquipe == 0)
        {
            Console.WriteLine("Nenhuma equipe foi formada ainda.");
            return;
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("=== Equipe Selecionada ===");
        Console.ResetColor();
        
        for (int i = 0; i < totalHeroisEquipe; i++)
        {
            Console.WriteLine($"- {equipe[i].Nome} (Poder: {equipe[i].Poder}, Pontuação: {equipe[i].Pontuacao})");
        }
        Console.WriteLine($"\nPontuação Total da Equipe: {CalcularPontuacaoTotal()}");
    }
}
