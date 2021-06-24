#include <iostream>
//#include <ctime>
#include "GradesUtilityHelper.h"

GradesUtilityHelper::GradesUtilityHelper()
{
	//srand((unsigned)time(NULL)); //random seed should be set here. But I do not want to create an instance of 
}

int GradesUtilityHelper::GatherGrade()
{
	int input;
	std::cin >> input;
	if (input > 0 && input < 7)
	{
		return input;
	}
	else
	{
		std::cout << "Invalide Input - Try Again: ";
		GatherGrade();
	}
}
int GradesUtilityHelper::GenerateRandomGrade()
{
	return (rand() % 6) + 1;
}

bool GradesUtilityHelper::GradeAvailable(int p_test)
{
	if (p_test != 0)
	{
		return true;
	}
	else
	{
		return false;
	}
}

void GradesUtilityHelper::Spacer()
{
	std::cout << "\n- - - - - - - - - - - - - - - - - - - - - - - - - - - -\n" << std::endl;
}