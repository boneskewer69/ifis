#include <iostream>
#include <string>
#include <list>

using namespace std;


void spacer();
void test1();
void aufgabe1();



int main() {
	int test;

	aufgabe1();
	cin >> test;

	return 0;
}


void test1() {
	cout << "Hello world!" << endl;
	int x;
	x = 5;

	while (x > 0) {
		spacer();
		cout << "\n" << x << endl;
		x--;
	}
	spacer();
}


void spacer() {
	cout << "\n\n- - - - - - - - - - - - - - -\n\n";
}


void aufgabe1() {

	/*
		Hallo Welt mit einer while Schleife
	*/

	int i;
	int j;

	while (i < 10) {
		cout << i << ". Hello World" << endl;
	}

	do {
		cout << i << ". Hello World" << endl;
	} while (j < 10);

	for (int k; k < 10; k++) {
		cout << j << ". Hello World" << endl;
	}
}

/*
void excercise1() {
	int number1;
	int number2;

	cout << "You'll enter two numbers and the programm will print all numbers inbetween.\n";
	cout << "Enter number 1:\n> ";
	cin >> number1;
	cout << "Enter number 2:\n> ";
	cin >> number2;

	if (number2 > number1) {
		while (true) {
			cout << number2 << endl;
			if (number2 == number1) {
				break;
			}
			else {
				number2 = number2 - 1;
			}
		}
	}
	else {
		while (true) {
			cout << number1 << endl;
			if (number1 == number2) {
				break;

			}
			else {
				number1 = number1 - 1;
			}
		}
	}
}

void excercise2() {
	string password;
	password == "IFIS1";
	string user;

	while (user != password) {
		cout << "Please enter the password:\n> " << endl;
		cin >> user;
	}

	cout << "Access granted!" << endl;
}


void excercise3() {
	float number;

	cout << "Enter a number you want to divide until it's smaller than or equal 1:\n> ";
	cin >> number;
	cout << number << endl;

	while (number > 1) {
		number = number / 2;
		cout << number << endl;
	}
}


void excercise4() {
	int n, t1 = 0, t2 = 1, nextTerm = 0;
	cout << "Enter the number of terms: ";
	cin >> n;
	cout << "Fibonacci Series: ";
	for (int i = 1; i <= n; ++i) {
		if (i == 1) {
			cout << " " << t1;
			continue;
		}
		if (i == 2) {
			cout << t2 << " ";
			continue;
		}
		nextTerm = t1 + t2;
		t1 = t2;
		t2 = nextTerm;
		cout << nextTerm << " ";
	}
}


void excercise5() {
	cout << "Hi" << endl;
}


void presentation() {
	int i = 1;
	while (i <= 5) {
		cout << "Hello world!\n";
		i++;
	}
}
*/
