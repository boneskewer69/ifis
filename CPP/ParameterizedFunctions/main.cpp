#include <iostream>

void numbersFromTo(int num1, int num2);

int main() {
    int number1;
    int number2;

    std::cin >> number1;
    std::cin >> number2;

    numbersFromTo(number1, number2);
    
    return 0;
}

void numbersFromTo(int num1, int num2) {
    for (int i = num1; i <= num2; i++) {
        std::cout << i << " ";
    }
}
