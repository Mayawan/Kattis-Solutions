using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Program
    {
        public static int[][] graph;

        static void Main(string[] args)
        {
            //reading input
            int testCases = int.Parse(Console.ReadLine());

            for(int i = 0; i < testCases; i++)
            {
                int[] dimensions = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                graph = new int[dimensions[1]][];

                for (int j = 0; j < dimensions[1]; j++)
                {
                    graph[j] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                }

                int leastCost = int.MaxValue;

                List<Tuple> queue = new List<Tuple>();
                queue.Add(new Tuple(0, 0));

                while(queue.Count > 0)
                {
                    Tuple t = queue[0];
                    queue.RemoveAt(0);

                    int contest = distCost(t);

                    if(contest < leastCost)
                    {
                        leastCost = contest;

                        queue.Add(new Tuple(t.x + 1, t.y));
                        queue.Add(new Tuple(t.x, t.y + 1));
                    }
                }

                Console.WriteLine(leastCost + " blocks");
            }
        }

        public static int distCost(Tuple tuple)
        {
            int cost = 0;

            for(int i = 0; i < graph.Length; i++)
            {
                for(int j = 0; j < graph[i].Length; j++)
                {
                    cost += graph[i][j] * (Math.Abs(tuple.x - j) + Math.Abs(tuple.y - i));
                }
            }

            return cost;
        }
    }

    class Tuple
    {
        public int x;
        public int y;

        public Tuple(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
