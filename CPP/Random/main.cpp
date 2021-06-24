#include <iostream>
#include <ctime>

void spacer();
double generate_random_double(int threshold);
int generate_random_int(int threshold);
void exercise1_normal();
void exercise1_random();
void exercise2();

int main()
{
	srand((unsigned)time(NULL));
	//exercise1_random();
	//spacer();
	exercise2();

	system("pause");

	return 0;
}

void spacer()
{
	std::cout << "\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n" << std::endl;
}

double generate_random_double(int threshold)
{
	double cordinate = rand() % threshold;
	cordinate -= 0.5 * threshold;
	cordinate = cordinate / 10.0;
	return cordinate;
}

int generate_random_int(int threshold)
{
	int cordinate = rand() % threshold;
	cordinate -= 0.5 * threshold;
	return cordinate;
}

void exercise1_normal()
{
	int const dimensions = 3;
	double v1[dimensions] = { 0, 0, 0 };
	double v2[dimensions] = { 0, 0, 0 };
	double v_result[dimensions] = { 0, 0, 0 };

	spacer();
	std::cout << "Calculate the sum of two vectors" << std::endl;
	spacer();

	std::cout << "Enter Values for Vector 1" << std::endl;
	for (int i = 0; i < dimensions; i++)
	{
		std::cout << i + 1 << ". parameter: ";
		std::cin >> v1[i];
	}
	spacer();

	std::cout << "Enter Values for Vector 2" << std::endl;
	for (int i = 0; i < dimensions; i++)
	{
		std::cout << i + 1 << ". parameter: ";
		std::cin >> v2[i];
	}
	spacer();

	std::cout << "Calculating..." << std::endl;
	spacer();

	for (int i = 0; i < dimensions; i++)
	{
		v_result[i] = v1[i] + v2[i];
	}

	std::cout << "Resulting Vector: " << std::endl;

	for (int i = 0; i < dimensions; i++)
	{
		std::cout << i + 1 << ". parameter: " << v_result[i] << std::endl;
	}
	spacer();
}

void exercise1_random()
{
	int const dimensions = 3;
	int threshold = 100;
	double v1[dimensions] = { generate_random_double(threshold), generate_random_double(threshold), generate_random_double(threshold) };
	double v2[dimensions] = { generate_random_double(threshold), generate_random_double(threshold), generate_random_double(threshold) };
	double v_result[dimensions];

	spacer();
	std::cout << "Calculate the sum of two vectors" << std::endl;
	spacer();

	std::cout << "Vector 1:" << std::endl;
	std::cout << "(" << v1[0] << ", " << v1[1] << ", " << v1[2] << ")" << std::endl;
	spacer();

	std::cout << "Vector 2:" << std::endl;
	std::cout << "(" << v2[0] << ", " << v2[1] << ", " << v2[2] << ")" << std::endl;
	spacer();

	std::cout << "Calculating..." << std::endl;
	spacer();

	for (int i = 0; i < dimensions; i++)
	{
		v_result[i] = v1[i] + v2[i];
	}

	std::cout << "Resulting Vector: " << std::endl;
	std::cout << "(" << v_result[0] << ", " << v_result[1] << ", " << v_result[2] << ")" << std::endl;
	spacer();
}

void exercise2()
{
	int const SIZE_OF_ARRAY = 10;
	int THRESHOLD = 20;
	int numbers[SIZE_OF_ARRAY];

	//fill array with random numbers
	for (int i = 0; i < SIZE_OF_ARRAY; i++)
	{
		numbers[i] = generate_random_int(THRESHOLD);
	}

	spacer();

	//print array before algorithm
	for (int i = 0; i < SIZE_OF_ARRAY; i++)
	{
		std::cout << numbers[i] << " ";
	}
	std::cout << std::endl;

	//algorithm
	for (int i = 0; i < SIZE_OF_ARRAY; i++)
	{
		if ((i % 2) == 0) {
			numbers[i] *= -1;
			continue;
		}

		if ((numbers[i] % 2) == 0) numbers[i] /= 2;
		else numbers[i] *= 10;		
	}

	spacer();

	//print array after algorithm
	for (int i = 0; i < SIZE_OF_ARRAY; i++)
	{
		std::cout << numbers[i] << " ";
	}
	std::cout << std::endl;

	spacer();
}