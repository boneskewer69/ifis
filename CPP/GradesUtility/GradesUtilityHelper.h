#ifndef GRADESUTILITYHELPER_H
#define GRADESUTILITYHELPER_H

class GradesUtilityHelper
{
public:
	GradesUtilityHelper();
	int GatherGrade();
	int GenerateRandomGrade();
	bool GradeAvailable(int p_test);
	void Spacer();
};

#endif // GRADESUTILITYHELPER_H