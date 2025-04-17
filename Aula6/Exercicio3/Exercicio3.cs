using System;

class Aula6
{
    static void Main()
    {
        string heroi1Nome = "", heroi2Nome = "", heroi3Nome = "", heroi4Nome = "", heroi5Nome = "";
        string heroi1Poder = "", heroi2Poder = "", heroi3Poder = "", heroi4Poder = "", heroi5Poder = "";
        int heroi1Pontuacao = 0, heroi2Pontuacao = 0, heroi3Pontuacao = 0, heroi4Pontuacao = 0, heroi5Pontuacao = 0;
        int totalHeroisCadastrados = 0;

        string equipeHeroi1 = "", equipeHeroi2 = "", equipeHeroi3 = "";
        string equipePoder1 = "", equipePoder2 = "", equipePoder3 = "";
        int equipePontuacao1 = 0, equipePontuacao2 = 0, equipePontuacao3 = 0;

        while (true)
        {
            menuPrincipal();
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (totalHeroisCadastrados < 5)
                    {
                        cadastrarHeroi(ref heroi1Nome, ref heroi1Poder, ref heroi1Pontuacao,
                                     ref heroi2Nome, ref heroi2Poder, ref heroi2Pontuacao,
                                     ref heroi3Nome, ref heroi3Poder, ref heroi3Pontuacao,
                                     ref heroi4Nome, ref heroi4Poder, ref heroi4Pontuacao,
                                     ref heroi5Nome, ref heroi5Poder, ref heroi5Pontuacao,
                                     ref totalHeroisCadastrados);
                    }
                    else
                    {
                        Console.WriteLine("Limite máximo de heróis atingido!");
                    }
                    break;
                case 2:
                    selecionarEquipe(heroi1Nome, heroi1Poder, heroi1Pontuacao,
                                   heroi2Nome, heroi2Poder, heroi2Pontuacao,
                                   heroi3Nome, heroi3Poder, heroi3Pontuacao,
                                   heroi4Nome, heroi4Poder, heroi4Pontuacao,
                                   heroi5Nome, heroi5Poder, heroi5Pontuacao,
                                   totalHeroisCadastrados,
                                   ref equipeHeroi1, ref equipePoder1, ref equipePontuacao1,
                                   ref equipeHeroi2, ref equipePoder2, ref equipePontuacao2,
                                   ref equipeHeroi3, ref equipePoder3, ref equipePontuacao3);
                    break;
                case 3:
                    exibirEquipe(equipeHeroi1, equipePoder1, equipePontuacao1,
                               equipeHeroi2, equipePoder2, equipePontuacao2,
                               equipeHeroi3, equipePoder3, equipePontuacao3);
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void menuPrincipal()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("-------------");
        Console.WriteLine(" Exercício 3 ");
        Console.WriteLine("-------------");
        Console.ResetColor();

        Console.WriteLine();

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
    }

    static void cadastrarHeroi(ref string nome1, ref string poder1, ref int pontuacao1,
                             ref string nome2, ref string poder2, ref int pontuacao2,
                             ref string nome3, ref string poder3, ref int pontuacao3,
                             ref string nome4, ref string poder4, ref int pontuacao4,
                             ref string nome5, ref string poder5, ref int pontuacao5,
                             ref int totalHerois)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("------------------");
        Console.WriteLine(" Cadastre o Herói ");
        Console.WriteLine("------------------");
        Console.ResetColor();

        string nome, poder;
        int pontuacao;

        Console.Write("Digite o nome do herói: ");
        nome = Console.ReadLine();
        Console.Write("Digite o poder do herói: ");
        poder = Console.ReadLine();
        Console.Write("Digite a pontuação do herói: ");
        pontuacao = Convert.ToInt32(Console.ReadLine());

        switch (totalHerois)
        {
            case 0:
                nome1 = nome;
                poder1 = poder;
                pontuacao1 = pontuacao;
                break;
            case 1:
                nome2 = nome;
                poder2 = poder;
                pontuacao2 = pontuacao;
                break;
            case 2:
                nome3 = nome;
                poder3 = poder;
                pontuacao3 = pontuacao;
                break;
            case 3:
                nome4 = nome;
                poder4 = poder;
                pontuacao4 = pontuacao;
                break;
            case 4:
                nome5 = nome;
                poder5 = poder;
                pontuacao5 = pontuacao;
                break;
        }

        totalHerois++;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Herói cadastrado com sucesso!");
        Console.ResetColor();

        Console.WriteLine();
    }

    static void selecionarEquipe(string nome1, string poder1, int pontuacao1,
                               string nome2, string poder2, int pontuacao2,
                               string nome3, string poder3, int pontuacao3,
                               string nome4, string poder4, int pontuacao4,
                               string nome5, string poder5, int pontuacao5,
                               int totalHerois,
                               ref string eqNome1, ref string eqPoder1, ref int eqPontuacao1,
                               ref string eqNome2, ref string eqPoder2, ref int eqPontuacao2,
                               ref string eqNome3, ref string eqPoder3, ref int eqPontuacao3)
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

        Console.WriteLine("Heróis disponíveis:");
        for (int Hero = 1; Hero <= totalHerois; Hero++)
        {
            string nome = "", poder = "";
            int pontuacao = 0;

            switch (Hero)
            {
                case 1:
                    nome = nome1;
                    poder = poder1;
                    pontuacao = pontuacao1;
                    break;
                case 2:
                    nome = nome2;
                    poder = poder2;
                    pontuacao = pontuacao2;
                    break;
                case 3:
                    nome = nome3;
                    poder = poder3;
                    pontuacao = pontuacao3;
                    break;
                case 4:
                    nome = nome4;
                    poder = poder4;
                    pontuacao = pontuacao4;
                    break;
                case 5:
                    nome = nome5;
                    poder = poder5;
                    pontuacao = pontuacao5;
                    break;
            }

            Console.WriteLine($"{Hero}. {nome} - Poder: {poder} - Pontuação: {pontuacao}");
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Selecione 3 heróis para sua equipe:");
        Console.ResetColor();

        for (int time = 1; time <= 3; time++)
        {
            Console.Write($"Selecione o {time}º herói (1-{totalHerois}): ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            string nome = "", poder = "";
            int pontuacao = 0;

            switch (escolha)
            {
                case 1:
                    nome = nome1;
                    poder = poder1;
                    pontuacao = pontuacao1;
                    break;
                case 2:
                    nome = nome2;
                    poder = poder2;
                    pontuacao = pontuacao2;
                    break;
                case 3:
                    nome = nome3;
                    poder = poder3;
                    pontuacao = pontuacao3;
                    break;
                case 4:
                    nome = nome4;
                    poder = poder4;
                    pontuacao = pontuacao4;
                    break;
                case 5:
                    nome = nome5;
                    poder = poder5;
                    pontuacao = pontuacao5;
                    break;
            }

            switch (time)
            {
                case 1:
                    eqNome1 = nome;
                    eqPoder1 = poder;
                    eqPontuacao1 = pontuacao;
                    break;
                case 2:
                    eqNome2 = nome;
                    eqPoder2 = poder;
                    eqPontuacao2 = pontuacao;
                    break;
                case 3:
                    eqNome3 = nome;
                    eqPoder3 = poder;
                    eqPontuacao3 = pontuacao;
                    break;
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Equipe selecionada com sucesso!");
        Console.ResetColor();
    }

    static void exibirEquipe(string nome1, string poder1, int pontuacao1,
                           string nome2, string poder2, int pontuacao2,
                           string nome3, string poder3, int pontuacao3)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("------------------");
        Console.WriteLine("      Equipe      ");
        Console.WriteLine("------------------");
        Console.ResetColor();

        if (string.IsNullOrEmpty(nome1))
        {
            Console.WriteLine("Nenhuma equipe foi selecionada ainda!");
            return;
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("=== Equipe Selecionada ===");
        Console.ResetColor();

        Console.WriteLine($"1. {nome1} - Poder: {poder1} - Pontuação: {pontuacao1}");
        Console.WriteLine($"2. {nome2} - Poder: {poder2} - Pontuação: {pontuacao2}");
        Console.WriteLine($"3. {nome3} - Poder: {poder3} - Pontuação: {pontuacao3}");

        int pontuacaoTotal = calcularPontuacaoTotal(pontuacao1, pontuacao2, pontuacao3);
        Console.WriteLine($"Pontuação Total da Equipe: {pontuacaoTotal}");
    }

    static int calcularPontuacaoTotal(int pontuacao1, int pontuacao2, int pontuacao3)
    {
        return pontuacao1 + pontuacao2 + pontuacao3;
    }
}
