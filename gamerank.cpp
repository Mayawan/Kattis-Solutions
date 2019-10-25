#include <iostream>
using namespace std;
int rank_to_star(int rank){
  if (rank > 20)
    return 2;
  if(rank > 15)
    return 3;
  if(rank > 10)
    return 4;
  if(rank > 0)
    return 5;
  return 0;
}


int main(){
  string match_history;
  getline(cin, match_history);
  int stars, rank, streak, rank_stars;

  rank = 25;
  stars = 0;
  streak = 0;
  rank_stars = 2;

  for(char i: match_history){
    if (i == 'W'){
      stars++;
      streak++;
      if (streak >= 3 && rank > 5) stars++;
      if (stars > rank_stars){
        stars = stars - rank_stars;
        rank--;
        if (rank == 0) break;
        rank_stars = rank_to_star(rank);
      }
    }
    else{
      if (rank <= 20) stars--;
      streak = 0;
      if (stars < 0){
        if (rank == 20) stars = 0;
        else{
          rank++;
          rank_stars = rank_to_star(rank);
          stars = rank_stars - 1;
        }
      }
    }
  }
  (rank == 0) ? cout << "Legend" : cout << rank;
}
