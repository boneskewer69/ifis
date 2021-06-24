#include<iostream> 
#include <math.h>
#include <string>
using namespace std;

// Ex 1: Resistor connected in parallel
/*md

int main() {
	short resistor1;
	short resistor2;
	float totalResistance;

	cout << "The total resistence Rt of two resistors R1 and R2 connected in parallel is computed according to the formula: Rt = (R1 * R2) / (R1 + R2)" << endl;
	cout << "R1: " << endl;
	cin >> resistor1;
	cout << "R2: " << endl;
	cin >> resistor2;

	totalResistance = (resistor1 * resistor2) / (resistor1 + resistor2);

	cout << totalResistance << endl;

	system("pause");
	return 0;
}
*/

// Ex 2: Convert a number of days into weeks and remaining days
/*
int main() {
	short daysInput;
	short leftDays;
	short weeks;

	cout << "Number of Days: ";
	cin >> daysInput;
	
	leftDays = daysInput % 7;
	weeks = daysInput / 7;

	cout << weeks << " weeks and " << leftDays << " days." << endl;
	system("pause");
	return 0;
}
*/

// Ex 3: Basic metabolic rate
/*
int main() {

float menBMR;
float womenBMR;
float mass;
float height;
float age;
string gender;

cout << "Body weight (in kg): ";
cin >> mass;
cout << "Height (in cm): ";
cin >> height;
cout << "Age (in years): ";
cin >> age;
cout << "Your gender (m or w): ";
cin >> gender;


if (gender == "m"){
menBMR = 66.47 + 13.7 * mass + 5 * height - 6.8 * age;
cout << "Men: " << menBMR << " calories per day" << endl;
}

if (gender == "w"){
womenBMR = 655.1 + 9.6 * mass + 1.8 * height - 4.7 * age;
cout << "Women: " << womenBMR << " calories per day" << endl;
}


system("pause");
return 0;
}
*/

// Ex 4: Blood alcohol content
/*
int main() {
	
	float alcohol;
	float amountDrink;
	float alcoholPercentage;
	
	float bloodAlcoholContent;
	float weight;

	cout << "Enter the consumed amount: ";
	cin >> amountDrink;
	cout << "Enter the alcohol content of the drink (5% = 0.05): ";
	cin >> alcoholPercentage;

	alcohol = amountDrink * alcoholPercentage * 0.8;
	
	cout << "You consumed " << alcohol << " grams of alcohol." << endl;

	cout << "Enter your body weight: ";
	cin >> weight;

	bloodAlcoholContent = alcohol / (weight * 0.7);

	cout << "Your blood alcohol content is " << bloodAlcoholContent << " per mil." << endl;


	system("pause");
	return 0;
}
*/



