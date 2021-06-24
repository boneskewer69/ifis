#include<iostream>
#include<string>
using namespace std;

/* An example for using functions to work on several exercises within one single Visual Studio project!
   The code for each exercise goes into a seperate function (see below). */

// First, list the headers of all those functions above the main function.
void exercise1();
void exercise2();

// the main function
int main() {
	cout << "How to use functions to work on several exercises within one single Visual Studio project!" << endl;

	// In the main function, write calls of all functions and 
	// comment out all calls except the one you are currently working on or you want to present.
	exercise1();
	exercise2();

	system("pause");
	return 0;
}


// Below the main function, write one function for each exercise.

// function for exercise 1
void exercise1() {
	// greeting
	string name;
	cout << "Hi, what's your name?" << endl;
	cin >> name;
	cout << "Hi " << name << endl << endl;
}


// function for exercise 2
void exercise2() {
	// if-else-example
	int number;
	// read in a number
	cout << "Enter an integer number: ";
	cin >> number;

	if (number < 0) {
		// negative
		cout << "You entered a negative number." << endl;
	}
	else if (number > 0) {
		// positive
		cout << "You entered a positive number." << endl;
	}
	else {
		// it must have been the 0
		cout << "You entered the zero." << endl;
	}
	cout << endl;
}