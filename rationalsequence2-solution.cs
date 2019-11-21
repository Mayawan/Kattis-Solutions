using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rationalsequence2
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());

            for(int i = 0; i < P; i++)
            {
                int[] kpq = Console.ReadLine().Split(new char[] { ' ', '/' }).Select(x => int.Parse(x)).ToArray();
                int k = kpq[0];
                int p = kpq[1];
                int q = kpq[2];

                List<bool> moves = new List<bool>();

                while(p != 1 || q != 1)
                {
                    int diff = Math.Abs(p - q);

                    if(p > q)
                    {
                        moves.Add(true);
                        p = diff;
                    }
                    else
                    {
                        moves.Add(false);
                        q = diff;
                    }
                }

                uint n = 1;

                for(int j = moves.Count - 1; j >= 0; j--)
                {
                    n <<= 1;
                    if (moves[j]) n++;
                }

                Console.WriteLine($"{k} {n}");
            }

            Console.Read();
        }
    }
}
