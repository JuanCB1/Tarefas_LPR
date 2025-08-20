/*
Exercício 2) C++
Leia 2 valores inteiros (A e B). Após, o
programa deve mostrar uma mensagem
"Sao Multiplos" ou "Nao sao Multiplos",
indicando se os valores lidos são múltiplos
entre si. Atenção: os números podem ser
digitados em ordem crescente ou
decrescente.
*/

// Funções necessárias
#include <iostream>

#define Yellow  "\033[33m"
#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Reset   "\033[0m"

using namespace std;

int main()
{
    int A, B;

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 2   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    cout << "Digite dois numeros inteiros separados por um espaco: ";
    cin >> A >> B;

    // Verifica se um número é múltiplo do outro
    if (A % B == 0 || B % A == 0)
    {
        cout << Yellow << "Sao Multiplos" << Reset << endl;
    }
    else
    {
        cout << Red << "Nao sao Multiplos" << Reset << endl;
    }

    return 0;
}