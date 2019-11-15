using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terraces
{
    class Program
    {
        static int[][] matrix;
        static bool[][] visited;

        static void Main(string[] args)
        {
            int[] xy = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int x = xy[0];
            int y = xy[1];

            matrix = new int[y][];
            visited = new bool[y][];
            for(int i = 0; i < y; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
                visited[i] = new bool[x];
            }

            int totalPooled = 0;

            for(int i = 0; i < y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    List<int> outer = new List<int>();
                    int pooled = poolCount(i, j, matrix[i][j], ref outer);
                    if (outer.Count(e => e < matrix[i][j]) == 0) totalPooled += pooled;
                }
            }

            Console.WriteLine(totalPooled);
            Console.Read();
        }

        static int poolCount(int i, int j, int val, ref List<int> outer)
        {
            if (visited[i][j]) return 0;

            visited[i][j] = true;
            int sum = 1;

            List<Tuple<int, int>> adj = new List<Tuple<int, int>>();

            if (i != 0) adj.Add(new Tuple<int, int>(i - 1, j));
            if (j != 0) adj.Add(new Tuple<int, int>(i, j - 1));
            if (i + 1 != matrix.Length) adj.Add(new Tuple<int, int>(i + 1, j));
            if (j + 1 != matrix[0].Length) adj.Add(new Tuple<int, int>(i, j + 1));

            foreach(Tuple<int,int> t in adj)
            {
                int adjVal = matrix[t.Item1][t.Item2];

                if (val == adjVal) sum += poolCount(t.Item1, t.Item2, val, ref outer);
                else outer.Add(adjVal);
            }

            return sum;
        }
    }
}
