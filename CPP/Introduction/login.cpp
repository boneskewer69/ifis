#include <iostream>
#include <string>

using namespace std;

int main(){

	string storedLogin;
	string storedPassword;

	storedLogin = "FAnuth";
	storedPassword = "DenksteN8;)";

	string userInputLogin;
	string userInputPassword;

	cout << "Login: ";
	cin >> userInputLogin;
	cout << "Password: ";
	cin >> userInputPassword;

	if (storedLogin == userInputLogin && storedPassword == userInputPassword) {
		cout << "Access granted...\nWelcome!" << endl;
	}
	else {
		cout << "Access denied...\nLeave me alone u creep!" << endl;
	}

	system("pause");
	return 0;
}
