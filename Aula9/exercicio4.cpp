#include <iostream>
#include <map>

#define Yellow "\033[33m"
#define Red "\033[31m"
#define Blue "\033[34m"
#define Green "\033[32m"
#define Reset "\033[0m"

using namespace std;

int main()
{
    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 4   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    map<string, int> cidades;
    int x;

    cout << Yellow << "Quantas cidades deseja cadastrar? " << Reset;
    cin >> x;

    for (int i = 0; i < x; i++)
    {
        string nome;
        int populacao;

        cout << Blue << "Nome da cidade #" << i + 1 << ": " << Reset;
        cin >> nome;

        cout << Blue << "População de " << nome << ": " << Reset;
        cin >> populacao;

        cidades[nome] = populacao;
    }

    int soma = 0;
    for (auto par : cidades)
    {
        soma += par.second;
    }
    double media = (double)soma / cidades.size();

    cout << Yellow << "\nCidades com população acima da média (" << media << "):\n" << Reset;
    for (auto par : cidades)
    {
        if (par.second > media)
        {
            cout << par.first << " - " << par.second << "\n";
        }
    }

    string maisPopulosa, menosPopulosa;
    int maior = -1, menor = 1000000000;

    for (auto par : cidades)
    {
        if (par.second > maior)
        {
            maior = par.second;
            maisPopulosa = par.first;
        }
        if (par.second < menor)
        {
            menor = par.second;
            menosPopulosa = par.first;
        }
    }

    cout << Red << "\nCidade mais populosa: " << maisPopulosa << " (" << maior << " habitantes)\n" << Reset;
    cout << Green << "Cidade menos populosa: " << menosPopulosa << " (" << menor << " habitantes)\n" << Reset;

    int y;
    cout << Blue << "\nInforme uma população Y para remover: " << Reset;
    cin >> y;

    for (auto it = cidades.begin(); it != cidades.end();)
    {
        if (it->second == y)
            it = cidades.erase(it);
        else
            ++it;
    }

    cout << Red << "\nCidades restantes:\n" << Reset;
    for (auto par : cidades)
    {
        cout << par.first << " - " << par.second << "\n";
    }

    return 0;
}
