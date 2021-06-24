#include<iostream> 
#include <math.h>
#include <string>
using namespace std;

int main()
{

	string firstName;
	string lastName;
	char sex;
	short yearOfBirth;
	short currentYear;
	// currentYear
	short age;
	int ageInHours;
	string birthdayThisYear;

	cout << "About me" << endl;
	cout << "First name: ";
	cin >> firstName;
	cout << "Last name: ";
	cin >> lastName;
	cout << "Your sex: ";
	cin >> sex;
	cout << "The year of your birth: ";
	cin >> yearOfBirth;
	cout << "Did you birthday already took place this year? (enter True or False): ";
	cin >> birthdayThisYear;
	cout << "Current Year: ";
	cin >> currentYear;
	cout << "---------------------------" << endl;
	cout << "You are " << firstName << " " << lastName << " (" << sex << ")." << endl;
	
	age = currentYear - yearOfBirth;

	// if-statement
	if (birthdayThisYear == "True") {
		cout << "You are " << age << " years old." << endl;
		ageInHours = 365 * 24 * age;
		cout << age << " years equal " << ageInHours << " hours." << endl;
	}
	else {
		cout << "You are " << age - 1 << " years old." << endl;
		ageInHours = 365 * 24 * (age - 1);
		cout << age << " years equal " << ageInHours << " hours." << endl;
	}

	system("pause");
	return 0;

}
