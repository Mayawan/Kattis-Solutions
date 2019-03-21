using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            for(int i = 1; i <= input[2]; i++)
            {
                string output = "";
                if (i % input[0] == 0) output += "Fizz";
                if (i % input[1] == 0) output += "Buzz";
                if (i % input[0] != 0 && i % input[1] != 0) output += i;
                Console.WriteLine(output);
            }
        }
    }
}
