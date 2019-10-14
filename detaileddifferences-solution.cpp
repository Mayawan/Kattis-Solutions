#include <iostream>

using namespace std;

int main() {
  int n;
  cin >> n;

  string first;
  string second;
  getline(cin,first); //bring stream to next line

  for(int i = 0; i < n; ++i) {

    getline(cin,first);
    getline(cin,second);

    cout << first << endl;
    cout << second << endl;

    for(int j = 0; first[j]; ++j){
      if(first[j] == second[j])cout << ".";
      else cout << "*";
    }

    cout << endl << endl;
  }
}
