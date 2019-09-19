using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Factorial_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for(int i = 0; i < cases; i++)
            {
                Console.WriteLine(fact(int.Parse(Console.ReadLine()), 1).ToString().Last());
            }
        }

        static int fact(int value, int current)
        {
            if (value == 1) return current;

            return fact(value - 1, current * value);
        }
    }
}
