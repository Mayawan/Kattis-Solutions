#include <iostream>

using namespace std;

int main() {
  string s;
  cin >> s;

  double len = s.length();
  int space = 0;
  int upper = 0;
  int lower = 0;
  int symbol = 0;

  for(int i = 0; s[i]; i++)
  {
    if(s[i] > 64 && s[i] < 91)
      upper++;
    else if(s[i] > 96 && s[i] < 123)
      lower++;
    else if(s[i] == 95)
      space++;
    else
      symbol++;
  }

  cout << space / len << endl
  << lower / len << endl
  << upper / len << endl
  << symbol / len << endl;
}
