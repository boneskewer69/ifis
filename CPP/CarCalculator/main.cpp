/*
	Fritz Anuth
*/

#include <iostream>
#include <string>

using namespace std;

int main()
{

	string rain;
	int speed;

	while (!((rain == "no") || (rain == "yes")))
	{
		cout << "Is it raining? (please enter yes or no)\n> ";
		cin >> rain;

		if (rain == "no")
		{
			cout << "The road is safe, have a good trip!" << endl;
		}
	}


	if (rain == "yes")
	{
		cout << "What is your current speed? (please enter a valid number)\n> ";
		cin >> speed;

		if (speed <= 80)
		{
			cout << "Your speed is ok." << endl;
		}
		else
		{
			cout << "The road is wet, you are too fast!" << endl;
		}
	}

	system("pause");
	return 0;
}
