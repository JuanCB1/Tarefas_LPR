/*
Exercício 1)
Construa uma função em C++ que retorne
o reverso de um número inteiro.
*/

// Funções necessárias
#include <iostream>

#define Red "\033[31m"
#define Blue "\033[34m"
#define Reset "\033[0m"

using namespace std;

// Função para reverter os dígitos de um número
int reverterNumero(int numero)
{
    int reverso = 0, digito;

    // Extrai cada dígito e reconstrói o número invertido
    while (numero != 0)
    {
        digito = numero % 10;
        reverso = reverso * 10 + digito;
        numero /= 10;
    }
    return reverso;
}

int main()
{
    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 1   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    int numero, resultado;

    cout << "Digite um número inteiro: ";
    cin >> numero;

    // Chama função e exibe resultado
    resultado = reverterNumero(numero);
    cout << Red << "Número reverso: " << Reset << resultado << endl;

    return 0;
}
