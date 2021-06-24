#include <iostream>
#include <string>

const int LENGTH = 100;

bool isPalindrome(char pcWord[LENGTH], int piLen);

int main() {
    char newWord[LENGTH];

    for (char & i : newWord) {
        i = '\0';
    }

    std::cout << "Enter a word to check for palindrome: " << std::endl;
    std::cin >> newWord;

    int len = getLength(newWord);
    bool pal = isPalindrome(newWord, len);

    if (isPalindrom(inputArray, length))
        cout << "It's a palindrome" << endl;
    else
        cout << "It's NOT a palindrome!" << endl;
    
    return 0;
}

int getLength(char p_word[LENGTH]) {
    for (int i = 0; i < LENGTH; i++) {
        if (newWord[i] == '\0') {
            return i;
        }
    }
}

bool isPalindrome(char pcWord[LENGTH], int piLen) {
    for (int i = 0; i < length / 2; i++) {
        if (pcWord[i] == pcWord[piEndIndex - 1 - i])
            std::cout << pcWord[i] << " and " << pcWord[piEndIndex - 1 - i] << " are equal." << std::endl;
        else
            return false;
    }
    return true;
}