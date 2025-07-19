#include <iostream>
#include <string>

#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Reset   "\033[0m"

using namespace std;

struct Livro
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main()
{
    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 2   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    Livro livros[3];
    float precoTotal = 0;
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++)
    {
        cout << Blue << "\nLivro " << i + 1 << Reset << endl;

        cout << Red << "Titulo: " << Reset;
        cin >> livros[i].Titulo;
        cout << Red << "Autor: " << Reset;
        cin >> livros[i].Autor;
        cout << Red << "Ano de Publicacao: " << Reset;
        cin >> livros[i].AnoPublicacao;
        cout << Red << "Numero de Paginas: " << Reset;
        cin >> livros[i].NumeroPaginas;
        cout << Red << "Preco: R$ " << Reset;
        cin >> livros[i].Preco;

        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    float mediaPaginas = totalPaginas / 3.0;

    cout << "\nPreco total dos livros: R$ " << precoTotal << endl;
    cout << "Media de paginas: " << mediaPaginas << " paginas" << endl;

    return 0;
}
