/*
Exercício 3)
FOR: Elabore um algoritmo que calcule a
soma de todos os números ímpares
múltiplos de 3 que se encontrem no
conjunto dos números de 50 a 500
*/

// Funções necessárias
#include <iostream>

#define Blue "\033[34m"
#define Reset "\033[0m"

using namespace std;

int main()
{
    int soma = 0; // Acumulador para a soma

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 3   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    // Loop percorre números de 50 a 500
    for (int i = 50; i <= 500; i++)
    {
        // Verifica se é ímpar E múltiplo de 3
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i; // Adiciona à soma
        }
    }

    cout << Blue << "A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: " << Reset << soma << endl;

    return 0;
}