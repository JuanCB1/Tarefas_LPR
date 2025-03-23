#include <iostream>

#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Reset   "\033[0m"

using namespace std;

int main() {
    int quantidade, num, soma_pares = 0, cont_pares = 0, contador = 0;

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 1   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    cout << "Quantos números serão digitados? ";
    cin >> quantidade;

    while (contador < quantidade) {
        cout << "Digite o " << contador + 1 << "º número: ";
        cin >> num;
        if (num % 2 == 0) {
            soma_pares += num;
            cont_pares++;
        }
        contador++;
    }

    if (cont_pares > 0) {
        cout << Blue << "A média dos números pares é: " << Reset << (double)soma_pares / cont_pares << endl;
    } else {
        cout << Red << "Nenhum número par foi digitado." << Reset << endl;
    }

    return 0;
}
