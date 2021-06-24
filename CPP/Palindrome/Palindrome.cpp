#include <iostream>
#include <string>

bool check(std::string psWord);
bool newCheck(char pcWord[100], int piMiddleIndex, int piEndIndex);

int main() {
    std::string word;
    char newWord[100];
    int middleIndex = 0;
    int length = 0;

    for (char& i : newWord) {
        i = '\0';
    }

    std::cout << "Enter a word to check for palindrome: " << std::endl;
    std::cin >> newWord;

    for (int i = 0; i < 100; i++) {
        if (newWord[i] == '\0') {
            length = i;
            middleIndex = length / 2;
            break;
        }
    }

    newCheck(newWord, middleIndex, length);
    return 0;
}

bool check(std::string psWord) {
    int middleIndex = psWord.size() / 2;
    for (int i = 0; i < middleIndex; i++) {
        if (psWord.at(i) == psWord.at(psWord.size() - 1 - i))
            std::cout << psWord.at(i) << " and " << psWord.at(psWord.size() - 1 - i) << " are equal." << std::endl;
        else {
            std::cout << psWord << " is not a palindrome." << std::endl;
            return false;
        }
    }
    std::cout << psWord << " is a palindrome." << std::endl;
    return true;
}

bool newCheck(char pcWord[100], int piMiddleIndex, int piEndIndex) {
    for (int i = 0; i < piMiddleIndex; i++) {
        if (pcWord[i] == pcWord[piEndIndex - 1 - i])
            std::cout << pcWord[i] << " and " << pcWord[piEndIndex - 1 - i] << " are equal." << std::endl;
        else {
            std::cout << "It's not a palindrome." << std::endl;
            return false;
        }
    }
    std::cout << "It's a palindrome." << std::endl;
    return true;
}