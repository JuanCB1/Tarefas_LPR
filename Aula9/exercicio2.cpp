#include <iostream>
#include <vector>
#include <algorithm>
#include <list>

#define Yellow  "\033[33m"
#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Reset   "\033[0m"

using namespace std;

int main()
{
    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 2   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    vector<int> numeros;

    srand(time(0));
    for (int i = 0; i < 100; i++)
    {
        numeros.push_back(rand() % 100);
    }

    sort(numeros.begin(), numeros.end());

    cout << Yellow << "Lista ordenada:\n" << Reset;
    for (int n : numeros)
    {
        cout << n << " ";
    }
    cout << "\n\n";

    list<int> listaImpares;
    for (int n : numeros)
    {
        if (n % 2 != 0)
            listaImpares.push_back(n);
    }

    cout << Blue << "Lista sem números pares:\n" << Reset;
    for (int n : listaImpares)
    {
        cout << n << " ";
    }
    cout << "\n\n";

    cout << Red << "Números repetidos:\n" << Reset;
    bool temRepetido = false;
    for (size_t i = 1; i < numeros.size(); i++)
    {
        if (numeros[i] == numeros[i - 1])
        {
            if (i == 1 || numeros[i] != numeros[i - 2])
            {
                cout << numeros[i] << " ";
                temRepetido = true;
            }
        }
    }

    if (!temRepetido)
    {
        cout << Red << "Nenhum número repetido." << Reset;
    }

    return 0;
}
