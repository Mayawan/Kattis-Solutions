#include <iostream>

using namespace std;

int main() {
  int n,h,v;
  cin >> n >> h >> v;

  if(n - h > h) h = n - h;
  if(n - v > v) v = n - v;

  cout << h * v * 4 << endl;
}
