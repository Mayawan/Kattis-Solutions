using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hay_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            //dict
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for(int i = 0; i < input[0]; i++)
            {
                string[] keyval = Console.ReadLine().Split();
                dictionary.Add(keyval[0], int.Parse(keyval[1]));
            }

            //job descriptions
            for(int i = 0; i < input[1]; i++)
            {
                List<string> job = new List<string>();

                while (true)
                {
                    string desc = Console.ReadLine();
                    if (desc.Equals(".")) break;
                    job.AddRange(desc.Split());
                }

                int sum = 0;

                for(int j = 0; j < job.Count; j++)
                {
                    if (dictionary.ContainsKey(job[j])) sum += dictionary[job[j]];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
