using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cold
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int sum = 0;
            foreach(int i in input)
            {
                if (i < 0) sum++;
            }
            Console.WriteLine(sum);
        }
    }
}
