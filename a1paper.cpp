#include <iostream>
#include <algorithm>
#include <vector>
#include <math.h>
using namespace std;

int main() {
  int numPaper;
  cin >> numPaper;
  numPaper--;
  vector<int> papers(numPaper);
  for (int i = 0; i < numPaper; i++){
    int a;
    cin >> a;
    papers[i] = a;
  }
  long double l = pow(2, -0.75);
  int amount = 1;
  long double cost = 0;
  for (int i = 0; i < numPaper; i++){
    cost += amount * l;
    amount *= 2;
    amount -= papers[i];
    if (amount <= 0){
      break;
    }
    l /= pow(2, 0.5);
  }
  if (amount > 0){
    cout << "impossible";
  }
  else{
    cout << fixed;
    cout.precision(12);
    cout << cost;
  }
}
