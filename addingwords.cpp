#include <iostream>
#include <algorithm>
#include <map>
using namespace std;
int main() {
  map<string,int> d;
  while(true){
    string command;
    cin >> command;
    if (command == ""){
      break;
    }
    else if (command == "clear"){
      d.clear();
    }
    else if (command == "def"){
      string word;
      int num;
      cin >> word >> num;
      d[word] = num;
    }
    else{
      string out;
      bool unknown = false;
      int sum = 0;
      int nextVal = 1;
      
      while(true){
        string val, op;
        cin >> val >> op;
        out += val + " " + op + " ";
        int translation;
        if (d.find(val) == d.end()){
          unknown = true;
        }
        else{
          sum += d[val] * nextVal;
        }

        if (op == "+"){
            nextVal = 1;
        }
        else if(op == "-"){
            nextVal = -1;
        }
        else if(op == "="){
            break;
        }
      }
      if (unknown){
        out += "unknown";
      }
      else{
        string ans = "unknown";
        for(auto it = d.begin(); it != d.end(); it++){
          if (it -> second == sum){
            ans = it ->first;
          }
        }
        out += ans;
      }
      cout << out << endl;
    }
  }
}
