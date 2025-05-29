#include <iostream>
#include <vector>

#define Yellow  "\033[33m"
#define Red     "\033[31m"
#define Blue    "\033[34m"
#define Reset   "\033[0m"

using namespace std;

int main() {
    int numeros[10];

    cout << Blue << "-----------------" << Reset << endl;
    cout << Blue << "   Exercício 1   " << Reset << endl;
    cout << Blue << "-----------------" << Reset << endl;

    cout << "Digite 10 números inteiros:\n";
    for (int i = 0; i < 10; i++) {
        cout << "Número " << i + 1 << ": ";
        cin >> numeros[i];
    }

    vector<int> pares;
    vector<int> impares;

    for (int i = 0; i < 10; i++) {
        if (numeros[i] % 2 == 0) {
            pares.push_back(numeros[i]);
        } else {
            impares.push_back(numeros[i]);
        }
    }

    cout << Red << "\nNúmeros pares: " << Reset;
    for (int num : pares) {
        cout << num << " ";
    }

    cout << Yellow << "\nNúmeros ímpares: " << Reset;
    for (int num : impares) {
        cout << num << " ";
    }

    cout << endl;
    return 0;
}