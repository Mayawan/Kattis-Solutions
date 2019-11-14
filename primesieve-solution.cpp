#include <iostream>
#include <bits/stdc++.h> 
#include <cmath>
#include <algorithm>
using namespace std;

#define M 100000000

int main() {
  int n,q;
  cin >> n >> q;

  bitset<M> is_not_prime;
  is_not_prime[1] = true;

  for(int i = 2; i <= n/i; i++)
  {
    if(!is_not_prime[i])
    {
      for(int j = i; j <= n/i; j++)
      {
        is_not_prime[i * j] = 1;
      }
    }
  }

  int primes = 0;
  for(int i = 2; i <= n; i++)
  {
    if(!is_not_prime[i]) primes++;
  }

  cout << primes << endl;

  for(int i = 0; i < q; i++)
  {
    int query;
    cin >> query;
    if(is_not_prime[query]) cout << 0;
    else cout << 1;
    cout << endl;
  }
}
