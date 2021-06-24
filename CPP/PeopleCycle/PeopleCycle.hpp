#include <vector>

#ifndef PEOPLECYCLE_H
#define PEOPLECYCLE_H

class PeopleCycle
{
private:
	std::vector<int> mv_People;
	std::vector<int> mv_PeopleNextGen;
	int mi_AmountOfPeople;
	int mi_CountGeneration = 0;
	int mi_Counter = 0;

	void FillVector();
	void PrintLeftPeopleAndLaps();
	void FilterProcedure();
	
public:
	PeopleCycle(int p_amountOfPeople);
	void Run();
};

#endif // !PEOPLECYCLE_H