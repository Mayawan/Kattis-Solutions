using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simon
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();

                if (s.StartsWith("simon says "))
                    Console.WriteLine(s.Substring(11));
                else
                    Console.WriteLine();
            }
        }
    }
}
