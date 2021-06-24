#include <iostream>
#include <string>

void myName();
void countdown();
void helloWorld();

int main() {
    myName();
    countdown();
    for (int i = 0; i < 5; i++) {
        for (int j = 0; j < i; j++) {
            std::cout << " ";
        }
        helloWorld();
        std::cout << "\n";
    }

    return 0;
}

void myName() {
    std::cout << "Author of this program is Fritz Anuth." << std::endl;
}

void countdown() {
    for (int i = 10; i > 1; i--) {
        std::cout << i << " ";
    }
    std::cout << "... Take Off!" << std::endl;
}

void helloWorld() {
    std::cout << "Hello world!";
}