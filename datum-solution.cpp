#include <iostream>

using namespace std;

int months_to_days(int n)
{
	switch (n)
	{
	case 1:
		return 0;
	case 2:
		return 31;
	case 3:
		return 59;
	case 4:
		return 90;
	case 5:
		return 120;
	case 6:
		return 151;
	case 7:
		return 181;
	case 8:
		return 212;
	case 9:
		return 243;
	case 10:
		return 273;
	case 11:
		return 304;
	case 12:
	default:
		return 334;
	}
}

int main()
{
	int d, m;
	cin >> d >> m;

	int day = (d + months_to_days(m)) % 7;

	if (day == 1) cout << "Thursday";
	if (day == 2) cout << "Friday";
	if (day == 3) cout << "Saturday";
	if (day == 4) cout << "Sunday";
	if (day == 5) cout << "Monday";
	if (day == 6) cout << "Tuesday";
	if (day == 0) cout << "Wednesday";
}
