#include <vector>

#ifndef GRADESUTILITY_H
#define GRADESUTILITY_H

class GradesUtility
{
private:
	int AmountOfStudents;
	std::vector<int> StoredGrades;
	int IndividualGrades[6];

public:
	GradesUtility(int amount_of_students);
	void PrintGreeting();
	void SetDefaultGrades();
	void SetCollectGrades();
	void SetRandomGrades();
	void CountIndividualGrades();
	void PrintStoredGrades();
	void PrintAverageGrade();
	void PrintBestAndWorstGrade();
	void PrintNotenSpiegel();
	int BestGrade();
	int WorstGrade();
	int DetermineLength();
};

#endif // GRADESUTILITY_H