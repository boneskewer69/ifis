#include <iostream>
#include <string>
#include <ctime>

using namespace std;

#define xSIZE 3
#define ySIZE 3
#define rSIZE 3

void printMatrix(int matrix[xSIZE][ySIZE]);

int main()
{
	srand((unsigned)time(NULL));

	int matrixA[xSIZE][ySIZE];
	int matrixB[xSIZE][ySIZE];
	int resultingMatrix[xSIZE][ySIZE];

	//Fill Matrix
	for (int x = 0; x < xSIZE; x++)
	{
		for (int y = 0; y < ySIZE; y++)
		{
			matrixA[x][y] = (rand() % 10);
			matrixB[x][y] = (rand() % 10);
		}
	}

	//Calculate Resulting Matrix
	for (int x = 0; x < xSIZE; x++)
	{
		for (int y = 0; y < ySIZE; y++)
		{
			resultingMatrix[x][y] = 0;
			for (int i = 0; i < rSIZE; i++)
				resultingMatrix[x][y] += matrixA[x][i] * matrixB[i][y];
		}
	}

	//Print
	cout << "Matrix A" << endl;
	printMatrix(matrixA);
	cout << endl << "Matrix B" << endl;
	printMatrix(matrixB);
	cout << endl << "Resulting Matrix" << endl;
	printMatrix(resultingMatrix);

	return 0;
}

void printMatrix(int matrix[xSIZE][ySIZE])
{
	for (int x = 0; x < xSIZE; x++)
	{
		for (int y = 0; y < ySIZE; y++)
			cout << matrix[x][y] << "\t";
		cout << endl;
	}
}