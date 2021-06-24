#include <iostream>

using namespace std;

double Quadrieren(double);
void ExecuteQuadrieren();
double BerechnungEinParam(double);
double BerechnungZweiParam(double, double);
void UeberschriftAusgabe();

int main()
{
	ExecuteQuadrieren();
	UeberschriftAusgabe();
	cout << BerechnungEinParam(3) << endl;
	cout << BerechnungZweiParam(3, 4) << endl;
	return 0;
}

void ExecuteQuadrieren()
{
	double userInput;
	cout << "Enter number to claculate square: ";
	cin >> userInput;
	cout << endl << "Result: " << Quadrieren(userInput) << endl << endl;
}

double Quadrieren(double x)
{
	return x * x;
}

void UeberschriftAusgabe()
{
	cout << "Hi, ich bin eine Ueberschrift." << endl;
}

double BerechnungEinParam(double x)
{
	return x + 100;
}

double BerechnungZweiParam(double x, double y)
{
	return x * y;
}