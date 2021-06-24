#include <iostream>

void move(int count, int n1, int n3, int n2);

int main() {
    int numberOfDisks = 5;
    move(numberOfDisks, 1, 3, 2);

    return 0;
}

void move(int count, int n1, int n3, int n2) {
    if (count > 0) {
        move(count - 1, n1, n2, n3);
        std::cout << "Move disk " << count << " from " << n1 << " to " << n3 << "." << std::endl;
        move(count - 1, n2, n3, n1);
    }
}
