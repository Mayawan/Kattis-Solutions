#include <iostream>
using namespace std;
int fact(int n){ //calculates the factorial
  if(n == 0){
    return 1;
  }
  else{
    return n * fact(n-1);
  }
}

int main() { 
  int numCase; 
  cin >> numCase; //gets number of cases
  for(int i = 0; i < numCase; i++){ //loops through cases
    int temp; //specific case
    cin >> temp;
    cout << fact(temp) % 10 << endl; //print output
  }
}
