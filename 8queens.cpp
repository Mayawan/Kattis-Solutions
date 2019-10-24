#include <iostream>
#include <vector>
using namespace std;
void updateBoard(vector<vector<bool> >& board, int x, int y){
  for (int i = 0; i < 8; i++){
    board[x][i] = true;
    board[i][y] = true;
    if (x - i >= 0){
      if (y - i >= 0){
        board[x-i][y-i] = true;
      }
      if (y + i < 8){
        board[x-i][y+i] = true;
      }
    }
    if (x + i < 8){
      if (y - i >= 0){
        board[x+i][y-i] = true;
      }
      if (y + i < 8){
        board[x+i][y+i] = true;
      }
    }
  }
}
int main() {
  int numQueens = 0;
  vector<vector<bool> > board(8, vector<bool> (8));
  bool valid = true;
  for(int i = 0; i < 8; i++){
    string s;
    cin >> s;
    for (int j = 0; j < 8; j++){
      if (s[j] == '*'){
        numQueens++;
        if (board[i][j]){
          valid = false;
          break;
        }
        updateBoard(board, i, j);
      }
    }
  }
  if (numQueens != 8) valid = false;
  (valid) ? cout << "valid" : cout << "invalid";
}
