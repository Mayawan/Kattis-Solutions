using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftBeehind
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                int sweet = int.Parse(input[0]);
                int sour = int.Parse(input[1]);
                if (sweet == 0 && sour == 0)
                {
                    return;
                }
                if (sweet + sour == 13)
                {
                    Console.WriteLine("Never speak again.");
                }
                else if (sweet > sour)
                {
                    Console.WriteLine("To the convention.");
                }
                else if (sour > sweet)
                {
                    Console.WriteLine("Left beehind.");
                }
                else
                {
                    Console.WriteLine("Undecided.");
                }
            }
        }
    }
}
