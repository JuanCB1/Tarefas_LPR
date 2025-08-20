/*
Exercício 2)
DO WHILE: Construa um algoritmo de adivinhação
de números. Com as linhas abaixo, o algoritmo
gerará um número inteiro aleatório de 1a 100:
(C#)
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
(C++)
random_device numAleatorio ;
uniform_int_distribution<> distribuicao(1,100);
int valorInteiro = distribuicao(numAleatorio);
O seu trabalho é elaborar um algoritmo em que o
usuário possa digitar números no console até
acertar o número inteiro aleatório valorInteiro, de 1 a
100. A cada chute, o programa deve responder com
“chutou alto”, “chutou baixo” ou “acertou”. Após
acertar, deve ser mostrado quantas tentativas foram
usadas para descobrir o número.
*/

// Funções necessárias
#include <iostream>
#include <random>

#define Yellow "\033[33m"
#define Red "\033[31m"
#define Blue "\033[34m"
#define Green "\033[32m"
#define Reset "\033[0m"

using namespace std;

int main()
{
    // Configuração do gerador de números aleatórios
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio); // Gera número entre 1 e 100
    int palpite, tentativas = 0;

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 2   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    cout << "Tente adivinhar o número entre 1 e 100!" << endl;

    // Loop principal do jogo
    do
    {
        cout << "Digite seu palpite: ";
        cin >> palpite;
        tentativas++; // Conta as tentativas

        // Fornece dicas baseadas no palpite
        if (palpite > valorInteiro)
        {
            cout << Yellow << "Chutou alto! Tente novamente." << Reset << endl;
        }
        else if (palpite < valorInteiro)
        {
            cout << Red << "Chutou baixo! Tente novamente." << Reset << endl;
        }
        else
        {
            cout << Green << "Acertou! Você precisou de " << Reset << tentativas << Green << " tentativas." << Reset << endl;
        }
    } while (palpite != valorInteiro); // Continua até acertar

    return 0;
}
