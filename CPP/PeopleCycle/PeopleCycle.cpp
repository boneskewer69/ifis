#include <iostream>
#include <vector>

#include "PeopleCycle.hpp"

/*
 TODO: nur ein Vektor
*/

PeopleCycle::PeopleCycle(int p_amountOfPeople)
{
	mi_AmountOfPeople = p_amountOfPeople;
}

void PeopleCycle::FillVector()
{
	for (int i = 0; i < mi_AmountOfPeople; i++)
	{
		mv_People.push_back(i + 1);
	}
}
void PeopleCycle::PrintLeftPeopleAndLaps()
{
	std::cout << "Laps: " << mi_CountGeneration << std::endl << std::endl;

	for (int i = 0; i < mv_People.size(); i++)
	{
		std::cout << "Person Number " << mv_People.at(i) << " still alive." << std::endl;
	}
}
void PeopleCycle::FilterProcedure()
{
	mi_Counter = 1;
	while (mi_AmountOfPeople > 2)
	{
		for (int i = 0; i < mv_People.size(); i++) 
		{
			if (mi_Counter % 3 != 0)
				mv_PeopleNextGen.push_back(mv_People.at(i));  // why?!
			else
				mi_AmountOfPeople -= 1; // you're great genius
			mi_Counter += 1;
		}
		mv_People.erase(mv_People.begin(), mv_People.end());
		mv_People = mv_PeopleNextGen;
		mv_PeopleNextGen.erase(mv_PeopleNextGen.begin(), mv_PeopleNextGen.end());
		mi_CountGeneration += 1;
	}
}
void PeopleCycle::Run()
{
	std::cout << "Amount Of People: " << mi_AmountOfPeople << std::endl;
	FillVector();
	FilterProcedure();
	PrintLeftPeopleAndLaps();
}