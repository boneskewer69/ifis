#include <iostream>
#include <ctime>

int sumFromTo(int num1, int num2);
double averageOfRandomNumbers(int limit);

int main() {
    srand((unsigned)time(NULL));

    std::cout << "Sum From To: " << sumFromTo(3, 6) << std::endl;
    std::cout << "Average of Random Numbers: " << averageOfRandomNumbers(10) << std::endl;
    return 0;
}

int sumFromTo(int num1, int num2) {
    int sum = 0;

    for (int i = num1; i <= num2; i++) {
        sum += i;
    }
    
    return sum;
}

double averageOfRandomNumbers(int limit) {
    double average = 0;

    for (int i = 0; i < 3; i++) {
        average += rand() % limit;
    }

    average /= 3;

    return average;
}