/*Exercício 2) RESOLVA EM C++
Construa uma lista de 100 números aleatórios
Crie um algoritmo que coloque-os em ordem crescente e imprima-os
A partir dessa lista ordenada, remova todos os números pares e imprima a lista
novamente. Por fim imprima quais números se repetem, se existe algum número
repetido.
*/

// Funções necessárias
#include <iostream>
#include <vector>
#include <algorithm>
#include <list>

#define Yellow "\033[33m"
#define Red "\033[31m"
#define Blue "\033[34m"
#define Reset "\033[0m"

using namespace std;

int main()
{
    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 2   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    // Cria um vetor
    vector<int> numeros;

    // Gera 100 números aleatórios entre 0 e 99
    srand(time(0));
    for (int i = 0; i < 100; i++)
    {
        numeros.push_back(rand() % 100); // insere um número entre 0 e 99 no vetor
    }

    // Ordena os números em ordem crescente
    sort(numeros.begin(), numeros.end());

    // Exibe a lista
    cout << Yellow << "Lista ordenada:\n" << Reset;
    for (int n : numeros)
    {
        cout << n << " ";
    }
    cout << "\n\n";

    // Cria uma lista para apenas números ímpares
    list<int> listaImpares;
    for (int n : numeros)
    {
        if (n % 2 != 0) // verifica se é ímpar
            listaImpares.push_back(n);
    }

    // Exibe a lista de números ímpares
    cout << Blue << "Lista de números ímpares:\n" << Reset;
    for (int n : listaImpares)
    {
        cout << n << " ";
    }
    cout << "\n\n";

    // Identifica e exibe os números repetidos
    cout << Red << "Números repetidos:\n"
         << Reset;
    bool temRepetido = false;
    for (size_t i = 1; i < numeros.size(); i++)
    {
        // Compara o número atual com o anterior
        if (numeros[i] == numeros[i - 1])
        {
            // Garante que o número repetido só seja exibido uma vez
            if (i == 1 || numeros[i] != numeros[i - 2])
            {
                cout << numeros[i] << " ";
                temRepetido = true;
            }
        }
    }

    // Caso não tenha nenhum número repetido
    if (!temRepetido)
    {
        cout << Red << "Nenhum número repetido." << Reset;
    }

    return 0;
}
