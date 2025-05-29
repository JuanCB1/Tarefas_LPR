#include <iostream>

#define Yellow  "\033[33m"
#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Green   "\033[32m"
#define Reset   "\033[0m"

using namespace std;

int main() {
    const int Cid = 4;
    int origem, destino;

    string nomes[Cid] = {"Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};

    int distancias[Cid][Cid] = {
        {  0, 524, 521, 882 },
        {524,   0, 434, 586 },
        {521, 434,   0, 429 },
        {882, 586, 429,   0 }
    };

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 3   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    do {
        cout << Red << "\nEscolha uma cidade:\n" << Reset;
        for (int i = 0; i < Cid; i++) {
            cout << i << " - " << nomes[i] << endl;
        }

        cout << Green << "\nDigite o número da cidade de ORIGEM: " << Reset;
        cin >> origem;
        cout << Yellow << "Digite o número da cidade de DESTINO: " << Reset;
        cin >> destino;

        if (origem < 0 || origem >= Cid || destino < 0 || destino >= Cid) {
            cout << "Códigos inválidos. Tente novamente.\n";
            continue;
        }

        if (origem != destino) {
            cout << "\nA distância entre " << nomes[origem] << " e " << nomes[destino]
                 << " é de " << distancias[origem][destino] << " km.\n";
        }

    } while (origem != destino);

    cout << Red << "\nOrigem e destino são iguais. Fim do programa.\n" << Reset;
    return 0;
}