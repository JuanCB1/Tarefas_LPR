#include <iostream>

#define Blue    "\033[34m"
#define Reset   "\033[0m"

using namespace std;

int main() {
    int soma = 0;

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 3   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;
    
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    
    cout << Blue << "A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: " << Reset << soma << endl;
    
    return 0;
}