#include <iostream>
#include <string>
#include <math.h>

using namespace std;

void subtask1_exercise1();
void subtask1_exercise2();
void subtask1_exercise3();
void subtask1_exercise4();

void subtask2_exercise1();
void subtask2_exercise2();
void subtask2_exercise3();

bool evaluate_leap_year(int year);

void spacer();

int main() {

	int task;
	int subtask1;
	int subtask2;
	string decision;

	spacer();

	cout << "Aufgaben vom 25.11.2019 AWE Kitzelmann, Fritz Anuth" << endl;

	spacer();

	while (true) {

		cout << "1. Aufgabenblatt: Selektion mit if, if-else\n2. Aufgabenblatt: Selektion II if / else if / else\n> ";
		cin >> task;

		spacer();

		if (task == 1) {

			cout << "1. Tuersteher\n2. Tuersteher II\n3. Punkte beim Fussballspiel\n4. Ueberpruefen einer Zahl\n> ";
			cin >> subtask1;

			if (subtask1 == 1) {

				spacer();
				subtask1_exercise1();

			}
			else if (subtask1 == 2) {

				spacer();
				subtask1_exercise2();

			}
			else if (subtask1 == 3) {

				spacer();
				subtask1_exercise3();

			}
			else if (subtask1 == 4) {

				spacer();
				subtask1_exercise4();

			}
			else {

				cout << "Du kannst echt nicht lesen nh?" << endl;

			}
		}
		else if (task == 2) {

			cout << "1. Begruessung\n2. BMI-Rechner\n3. Anzahl der Tage im Monat\n> ";
			cin >> subtask2;

			if (subtask2 == 1) {

				spacer();
				subtask2_exercise1();

			}
			else if (subtask2 == 2) {

				spacer();
				subtask2_exercise2();

			}
			else if (subtask2 == 3) {

				spacer();
				subtask2_exercise3();

			}
			else {

				cout << "Du kannst echt nicht lesen nh?" << endl;

			}


		}

		spacer();

		cout << "Soll das Programm hier beendet werden (j oder n)?\n> ";
		cin >> decision;

		spacer();

		if (decision == "j") {

			break;

		}

		system("cls");

	}
	return 0;
}


void spacer() {

	cout << "\n\n- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n" << endl;

}

void subtask1_exercise1() {

	int age;

	cout << "Wie alt bist du?\n> ";
	cin >> age;

	if (age < 18) {

		cout << "Sorry Mann, werd erstmal volljaehrig!" << endl;

	}
	else {

		cout << "OK, komm rein!" << endl;

	}

}


void subtask1_exercise2() {

	int age;
	string name;

	cout << "Wie alt bist du?\n> ";
	cin >> age;

	if (age < 18) {

		cout << "Sorry Mann, werd erstmal volljaehrig!" << endl;

	}
	else {
		cout << "Wie ist dein Name?\n> ";
		cin >> name;

		if (name == "Sebastian") {

			cout << "Du kommst nicht rein!" << endl;

		}
		else {

			cout << "OK, komm' rein" << endl;
		}
	}
}


void subtask1_exercise3() {

	int scoreA;
	int scoreB;

	cout << "Geben sie den Punktestand ein." << endl;
	cout << "Mannschaft A:\n> ";
	cin >> scoreA;
	cout << "Mannschaft B:\n> ";
	cin >> scoreB;
	cout << endl;

	if (scoreA == scoreB) {

		cout << "Tore Mannschaft A: " << scoreA << endl;
		cout << "Tore Mannschaft B: " << scoreB << "\n" << endl;

		cout << "Es ist eine Unentschieden!" << "\n" << endl;

		cout << "Punkte Mannschaft A: 1" << endl;
		cout << "Punkte Mannschaft B: 1" << "\n" << endl;

	}
	if (scoreA > scoreB) {

		cout << "Tore Mannschaft A: " << scoreA << endl;
		cout << "Tore Mannschaft B: " << scoreB << "\n" << endl;

		cout << "Mannschaft A hat gewonnen!" << "\n" << endl;

		cout << "Punkte Mannschaft A: 3" << endl;
		cout << "Punkte Mannschaft B: 0" << "\n" << endl;

	}
	if (scoreA < scoreB) {

		cout << "Tore Mannschaft A: " << scoreA << endl;
		cout << "Tore Mannschaft B: " << scoreB << "\n" << endl;

		cout << "Mannschaft B hat gewonnen!" << "\n" << endl;

		cout << "Punkte Mannschaft A: 0" << endl;
		cout << "Punkte Mannschaft B: 3" << "\n" << endl;

	}

}


void subtask1_exercise4() {

	int number;

	cout << "Gib eine Nummer ein\n> ";
	cin >> number;

	if (number == 1000 || number > 0 && number < 100 ) {

		cout << "Nicht erlaubt!" << endl;

	}
	else {

		cout << "Erlaubt!" << endl;

	}

}


void subtask2_exercise1() {

	int age;
	string name;
	string lastname;
	string gender;

	cout << "Hallo!\nGeben Sie bitte ihr Geschlecht ein (m oder f).\n> ";
	cin >> gender;
	cout << "Geben Sie bitte ihr Alter ein.\n> ";
	cin >> age;
	cout << "Geben Sie bitte ihren Vornamen ein.\n> ";
	cin >> name;
	cout << "Geben Sie bitte ihren Nachnamen ein.\n> ";
	cin >> lastname;
	cout << endl;

	if (age < 18) {

		cout << "Hallo " << name << "!" << endl;

	}
	else if (gender == "m" && age >= 18) {

		cout << "Sehr geehrter Herr " << lastname << "!" << endl;

	}
	else if (gender == "f" && age >= 18) {

		cout << "Sehr geehrte Frau " << lastname << "!" << endl;

	}
}


void subtask2_exercise2() {

	double mass;
	double height;
	double body_mass_index;

	cout << "Um den BMI zu bestimmen geben sie bitte ihr Koerpergewicht und ihre Koerpergroesse ein.\n";
	cout << "Koerpergewicht:\n> ";
	cin >> mass;
	cout << "Koerpergroesse:\n> ";
	cin >> height;

	/*
	< 18,5 -> Untergewicht
	18,5 bis < 25 -> Normalgewicht
	25 bis < 30 -> �bergewicht
	30 und mehr -> Adipositas
	*/

	height = pow(height, 2);
	body_mass_index = mass / height;
	// body_mass_index = round(body_mass_index);


	if (body_mass_index < 18.5) {

		cout << "Der BMI betraegt: " << body_mass_index << "\nUntergewicht" << endl;

	}
	else if (body_mass_index > 18.5 || body_mass_index < 25) {

		cout << "Der BMI betraegt: " << body_mass_index << "\nNormalgewicht" << endl;

	}
	else if (body_mass_index > 25 || body_mass_index < 30) {

		cout << "Der BMI betraegt: " << body_mass_index << "\nUebergewicht" << endl;

	}
	else if (body_mass_index > 30) {

		cout << "Der BMI betraegt: " << body_mass_index << "\nAdipositas" << endl;

	}

}


void subtask2_exercise3() {

	int month;
	int leap_year;

	cout << "Geben sie den Monat ein (1 = Januar...), von dem sie die Anzahl der Tage erfahren wollen.\n> ";
	cin >> month;

	if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {

		cout << "31 Tage" << endl;

	}
	else if (month == 2) {

		cout << "Eingabe des Jahrs (Um zu bestimmen ob es sich um ein Schaltjahr handelt)\n> ";
		cin >> leap_year;

		if (evaluate_leap_year(leap_year) == true) {

			cout << "\n29 Jahre" << endl;

		}
		else if (evaluate_leap_year(leap_year) == false) {

			cout << "\n28 Jahre" << endl;

		}

	}
	else if (month == 4, month == 6 || month == 9 || month == 11) {

		cout << "30 Tage" << endl;

	}
	else {

		cout << "Schon belastend zu wissen, dass ich nicht lesen kann nh?" << endl;
		cout << "Monat " << month << " existiert nicht!" << endl;

	}

}


bool evaluate_leap_year(int year) {

	if (year % 4 == 0) {

		if (year % 100 == 0) {

			if (year % 400 == 0) {

				cout << year << " ist ein Schaltjahr." << endl;
				return true;

			}
			else {

				cout << year << " ist kein Schaltjahr." << endl;
				return false;

			}

		}
		else {

			cout << year << " ist ein Schaltjahr." << endl;
			return true;

		}

	}
	else {

		cout << year << " ist kein Schaltjahr." << endl;
		return false;
	}


}
