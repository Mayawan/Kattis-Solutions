#include <iostream>
#include <vector>
using namespace std;

int main() {
  while(true){
    int l;
    cin >> l;
    if (l==0)break;
    vector<int> index(l);
    for (int i = 0; i < l; i++){
      int ind;
      cin >> ind;
      index[i] = ind-1;
    }
    string s;
    getline(cin, s);
    getline(cin, s);
    cout << "'";
    while(true){
      if (s.length() == 0) break;
      string new_s;
      for (int i = 0; i < l; i++){
        new_s += " ";
      }
      for (int i = 0; i < l; i++){
        if (index[i] < s.length())
          new_s[i] = s[index[i]];
      }
      cout << new_s;

      if (s.length() < l) s = "";
      else s = s.substr(l);
    }
    cout << "'" << endl;
  }
}
