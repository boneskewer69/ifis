#include <iostream>
#include <cmath>

int c_add(int a, int b);
int c_mult(int a, int b);
int c_pow(int base, int exponent);

int main() {
    int addA = 6;
    int addB = 12;
    int addResult = c_add(addA, addB);
    int addTestResult = addA + addB;
    std::cout << addA << " + " << addB << " = " << addResult << std::endl;
    if (addResult == addTestResult) {
        std::cout << "Result correct!" << std::endl;
    }
    else {
        std::cout << "Result wrong! Expected: " << addTestResult << " Got: " << addResult << std::endl;
    }

    int multA = 5;
    int multB = 5;
    int multResult = c_mult(multA, multB);
    int multTestResult = multA * multB;
    std::cout << multA << " * " << multB << " = " << multResult << std::endl;
    if (multResult == multTestResult) {
        std::cout << "Result correct!" << std::endl;
    }
    else {
        std::cout << "Result wrong! Expected: " << multTestResult << " Got: " << multResult << std::endl;
    }

    int powA = 2;
    int powB = 4;
    int powResult = c_pow(powA, powB);
    int powTestResult = pow(powA, powB);
    std::cout << powA << " ^ " << powB << " = " << powResult << std::endl;
    if (powResult == powTestResult) {
        std::cout << "Result correct!" << std::endl;
    }
    else {
        std::cout << "Result wrong! Expected: " << powTestResult << " Got: " << powResult << std::endl;
    }

    return 0;
}

int c_add(int a, int b) {
    int sum = a;

    for (int i = 0; i < b; i++) {
        sum++;
    }

    return sum;
}

int c_mult(int a, int b) {
    int product = 0;

    for (int i = 0; i < b; i++) {
        product = c_add(product, a);
    }

    return product;
}

int c_pow(int base, int exponent) {
    int exponential = base;

    for (int i = 1; i < exponent; i++) {
        exponential = c_mult(exponential, base);
    }

    return exponential;
}
