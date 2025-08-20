/*
Exercício 3)
Desenvolva um programa em C# que simule um sistema de seleção de heróis da
Marvel para uma equipe. O programa deve ter as seguintes funcionalidades:
a) Cadastro de Heróis:
Crie uma função chamada cadastrarHeroi que permita ao usuário
inserir o nome, poder e pontuação de um herói da Marvel. A função deve
solicitar essas informações ao usuário e armazená-las em variáveis. Não é
necessário armazenar os heróis em uma lista ou vetor. O programa deve
permitir o cadastro de até 5 heróis.
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
● Utilize variáveis locais para armazenar as informações dos heróis e
da equipe.
● Não utilize classes, vetores ou listas! 
*/
using System;

class Aula6
{
    static void Main()
    {
        // Variáveis para armazenar dados dos 5 heróis
        string heroi1Nome = "", heroi2Nome = "", heroi3Nome = "", heroi4Nome = "", heroi5Nome = "";
        string heroi1Poder = "", heroi2Poder = "", heroi3Poder = "", heroi4Poder = "", heroi5Poder = "";
        int heroi1Pontuacao = 0, heroi2Pontuacao = 0, heroi3Pontuacao = 0, heroi4Pontuacao = 0, heroi5Pontuacao = 0;
        int totalHeroisCadastrados = 0;

        // Variáveis para armazenar a equipe selecionada (3 heróis)
        string equipeHeroi1 = "", equipeHeroi2 = "", equipeHeroi3 = "";
        string equipePoder1 = "", equipePoder2 = "", equipePoder3 = "";
        int equipePontuacao1 = 0, equipePontuacao2 = 0, equipePontuacao3 = 0;

        // Loop principal do programa
        while (true)
        {
            menuPrincipal();
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Cadastra herói se ainda há espaço
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
                    // Seleciona 3 heróis para formar a equipe
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
                    // Exibe a equipe selecionada e pontuação total
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

    // Exibe o menu principal
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

    // Cadastra um novo herói
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

        // Lê os dados do herói
        Console.Write("Digite o nome do herói: ");
        nome = Console.ReadLine();
        Console.Write("Digite o poder do herói: ");
        poder = Console.ReadLine();
        Console.Write("Digite a pontuação do herói: ");
        pontuacao = Convert.ToInt32(Console.ReadLine());

        // Armazena o herói na primeira posição disponível
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

    // Permite selecionar 3 heróis para formar a equipe
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

        // Verifica se há heróis suficientes
        if (totalHerois < 3)
        {
            Console.WriteLine("É necessário cadastrar pelo menos 3 heróis para formar uma equipe!");
            return;
        }

        // Lista todos os heróis disponíveis
        Console.WriteLine("Heróis disponíveis:");
        for (int Hero = 1; Hero <= totalHerois; Hero++)
        {
            string nome = "", poder = "";
            int pontuacao = 0;

            // Obtém dados do herói baseado no índice
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

        // Loop para selecionar 3 heróis
        for (int time = 1; time <= 3; time++)
        {
            Console.Write($"Selecione o {time}º herói (1-{totalHerois}): ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            string nome = "", poder = "";
            int pontuacao = 0;

            // Obtém dados do herói escolhido
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

            // Armazena o herói na equipe
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

    // Exibe a equipe selecionada e a pontuação total
    static void exibirEquipe(string nome1, string poder1, int pontuacao1,
                           string nome2, string poder2, int pontuacao2,
                           string nome3, string poder3, int pontuacao3)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("------------------");
        Console.WriteLine("      Equipe      ");
        Console.WriteLine("------------------");
        Console.ResetColor();

        // Verifica se há equipe selecionada
        if (string.IsNullOrEmpty(nome1))
        {
            Console.WriteLine("Nenhuma equipe foi selecionada ainda!");
            return;
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("=== Equipe Selecionada ===");
        Console.ResetColor();

        // Exibe os 3 heróis da equipe
        Console.WriteLine($"1. {nome1} - Poder: {poder1} - Pontuação: {pontuacao1}");
        Console.WriteLine($"2. {nome2} - Poder: {poder2} - Pontuação: {pontuacao2}");
        Console.WriteLine($"3. {nome3} - Poder: {poder3} - Pontuação: {pontuacao3}");

        int pontuacaoTotal = calcularPontuacaoTotal(pontuacao1, pontuacao2, pontuacao3);
        Console.WriteLine($"Pontuação Total da Equipe: {pontuacaoTotal}");
    }

    // Calcula a pontuação total da equipe
    static int calcularPontuacaoTotal(int pontuacao1, int pontuacao2, int pontuacao3)
    {
        return pontuacao1 + pontuacao2 + pontuacao3;
    }
}