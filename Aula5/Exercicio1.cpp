/*
Exercício 1)
WHILE: Construa um algoritmo que calcule a média aritmética de um conjunto de números
pares fornecidos pelo usuário. O usuário deve fornecer primeiro a quantidade de números que
serão digitados, e em seguida, os números considerados na média. O usuário pode digitar
números ímpares, que devem ser ignorados.
Por exemplo, no caso da tabela abaixo, o 5 informa que serão digitados 5 números (2 7 8 6
10), e para a média devem ser considerados apenas os números pares (2, 8, 6 e 10)
ignorando o número 7 digitado.
*/

// Funções necessárias
#include <iostream>

#define Red "\033[31m"
#define Blue "\033[34m"
#define Reset "\033[0m"

using namespace std;

int main()
{
    // Variáveis para controle e cálculos
    int quantidade, num, soma_pares = 0, cont_pares = 0, contador = 0;

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 1   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    cout << "Quantos números serão digitados? ";
    cin >> quantidade;

    // Loop para ler os números e processar apenas os pares
    while (contador < quantidade)
    {
        cout << "Digite o " << contador + 1 << "º número: ";
        cin >> num;

        // Verifica se o número é par
        if (num % 2 == 0)
        {
            soma_pares += num; // Acumula a soma
            cont_pares++;      // Conta quantos pares
        }
        contador++;
    }

    // Calcula e exibe a média ou mensagem de erro
    if (cont_pares > 0)
    {
        cout << Blue << "A média dos números pares é: " << Reset << (double)soma_pares / cont_pares << endl;
    }
    else
    {
        cout << Red << "Nenhum número par foi digitado." << Reset << endl;
    }

    return 0;
}