using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dice_faces = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Dictionary<int, int> possibilities = new Dictionary<int, int>();

            for(int i = 1; i <= dice_faces[0]; i++)
            {
                for(int j = 1; j <= dice_faces[1]; j++)
                {
                    if (!possibilities.ContainsKey(i + j)) possibilities.Add(i + j, 0);
                    possibilities[i + j]++;
                }
            }

            int max = possibilities.Max(x => x.Value);

            possibilities.Where(x => x.Value == max).ToList().ForEach(x => Console.WriteLine(x.Key));

            Console.Read();
        }
    }
}
