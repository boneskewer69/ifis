#include <iostream>
#include <string>

using namespace std;

int main()
{
	const int NUM_SUBJECTS = 3;
	const int NUM_GRADES = 4;

	string subjects[NUM_SUBJECTS];
	int grades[NUM_SUBJECTS][NUM_GRADES];
	double average[NUM_SUBJECTS];

	// input Subjects and Grades
	for (int subject = 0; subject < NUM_SUBJECTS; subject++)
	{
		cout << "Enter " << subject + 1 << ". subject name: ";
		cin >> subjects[subject];
		for (int grade = 0; grade < NUM_GRADES; grade++)
		{
			cout << "Enter " << grade + 1 << ". mark for " << subjects[subject] << " : ";
			cin >> grades[subject][grade];
		}
		cout << endl;
	}

	// calculate averages
	for (int subject = 0; subject < NUM_SUBJECTS; subject++)
	{
		double tempAverage = 0;
		for (int grade = 0; grade < NUM_GRADES; grade++)
		{
			tempAverage += grades[subject][grade];
		}
		average[subject] = tempAverage / NUM_GRADES;
		cout << "Average grade of " << subjects[subject] << ": " << average[subject] << endl;
	}
	cout << endl;

	// print table
	for (int subject = 0; subject < NUM_SUBJECTS; subject++)
	{
		cout << subjects[subject];
		for (int grade = 0; grade < NUM_GRADES; grade++)
		{
			cout << "\t" << grades[subject][grade];
		}
		cout << "\t" << average[subject];
		cout << endl;
	}

	// task 2
	double totalAverage = 0;
	for (int subject = 0; subject < NUM_SUBJECTS; subject++)
	{
		totalAverage += average[subject];
	}
	totalAverage = totalAverage / NUM_SUBJECTS;
	cout << "Total average is: " << totalAverage << endl;

	// task 3
	string searchSubject;
	cout << endl;
	cout << "Enter a subject name to display all grades: ";
	cin >> searchSubject;
	for (int subject = 0; subject < NUM_SUBJECTS; subject++)
	{
		if (searchSubject == subjects[subject])
		{
			cout << "Grades of subject " << subjects[subject] << ": ";
			for (int grade = 0; grade < NUM_GRADES; grade++)
			{
				cout << "\t" << grades[subject][grade];
			}
			cout << endl;
		}
	}

	system("pause");
	return 0;
}