#include <iostream>
#include <vector>
#include <queue>

using namespace std;

int n, h, l;
vector<int> dist;

void get_dist(vector<vector<bool> >& adj, int key)
{
  queue<int> q;
  q.push(key);

  while(!q.empty())
  {
    int curr = q.front();
    q.pop();

    for(int i = 0; i < n; i++)
    {
      if(adj[curr][i] && dist[i] > dist[curr] + 1)
      {
        dist[i] = dist[curr] + 1;
        q.push(i);
      }
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

  get_dist(links,n);

  int max = 0;
  for(int i = 0; i < n; i++){
    if(dist[i] > dist[max])
      max = i;
  }

  cout << max << endl;
}
