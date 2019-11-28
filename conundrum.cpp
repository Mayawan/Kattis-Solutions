#include <iostream>

using namespace std;

int main() {
  string per = "PER";
  string s;
  cin >> s;

  int changes = 0;
  for(int i = 0; s[i]; i++)
  {
    if(s[i] != per[i % 3])
      changes++;
  }

  cout << changes << endl;
}
