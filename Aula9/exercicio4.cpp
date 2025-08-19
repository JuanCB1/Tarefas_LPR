/*Exercício 4) RESOLVA EM C++
Construa um dicionário de x pares chave-valor onde as chaves são nomes de cidades e os
valores são suas respectivas populações.
Encontre e imprima todas as cidades com população acima da média.
Encontre e imprima o nome da cidade mais populosa e o nome da cidade menos populosa.
Remova todas as cidades com população igual
a um valor Y (fornecido pelo usuário) e imprima o dicionário atualizado.
*/

// Funções necessárias
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

    map<string, int> cidades; // Dicionário: Nome da cidade -> População
    int x;

    cout << Yellow << "Quantas cidades deseja cadastrar? " << Reset;
    cin >> x;

    // Cadastro das cidades
    for (int i = 0; i < x; i++)
    {
        string nome;
        int populacao;

        cout << Blue << "Nome da cidade #" << i + 1 << ": " << Reset;
        cin >> nome;

        cout << Blue << "População de " << nome << ": " << Reset;
        cin >> populacao;

        cidades[nome] = populacao; // Insere no mapa
    }

    // Calcula a soma das populações
    int soma = 0;
    for (auto par : cidades)
    {
        soma += par.second;
    }
    double media = (double)soma / cidades.size(); // Média populacional

    // Mostra cidades acima da média
    cout << Yellow << "\nCidades com população acima da média (" << media << "):\n" << Reset;
    for (auto par : cidades)
    {
        if (par.second > media)
        {
            cout << par.first << " - " << par.second << "\n";
        }
    }

    // Descobre a mais e a menos populosa
    string maisPopulosa, menosPopulosa;
    int maior = -1, menor = 1000000000;

    for (auto par : cidades)
    {
        if (par.second > maior) // Atualiza a cidade mais populosa
        {
            maior = par.second;
            maisPopulosa = par.first;
        }
        if (par.second < menor) // Atualiza a cidade menos populosa
        {
            menor = par.second;
            menosPopulosa = par.first;
        }
    }

    // Mostra os resultados
    cout << Red << "\nCidade mais populosa: " << maisPopulosa << " (" << maior << " habitantes)\n" << Reset;
    cout << Green << "Cidade menos populosa: " << menosPopulosa << " (" << menor << " habitantes)\n" << Reset;

    // Remover cidades com população desejada
    int y;
    cout << Blue << "\nInforme uma população Y para remover: " << Reset;
    cin >> y;

    for (auto it = cidades.begin(); it != cidades.end();) // Percorre com iterador
    {
        if (it->second == y)
            it = cidades.erase(it); // Apaga e avança corretamente
        else
            ++it;
    }

    // Mostra cidades restantes
    cout << Red << "\nCidades restantes:\n" << Reset;
    for (auto par : cidades)
    {
        cout << par.first << " - " << par.second << "\n";
    }

    return 0;
}
