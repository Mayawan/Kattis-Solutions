using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                try
                {
                    BigInteger[] input = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
                    if (input[0] > input[1]) Console.WriteLine(input[0] - input[1]);
                    else Console.WriteLine(input[1] - input[0]);
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
