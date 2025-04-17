#include <iostream>

#define Red "\033[31m"
#define Blue "\033[34m"
#define Reset "\033[0m"

using namespace std;

int reverterNumero(int numero)
{
    int reverso = 0, digito;

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

    resultado = reverterNumero(numero);
    cout << Red << "Número reverso: " << Reset << resultado << endl;

    return 0;
}