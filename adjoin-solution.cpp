#include <algorithm>
#include <iostream>
#include <vector>
#include <queue>
#include <map>

using namespace std;

vector<int> visited;

pair<int,int> get_hops(vector<vector<int> >& adj, int root, int c)
{
    queue<int> q;
    q.push(root);

    map<int,int> dist;
    dist[root] = 1;

    int max = 1;
    int id = root;

    while (!q.empty())
    {
        int curr = q.front();
        q.pop();

        visited[curr] = true;

        for (int i : adj[curr])
        {
            if (!dist[i])
            {
                dist[i] = dist[curr] + 1;
                q.push(i);

                if (dist[i] > max)
                {
                    max = dist[i];
                    id = i;
                }
            }
        }
    }

    return make_pair(id, max - 1);
}

vector<int> getRadius(vector<int>& netMaxHops) {
    vector<int> radius;

    int i;

    for (i = 0; i < netMaxHops.size() && i < 3; i++) {
        (netMaxHops[i] % 2 == 0) ? radius.push_back(netMaxHops[i] / 2) : radius.push_back((netMaxHops[i] / 2) + 1);
    }
    while (i < 3)
    {
        radius.push_back(0);
        i++;
    }
    return radius;
}

int main() {
    int c, l;
    cin >> c >> l;

    visited = vector<int>(c);
    vector<vector<int> > adj(c);

    for (int i = 0; i < l; i++)
    {
        int a, b;
        cin >> a >> b;

        adj[a].push_back(b);
        adj[b].push_back(a);
    }

    vector<int> net_hop;
    for (int i = 0; i < c; i++)
    {
        if (!visited[i])
        {
            pair<int, int> edge1 = get_hops(adj, i, c);
            pair<int, int> edge2 = get_hops(adj, edge1.first, c);
            net_hop.push_back(edge2.second);
        }
    }

    sort(net_hop.begin(), net_hop.end(), greater <int>());

    vector<int> radius = getRadius(net_hop);
    cout << max(net_hop[0], max(radius[0] + radius[1] + 1, radius[1] + radius[2] + 2));
}
