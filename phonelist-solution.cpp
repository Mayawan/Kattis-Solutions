#include <iostream>
#include <set>
#include <vector>
#include <algorithm>
using namespace std;
int main() {
  int numCases;
  cin >> numCases;
  for(int i = 0; i < numCases; i++){
    set<string> usedNums;
    int numNumbers;
    cin >> numNumbers;
    vector<string> phoneNums;
    for(int j = 0; j < numNumbers; j++){
      string a;
      cin >> a;
      phoneNums.push_back(a);
    }
    sort(phoneNums.begin(), phoneNums.end(), greater<string>());
    bool a = true;
    for (int j = 0; j < numNumbers; j++){
      if (usedNums.find(phoneNums[j]) != usedNums.end()){
        a = false;
        break;
      }
      else{
        for (int k = 1; k < phoneNums[j].length() + 1; k++){
          usedNums.insert(phoneNums[j].substr(0,k));
        }
      }
    }
    (a) ? cout << "YES" : cout << "NO";
    cout << endl;
  }
}
