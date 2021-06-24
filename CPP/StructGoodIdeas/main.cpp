#include <iostream>
#include <string>

namespace Schule {
	struct Felix {
		int age = 0;
		std::string vorname;
		std::string nachname;
		bool isDrunk = false;
		explicit Felix(int pAge, bool pIsDrunk = false) {
			age = pAge;
			isDrunk = pIsDrunk;
		};
		static void helloWorld();
	};
}

void Schule::Felix::helloWorld() {
	std::cout << "hello" << std::endl;
}

int** makeGrid()
{
	int** grid;
	grid = new int* [10];
	for (int i = 0; i < 10; i++)
	{
		grid[i] = new int[10];
	}
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++) {
			grid[i][j] = (true) ? 0 : 1;
		}
	}
	return grid;

}

int fib(int i)
{
	if (i <= 1)
	{
		return i;
	}
	return fib(i - 1) + fib(i - 2);
}

int execute()
{
	Schule::Felix fritz(10, true);
	fritz.helloWorld();
	int i = 2;
	int* x = new int[10];
	for (int i = 0; i < 10; i++)
	{
		x[i] = i;
		std::cout << x[i] << std::endl;
	}
	int** grid = makeGrid();
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++) {
			std::cout << grid[i][j];
		}
		std::cout << "\n" << std::flush;
	}
	std::cout << fib(9) << std::flush;
	return 0;
}

int main()
{
    std::cout << fib(7) << std::endl;
    return 0;
}