using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_for_Carrots
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < input[0]; i++) Console.ReadLine();

            Console.WriteLine(input[1]);
        }
    }
}
