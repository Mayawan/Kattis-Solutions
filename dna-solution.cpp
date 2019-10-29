#include <iostream>

using namespace std;

int main() {
  int n;
  cin >> n;

  string s;
  cin >> s;

  bool seq_a = true;
  int moves = 0;

  for(int i = n - 1; i >= 0; i--)
  {
    
    if(seq_a && s[i] == 'A') continue;
    if(!seq_a && s[i] == 'B') continue;

    if(i == 0)
    {
      moves++;
      break;
    }
    
    moves++;

    if(seq_a)
    {
      if(s[i - 1] == 'B')
      {
        seq_a = false;
      }
    }
    else
    {
      if(s[i - 1] == 'A')
      {
        seq_a = true;
      }
    }
  }

  cout << moves << endl;
}
