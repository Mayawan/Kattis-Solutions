#include <iostream>
#include <vector>
#include <algorithm>
#include <sstream>

using namespace std;

int n, h, l;
vector<int> dist;

void hop(vector<vector<bool> >& adj, int current, int counter)
{
  for(int i = 0; i < n; i++)
  {
    if(adj[current][i] 
    //&& find(prev.begin(),prev.end(),i) == prev.end() 
    && dist[i] > counter)
    {
      dist[i] = counter;

      hop(adj,i, counter + 1);
    }
  }
}

int main() 
{
  cin >> n >> h >> l;
  dist = vector<int>(n);
  for(int i = 0; i < n; i++)
  {
    dist[i] = 10001;
  }

  vector<vector<bool> > links(n + 1);

  for(int i = 0; i <= n; i++)
  {
    links[i] = vector<bool>(n + 1);
  }

  for(int i = 0; i < h; i++)
  {
    int d;
    cin >> d;

    links[n][d] = true;
    links[d][n] = true;
  }

  for(int i = 0; i < l; i++)
  {
    int a1,a2;
    cin >> a1 >> a2;

    links[a1][a2] = true;
    links[a2][a1] = true;
  }

  hop(links, n, 0);

  int max = *max_element(dist.begin(),dist.end());
  
  cout << distance(dist.begin(),find(dist.begin(),dist.end(),max));
}
