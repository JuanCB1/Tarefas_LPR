/*
Exercício 2)
Construa um algoritmo em C++ que agrupe em funções os exercícios 1, 3 e 4 da tarefa
de estruturas de repetições. Cada exercício deve estar contido em uma função
separada. Defina os parâmetros de modo eficiente e generalista. Construa um menu
na função main. Reuse os códigos das suas respostas da tarefa.
*/

// Funções necessárias
#include <iostream>

#define Red "\033[31m"
#define Blue "\033[34m"
#define Cyan "\033[36m"
#define Reset "\033[0m"

using namespace std;

// Exercício 1: Calcula a média dos números pares
void exercicio1()
{
    int quantidade, num, soma_pares = 0, cont_pares = 0, contador = 0;

    cout << Blue << "------------------------------" << Reset << endl;
    cout << Blue << "   Aula 5 - Exercicio 1   " << Reset << endl;
    cout << Blue << "------------------------------" << Reset << endl;

    cout << "Quantos números serão digitados? ";
    cin >> quantidade;

    // Lê os números e soma apenas os pares
    while (contador < quantidade)
    {
        cout << "Digite o " << contador + 1 << "º número: ";
        cin >> num;
        if (num % 2 == 0)
        {
            soma_pares += num;
            cont_pares++;
        }
        contador++;
    }

    // Calcula e exibe a média
    if (cont_pares > 0)
    {
        cout << Blue << "A média dos números pares é: " << Reset << (double)soma_pares / cont_pares << endl;
    }
    else
    {
        cout << Red << "Nenhum número par foi digitado." << Reset << endl;
    }
}

// Exercício 3: Soma números ímpares múltiplos de 3 entre 50 e 500
void exercicio3()
{
    int soma = 0;

    cout << Blue << "------------------------------" << Reset << endl;
    cout << Blue << "   Aula 5 - Exercicio 3   " << Reset << endl;
    cout << Blue << "------------------------------" << Reset << endl;

    // Percorre números de 50 a 500
    for (int i = 50; i <= 500; i++)
    {
        // Verifica se é ímpar e múltiplo de 3
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i;
        }
    }

    cout << Blue << "A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: " << Reset << soma << endl;
}

// Exercício 4: Soma dos dígitos do quadrado de um número
void exercicio4()
{
    int num, resposta, somaD = 0;

    cout << Cyan << "------------------------------" << Reset << endl;
    cout << Cyan << "   Aula 5 - Exercicio 4   " << Reset << endl;
    cout << Cyan << "------------------------------" << Reset << endl;

    cout << "Insira um número: ";
    cin >> num;

    resposta = num * num;  // Calcula o quadrado

    // Soma os dígitos do quadrado
    while (resposta > 0)
    {
        int digito = resposta % 10;
        somaD += digito;
        resposta /= 10;
    }

    cout << Red << "A soma dos dígitos do quadrado é: " << Reset << somaD << endl;
}

int main()
{
    int opcao;

    // Menu principal com loop
    do
    {
        // Exibe as opções do menu
        cout << Blue << "------------------------------" << Reset << endl;
        cout << Blue << "     Aula 6 - Exercicio 2        " << Reset << endl;
        cout << Blue << "------------------------------" << Reset << endl;
        cout << "1. Exercício 1 - Média dos números pares" << endl;
        cout << "2. Exercício 3 - Soma números ímpares múltiplos de 3" << endl;
        cout << "3. Exercício 4 - Soma dos dígitos do quadrado" << endl;
        cout << "0. Sair" << endl;
        cout << "Escolha uma opção: ";
        cin >> opcao;

        // Executa a função correspondente à opção
        switch (opcao)
        {
        case 1:
            exercicio1();
            break;
        case 2:
            exercicio3();
            break;
        case 3:
            exercicio4();
            break;
        case 0:
            cout << Blue << "Encerrando o programa..." << Reset << endl;
            break;
        default:
            cout << Red << "Opção inválida! Tente novamente." << Reset << endl;
        }
    } while (opcao != 0);

    return 0;
}