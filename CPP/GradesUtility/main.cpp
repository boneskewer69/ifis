#include <iostream>
#include <ctime>

#include "GradesUtility.h"
#include "GradesUtilityHelper.h"

void ExerciseAdvanced(int mode, int amout_of_students = 20)
{
	///<summary>
	/// Controls the Class and executes one of the 3 different modes. To select a mode pass an argument.
	///<summary>
	///<param name="mode"> mode=1 -> collect user input, mode=2 -> set default grades from task, mode=3 -> generate random numbers</param>
	///<param name="amount_of_students"> set the amount of students; default: 20 </param>

	srand((unsigned)time(NULL));
	GradesUtility exercise(amout_of_students);
	exercise.PrintGreeting();

	switch (mode)
	{
	case 1:
		exercise.SetCollectGrades();
		break;
	case 2:
		exercise.SetDefaultGrades();
		break;
	case 3:
		exercise.SetRandomGrades();
		break;
	default:
		exercise.SetCollectGrades();
		break;
	}

	exercise.PrintStoredGrades();
	exercise.PrintAverageGrade();
	exercise.PrintBestAndWorstGrade();
	exercise.PrintNotenSpiegel();
}

void ExerciseStandart()
{
	const int AMOUNT_OF_STUDENTS = 20; // Anzahl der Schüler -> konstante damit ich damit das Array erstellen kann
	int StoredGrades[AMOUNT_OF_STUDENTS]; // Erstellung des Arrays
	double average_grade; // double als Datentyp für die Durchschnittsnote
	int sum_grades = 0; // Summe der Noten als int zur Berechnung der Durchschnittsnote

	std::cout << "Store " << AMOUNT_OF_STUDENTS << " grades and compute average." << std::endl;
	//gather all grades
	for (int i = 0; i < AMOUNT_OF_STUDENTS; i++)
	{
		std::cout << i + 1 << ". Grade: ";
		StoredGrades[i] = GradesUtilityHelper().GatherGrade(); // im Prinzip 'cin' bloß filter ich alles ausser die Noten 1-6 raus
	}
	std::cout << "All Grades Entered" << std::endl;

	//print all grades
	std::cout << "Stored grades: ";
	for (int i = 0; i < AMOUNT_OF_STUDENTS; i++)
	{
		std::cout << StoredGrades[i] << " ";
	}
	std::cout << std::endl;

	//print average
	for (int i = 0; i < AMOUNT_OF_STUDENTS; i++)
	{
		sum_grades += StoredGrades[i]; // alle Noten werden zusammengezählt
	}
	average_grade = (double)sum_grades / (double)AMOUNT_OF_STUDENTS; // sum_grades und AMOUNT_OF_STUDENTS werden als double gecastet,
																	 // damit der Durchschnitt berechnet werden kann.
	std::cout << "Average grade: ";
	std::cout << average_grade << std::endl;
}

int main()
{
	ExerciseAdvanced(1, 5);
	//ExerciseStandart();
	
	return 0;
}