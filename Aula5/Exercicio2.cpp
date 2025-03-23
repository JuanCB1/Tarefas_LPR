#include <iostream>
#include <random>

#define Yellow  "\033[33m"
#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Green   "\033[32m"
#define Reset   "\033[0m"

using namespace std;

int main() {
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);
    int palpite, tentativas = 0;

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 2   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    cout << "Tente adivinhar o número entre 1 e 100!" << endl;
    
    do {
        cout << "Digite seu palpite: ";
        cin >> palpite;
        tentativas++;

        if (palpite > valorInteiro) {
            cout << Yellow << "Chutou alto! Tente novamente." << Reset << endl;
        } else if (palpite < valorInteiro) {
            cout << Red << "Chutou baixo! Tente novamente." << Reset << endl;
        } else {
            cout << Green << "Acertou! Você precisou de " << Reset << tentativas << Green << " tentativas." << Reset << endl;
        }
    } while (palpite != valorInteiro);

    return 0;
}
