#include <iostream>
#include <map>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
  int n, x;
  cin >> n >> x;

  vector<int> items(n);

  for(int i = 0; i < n; i++)
  {
    cin >> items[i];
  }

  sort(items.begin(), items.end());

  int marked = 1;
  for(int i = 0; i < n - 1; i++)
  {
    if(items[i] + items[i + 1] <= x)
      marked++;
    else
    {
      break;
    }
  }

  cout << marked;
}
