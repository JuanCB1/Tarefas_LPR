#include <iostream>

#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Reset   "\033[0m"

using namespace std;

int reverterNumero(int num) {
    int numeroRevertido = 0;

    while (num > 0) {
        int digito = num % 10;
        numeroRevertido = numeroRevertido * 10 + digito; 
        num = num / 10;
    }
    
    return numeroRevertido;
}

int main() {
    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 1   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    int numero;
    int numeroRevertido = reverterNumero(numero);

    cout << "Digite seu numero inteiro: ";
    cin >> numero;
    
    cout << "Número revertido: " << numeroRevertido << endl;
    
    return 0;
}