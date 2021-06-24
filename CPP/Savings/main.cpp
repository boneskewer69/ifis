#include <iostream>

void spacer();

void savings_calculator();
void savings_calculator_variation();

void repetition_for();
void repetition_while();
void repetition_dowhile();


void spacer()
{
	std::cout << "\n\n- - - - - - - - - -\n\n" << std::endl;
}

void savings_calculator()
{
	spacer();

	std::cout << "Savings Calculator" << std::endl;

	spacer();

	double initial_balance;
	double savings_targets;
	double savings_per_year;
	double interest;
	double sum = 0;
	int year = 1;

	std::cout << "Please enter your initial balance: ";
	std::cin >> initial_balance;
	std::cout << "Please enter your savings target: ";
	std::cin >> savings_targets;
	std::cout << "Please enter your annual saving amount: ";
	std::cin >> savings_per_year;
	std::cout << "Please enter the annually applied interest rate in percent: ";
	std::cin >> interest;

	spacer();

	sum += initial_balance;

	do
	{
		sum += savings_per_year;
		sum += (interest / 100) * sum;

		std::cout << "After " << year << " years: $" << sum << std::endl;
		year++;

	} while (sum <= savings_targets);

	spacer();

	std::cout << "Saving target reached after " << year << " years." << std::endl;

	spacer();
}

void savings_calculator_variation()
{
	spacer();

	std::cout << "Savings Calculator Variation" << std::endl;

	spacer();

	double initial_balance;
	double savings_per_year;
	double interest;
	double sum = 0;
	int years = 1;

	std::cout << "Please enter your initial balance: ";
	std::cin >> initial_balance;
	std::cout << "Please enter how many years you want to safe: ";
	std::cin >> years;
	std::cout << "Please enter your annual saving amount: ";
	std::cin >> savings_per_year;
	std::cout << "Please enter the annually applied interest rate in percent: ";
	std::cin >> interest;

	spacer();

	sum += initial_balance;

	for (int y = 1; y <= years; y++)
	{
		sum += savings_per_year;
		sum += (interest / 100) * sum;

		std::cout << "After " << y << " years: $" << sum << std::endl;
	}

	spacer();

	std::cout << "Target reached after " << years<< " years." << std::endl;
}

int savings_calculation()
{
	return 0;
}

void repetition_for()
{
	int zahl = 0;
	int summe = 0;


	for (int i = 1; i <= 5; i++)
	{
		std::cout << i << ". Enter Amount: " << std::endl;
		std::cin >> zahl;
		summe += zahl;
	}

	std::cout << "Your total amount is: " << summe << std::endl;
}

void repetition_while()
{
	int zahl = 0;
	int summe = 0;
	int i = 1;

	while (i <= 5)
	{
		std::cout << i << ". Enter Amount: " << std::endl;
		std::cin >> zahl;
		summe += zahl;
		i++;
	}

	std::cout << "Your total amount is: " << summe << std::endl;
}

void repetition_dowhile()
{
	int zahl = 0;
	int summe = 0;
	int i = 1;

	do
	{
		std::cout << i << ". Enter Amount: " << std::endl;
		std::cin >> zahl;
		summe += zahl;
		i++;
	} while (i <= 5);

	std::cout << "Your total amount is: " << summe << std::endl;
}