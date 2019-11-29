#include <iostream>
#include <unordered_map>

using namespace std;

unordered_map<char,int> dominant {{'A',11},{'K',4},{'Q',3},{'J',20},{'T',10},{'9',14}};
unordered_map<char,int> notdominant {{'A',11},{'K',4},{'Q',3},{'J',2},{'T',10}};

int main() {
  int n;
  cin >> n;
  n *= 4;

  string s;
  cin >> s;
  char b = s[0];
  
  int sum = 0;
  for(int i = 0; i < n; i++)
  {
    cin >> s;
    if(s[1] == b)
      sum += dominant[s[0]];
    else
      sum += notdominant[s[0]];
  }

  cout << sum << endl;
}
