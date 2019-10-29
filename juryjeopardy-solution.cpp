#include <iostream>
#include <map>

using namespace std;

void move(int &dir, pair<int,int> &curr, char mov)
{
  if(mov == 'B') dir = (dir + 2) % 4;


  if(mov == 'R') dir = (dir + 1) % 4;

  if(mov == 'L')
  {
    dir--;
    if(dir == -1) dir = 3;
  }

  switch (dir)
  {
    case 0:
      curr.first--;
      break;
    case 1:
      curr.second++;
      break;
    case 2:
      curr.first++;
      break;
    case 3:
      curr.second--;
      break;
  }
}

int main() {
  int n;
  cin >> n;
  /*
  north 0
  east 1
  south 2
  west 3
  */
  cout << n << endl;

  for(int i = 0; i < n; i++)
  {
    string s;
    cin >> s;

    int dir = 1;
    map<pair<int,int> , bool> is_path;
    pair<int,int> curr = make_pair(0,0);
    is_path[curr] = true;

    int y_min = 0;
    int y_max = 0;
    int x_max = 0;

    for(char c : s)
    {
      move(dir,curr, c);

      if(curr.second > x_max) x_max = curr.second;
      if(curr.first < y_min) y_min = curr.first;
      if(curr.first > y_max) y_max = curr.first;

      is_path[curr] = true;
    }

    cout << y_max - y_min + 3 << " " << x_max + 2 << endl;

    for(int i = y_min - 1; i <=  y_max + 1; i++)
    {
      for(int j = 0; j <= x_max + 1; j++)
      {
        if(is_path[make_pair(i,j)])
          cout << '.';
        else
          cout << '#';
      }

      cout << endl;
    }
  }
}
