#include <iostream>
#include <vector>
using namespace std;

int main() {
  while(true){
    int numCities, numBoxes;
    cin >> numCities >> numBoxes;
    if (numCities == -1)break;
    vector<int> cities(numCities);
    int hi = 0;
    for (int i = 0; i < numCities; i++){
      cin >> cities[i];
      hi = max(cities[i], hi);
    }
    int lo = 0;
    int mi;
    while (lo < hi){
      mi = (lo + hi) / 2;
      int boxes = 0;
      for (int i = 0; i < numCities; i++){
        boxes += (cities[i] + mi - 1) / mi;
      }
      if (boxes > numBoxes){
        lo = mi + 1;
      }
      else{
        hi = mi;
      }
    }

    cout << lo << endl;
  }
}
