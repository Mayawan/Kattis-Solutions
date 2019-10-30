#include <iostream>
#include <vector>

using namespace std;

int main() {
  int c = 1;
  while(true){
    int l, w;
    cin >> w >> l;
    if (l == 0){
      break;
    }
    vector<string> house;
    int x, y;
    int dir;
    // 0 up 1 right 2 down 3 left
    for (int i = 0; i < l; i++){
      string s;
      cin >> s;
      house.push_back(s);
    }

    for (int i = 0; i < l; i++){
      for (int j = 0; j < w; j++){
        if (house[i][j] == '*'){
          x = j;
          y = i;
          break;
        }
      }
    }
    
    if (y == 0){
      dir = 2;
    }
    if (y == (l-1)){
      dir = 0;
    }
    if (x == 0) {
      dir = 1;
    }
    if (x == (w-1)){
      dir = 3;
    }
    do{
      if (dir == 0){
        y--;
      }
      if (dir == 1){
        x++;
      }
      if (dir == 2){
        y++;
      }
      if (dir == 3){
        x--;
      }

      if (house[y][x] == '\\'){
        if (dir == 0){
          dir = 3;
        }
        else if (dir == 1){
          dir = 2;
        }
        else if (dir == 2){
          dir = 1;
        }
        else if (dir == 3){
          dir = 0;
        }
      }

      if (house[y][x] == '/'){
        if (dir == 0){
          dir = 1;
        }
        else if (dir == 1){
          dir = 0;
        }
        else if (dir == 2){
          dir = 3;
        }
        else if (dir == 3){
          dir = 2;
        }
      }

    }while(house[y][x] != 'x');

    house[y][x] = '&';

    cout << "HOUSE " << c << endl;
    for (string s: house){
      cout << s << endl;
    }
    c++;
  }

  return 0;
}
