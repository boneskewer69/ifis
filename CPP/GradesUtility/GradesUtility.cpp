#include <iostream>
#include <vector>
#include <ctime>
#include <string>

#include "GradesUtility.h"
#include "GradesUtilityHelper.h"


GradesUtility::GradesUtility(const int p_AmountOfStudents)
{
	AmountOfStudents = p_AmountOfStudents;
	for (int i = 0; i < (sizeof(IndividualGrades) / sizeof(int)); i++)
	{
		IndividualGrades[i] = 0;
	}
};

void GradesUtility::PrintGreeting()
{
	GradesUtilityHelper().Spacer();
	std::cout << "Store " << AmountOfStudents << " grades and compute average." << std::endl;
	GradesUtilityHelper().Spacer();
}
void GradesUtility::SetDefaultGrades()
{
	StoredGrades = { 3, 2, 3, 3, 4, 2, 3, 5, 4, 4, 3, 2, 2, 1, 3, 3, 4, 5, 2, 5 };

	if (AmountOfStudents == 20)
	{
		for (int i = 0; i < AmountOfStudents; i++)
		{
			std::cout << i + 1 << ". Grade: " << StoredGrades[i] << std::endl;
		}
	}
	else
	{
		std::cout << "Default setting could not be loaded, because the amount of students does not equal 20." << std::endl;
		SetRandomGrades();
	}
	CountIndividualGrades();
}
void GradesUtility::SetCollectGrades()
{
	for (int i = 0; i < AmountOfStudents; i++)
	{
		std::cout << i + 1 << ". Grade: ";
		StoredGrades.push_back(GradesUtilityHelper().GatherGrade());
	}
	CountIndividualGrades();
}
void GradesUtility::SetRandomGrades()
{
	int generated_grade;
	StoredGrades = {};
	for (int i = 0; i < AmountOfStudents; i++)
	{
		generated_grade = GradesUtilityHelper().GenerateRandomGrade();
		StoredGrades.push_back(generated_grade);
		std::cout << i + 1 << ". Grade: " << generated_grade << std::endl;
	}
	CountIndividualGrades();
}
void GradesUtility::CountIndividualGrades()
{
	for (int i = 0; i < StoredGrades.size(); i++)
	{
		switch (StoredGrades[i])
		{
		case 1:
			IndividualGrades[0] += 1;
			break;
		case 2:
			IndividualGrades[1] += 1;
			break;
		case 3:
			IndividualGrades[2] += 1;
			break;
		case 4:
			IndividualGrades[3] += 1;
			break;
		case 5:
			IndividualGrades[4] += 1;
			break;
		case 6:
			IndividualGrades[5] += 1;
			break;
		default:
			break;
		}
	}
}
void GradesUtility::PrintStoredGrades()
{
	std::cout << std::endl << "All Grades Entered" << std::endl;
	GradesUtilityHelper().Spacer();
	std::cout << "Stored grades: ";
	for (int i = 0; i < AmountOfStudents; i++)
	{
		std::cout << StoredGrades[i] << " ";
	}
	std::cout << std::endl;
	GradesUtilityHelper().Spacer();
}
void GradesUtility::PrintAverageGrade()
{
	double average_grade;
	int sum_grades = 0;
	for (int i = 0; i < AmountOfStudents; i++)
	{
		sum_grades += StoredGrades[i];
	}
	average_grade = (double)sum_grades / (double)AmountOfStudents;
	std::cout << "Average grade: ";
	std::cout << average_grade << std::endl;
	GradesUtilityHelper().Spacer();
}
int GradesUtility::BestGrade()
{
	if (GradesUtilityHelper().GradeAvailable(IndividualGrades[0]))
	{
		return 1;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[1]))
	{
		return 2;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[2]))
	{
		return 3;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[3]))
	{
		return 4;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[4]))
	{
		return 5;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[5]))
	{
		return 6;
	}
}
int GradesUtility::WorstGrade()
{
	if (GradesUtilityHelper().GradeAvailable(IndividualGrades[5]))
	{
		return 6;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[4]))
	{
		return 5;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[3]))
	{
		return 4;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[2]))
	{
		return 3;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[1]))
	{
		return 2;
	}
	else if (GradesUtilityHelper().GradeAvailable(IndividualGrades[0]))
	{
		return 1;
	}
}
void GradesUtility::PrintBestAndWorstGrade()
{
	std::cout << "Best Grade: " << BestGrade() << std::endl;
	std::cout << "Worst Grade: " << WorstGrade() << std::endl;
	GradesUtilityHelper().Spacer();
}
int GradesUtility::DetermineLength()
{
	int len = 0;
	int temp_len = 0;
	for (int i = 0; i < (sizeof(IndividualGrades) / sizeof(int)); i++)
	{
		if (IndividualGrades[i] > 999)
		{
			temp_len = 4;
		}
		else if (IndividualGrades[i] > 99)
		{
			temp_len = 3;
		}
		else if (IndividualGrades[i] > 9)
		{
			temp_len = 2;
		}
		else
		{
			temp_len = 1;
		}

		if (temp_len > len)
		{
			len = temp_len;
		}

	}
	return len;
}
void GradesUtility::PrintNotenSpiegel()
{
	int len = DetermineLength();

	std::string splitter = "+---------";
	std::string grades =   "| Note    ";
	std::string amount = "| Anzahl  ";

	for (int j = 0; j < (sizeof(IndividualGrades) / sizeof(int)); j++)
	{
		splitter.append("+---");
		for (int i = 0; i < len * 2; i++)
		{
			splitter.append("-");
		}
	}
	splitter.append("+");

	for (int j = 0; j < (sizeof(IndividualGrades) / sizeof(int)); j++)
	{
		grades.append("| ");
		for (int i = 0; i < len; i++)
		{
			grades.append(" ");
		}
		grades.append(std::to_string(j + 1));
		for (int i = 0; i < len; i++)
		{
			grades.append(" ");
		}
		grades.append(" ");
	}
	grades.append("|");
	
	for (int j = 0; j < (sizeof(IndividualGrades) / sizeof(int)); j++)
	{
		amount.append("| ");
		for (int i = 0; i < len; i++)
		{
			amount.append(" ");
		}
		amount.append(std::to_string(IndividualGrades[j]));
		for (int i = 0; i < len; i++)
		{
			amount.append(" ");
		}
		amount.append(" ");
	}
	amount.append("|");

	std::cout << splitter << std::endl;
	std::cout << grades << std::endl;
	std::cout << splitter << std::endl;
	std::cout << amount << std::endl;
	std::cout << splitter << std::endl;
	GradesUtilityHelper().Spacer();
}