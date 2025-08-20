/*
Exercício 3) MATRIZ: A tabela a seguir mostra a distância de quatro cidades entre
si. Por exemplo, a distância entre Vitória e Belo Horizonte é de 524 km.
Crie um programa que leia essa matriz e informe ao usuário a
distância entre duas cidades por ele fornecidas.
O programa deve ficar repetindo até que o usuário informe a mesma cidade como
origem e destino
*/

// Funções necessárias
#include <iostream>

#define Yellow "\033[33m"
#define Red "\033[31m"
#define Blue "\033[34m"
#define Green "\033[32m"
#define Reset "\033[0m"

using namespace std;

int main()
{
    // Constante para número de cidades
    const int Cid = 4;
    int origem, destino;

    // Array com os nomes das cidades
    string nomes[Cid] = {"Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};

    // Matriz de distâncias entre as cidades (em km)
    int distancias[Cid][Cid] = {
        {0, 524, 521, 882}, // Vitória
        {524, 0, 434, 586}, // Belo Horizonte
        {521, 434, 0, 429}, // Rio de Janeiro
        {882, 586, 429, 0}  // São Paulo
    };

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 3   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    // Loop principal - continua até origem = destino
    do
    {
        // Exibe menu de cidades
        cout << Red << "\nEscolha uma cidade:\n"
             << Reset;
        for (int i = 0; i < Cid; i++)
        {
            cout << i << " - " << nomes[i] << endl;
        }

        // Lê origem e destino
        cout << Green << "\nDigite o número da cidade de ORIGEM: " << Reset;
        cin >> origem;
        cout << Yellow << "Digite o número da cidade de DESTINO: " << Reset;
        cin >> destino;

        // Validação das entradas
        if (origem < 0 || origem >= Cid || destino < 0 || destino >= Cid)
        {
            cout << "Códigos inválidos. Tente novamente.\n";
            continue;
        }

        // Exibe a distância se origem ≠ destino
        if (origem != destino)
        {
            cout << "\nA distância entre " << nomes[origem] << " e " << nomes[destino]
                 << " é de " << distancias[origem][destino] << " km.\n";
        }

    } while (origem != destino);

    cout << Red << "\nOrigem e destino são iguais. Fim do programa.\n" << Reset;
    return 0;
}