#include <iostream>

unsigned long long int fib(unsigned long long int target, unsigned long long int a, unsigned long long int b);

int main() {    
    std::cout << fib(75, 0, 1);

    return 0;
}

unsigned long long int fib(unsigned long long int target, unsigned long long int a, unsigned long long int b) {
    std::cout << a << " ";
    if (target == 0) {
        return a;
    }
    else {
        fib(target - 1, b, a + b);
    }
}