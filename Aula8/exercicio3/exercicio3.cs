/*Exercício 3) Retomada
Desenvolva um programa em C# que simule um sistema de seleção de heróis da
Marvel para uma equipe. O programa deve ter as seguintes funcionalidades:
a) Cadastro de Heróis:
Crie uma função chamada cadastrarHeroi que permita ao usuário
inserir o nome, poder e pontuação de um herói da Marvel. A função deve
solicitar essas informações ao usuário e armazená-las em UM STRUCT. O
programa deve permitir o cadastro de até 5 heróis.
b) Seleção de Equipe:
Crie uma função chamada selecionarEquipe que permita ao usuário
selecionar heróis para formar sua equipe. A função deve exibir os heróis
cadastrados e permitir que o usuário selecione quais heróis deseja incluir
em sua equipe. O usuário deve ser capaz de selecionar três heróis para
sua equipe.
c) Pontuação Total da Equipe:
Crie uma função chamada calcularPontuacaoTotal que calcule a
pontuação total da equipe com base nos heróis selecionados. A
pontuação total da equipe deve ser a soma das pontuações individuais de
cada herói selecionado.
d) Exibição da Equipe:
Crie uma função chamada exibirEquipe que exiba os heróis
selecionados para a equipe, seu poder e a pontuação total da equipe.
e) Menu:
Crie uma função chamada menuPrincipal que exiba um menu com as
opções disponíveis para o usuário (cadastro de heróis, seleção de equipe,
exibição da equipe e sair do programa). O usuário deve poder escolher
uma das opções do menu e o programa deve executar a funcionalidade
correspondente.
Requisitos Adicionais:
● O programa deve continuar em execução até que o usuário escolha
a opção de sair.
● Utilize STRUCTS para armazenar as informações dos heróis e da
equipe.
● Não utilize classes ou listas! Pode (ou será que deve) utilizar vetores. 
*/

struct Heroi // Definição da struct Heroi que representa cada herói
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}
class Program
{
    static Heroi[] herois = new Heroi[5]; // Vetor para armazenar até 5 heróis cadastrados
    static int totalHerois = 0; // Contador de heróis cadastrados
    static Heroi[] equipe = new Heroi[3]; // Vetor para armazenar até 3 heróis da equipe
    static int totalHeroisEquipe = 0; // Contador de heróis na equipe

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
            // Exibe as opções do menu
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
            opcao = int.Parse(Console.ReadLine()); // Lê a opção digitada pelo usuário

            // Executa a ação conforme a opção
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
                    Console.WriteLine("Opção inválida."); // Se o usuário digitar algo errado
                    break;
            }

        } while (opcao != 4); // Repete até escolher sair
    }

    static void CadastrarHeroi() // Função para cadastrar heróis
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("------------------");
        Console.WriteLine(" Cadastre o Herói ");
        Console.WriteLine("------------------");
        Console.ResetColor();

        // Verifica se já atingiu o limite de heróis
        if (totalHerois >= 5)
        {
            Console.WriteLine("Limite de heróis cadastrados atingido.");
            return;
        }

        // Lê os dados do herói
        Console.Write("Nome do herói: ");
        herois[totalHerois].Nome = Console.ReadLine();
        Console.Write("Poder do herói: ");
        herois[totalHerois].Poder = Console.ReadLine();
        Console.Write("Pontuação do herói: ");
        herois[totalHerois].Pontuacao = int.Parse(Console.ReadLine());

        totalHerois++; // Incrementa contador de heróis cadastrados

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Herói cadastrado com sucesso!");
        Console.ResetColor();
    }

    static void SelecionarEquipe() // Função para selecionar 3 heróis para a equipe
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("-------------------");
        Console.WriteLine(" Selecionar Equipe ");
        Console.WriteLine("-------------------");
        Console.ResetColor();

        if (totalHerois < 3) // Verifica se há pelo menos 3 heróis cadastrados
        {
            Console.WriteLine("É necessário cadastrar pelo menos 3 heróis para formar uma equipe!");
            return;
        }

        totalHeroisEquipe = 0; // Reseta o contador da equipe

        // Lista os heróis cadastrados
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

            if (indice >= 0 && indice < totalHerois) // Verifica se o índice digitado é válido
            {
                equipe[i] = herois[indice]; // Adiciona herói na equipe
                totalHeroisEquipe++;
            }
            else
            {
                Console.WriteLine("Índice inválido. Tente novamente.");
                i--; // Repete a escolha se for inválida
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Equipe selecionada com sucesso!");
        Console.ResetColor();
    }
    static int CalcularPontuacaoTotal() // Calcula a soma das pontuações dos heróis da equipe
    {
        int total = 0;
        for (int i = 0; i < totalHeroisEquipe; i++)
        {
            total += equipe[i].Pontuacao;
        }
        return total;
    }

    static void ExibirEquipe() // Exibe a equipe formada
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("------------------");
        Console.WriteLine("      Equipe      ");
        Console.WriteLine("------------------");
        Console.ResetColor();

        if (totalHeroisEquipe == 0) // Verifica se já existe equipe formada
        {
            Console.WriteLine("Nenhuma equipe foi formada ainda.");
            return;
        }

        // Exibe os heróis escolhidos
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("=== Equipe Selecionada ===");
        Console.ResetColor();

        for (int i = 0; i < totalHeroisEquipe; i++)
        {
            Console.WriteLine($"- {equipe[i].Nome} (Poder: {equipe[i].Poder}, Pontuação: {equipe[i].Pontuacao})");
        }
        Console.WriteLine($"\nPontuação Total da Equipe: {CalcularPontuacaoTotal()}"); // Exibe a soma das pontuações
    }
}
