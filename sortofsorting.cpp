#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
bool strComp(const string string1, const string string2){
  if (string1[0] == string2[0]){
    return string1[1] < string2[1];
  }
  else
    return string1[0] < string2[0];
}
int main(){
    int a;
    cin >> a;
  while(true){
    vector<string> names(a);
    for (int i = 0; i < a; i++){
      cin >> names[i];
    }
    stable_sort(names.begin(), names.end(), strComp);
    for(auto n: names){
      cout << n << endl;
    }
    cin >> a;
    if (a == 0)break;
    else cout << endl;
  }
}
