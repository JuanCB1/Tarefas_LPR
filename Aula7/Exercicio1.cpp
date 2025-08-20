/*
Exercício 1) VETOR: Construa um algoritmo que leia 10 números inteiros e armazene-os
em um vetor (use o for para fazer a leitura). Depois, crie automaticamente dois
vetores, um contendo apenas os números pares e outro os números ímpares
digitados. 
*/

// Funções necessárias
#include <iostream>
#include <vector>

#define Yellow "\033[33m"
#define Red "\033[31m"
#define Blue "\033[34m"
#define Reset "\033[0m"

using namespace std;

int main()
{
    // Declaração de um array para armazenar 10 números inteiros
    int numeros[10];

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 1   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    cout << "Digite 10 números inteiros:\n";
    for (int i = 0; i < 10; i++) // Loop para ler os 10 números do usuário
    {
        cout << "Número " << i + 1 << ": ";
        cin >> numeros[i];
    }

    // Criação de dois vetores para separar números pares e ímpares
    vector<int> pares;
    vector<int> impares;

    // Separa números pares e ímpares
    for (int i = 0; i < 10; i++)
    {
        if (numeros[i] % 2 == 0) // Se o resto da divisão por 2 é 0, o número é par
        {
            pares.push_back(numeros[i]);
        }
        else // Caso contrário, o número é ímpar
        {
            impares.push_back(numeros[i]);
        }
    }

    // Exibe os resultados dos pares
    cout << Red << "\nNúmeros pares: " << Reset;
    for (int num : pares)
    {
        cout << num << " ";
    }

    // Exibe os resultados dos émpares
    cout << Yellow << "\nNúmeros ímpares: " << Reset;
    for (int num : impares)
    {
        cout << num << " ";
    }

    cout << endl;
    return 0;
}