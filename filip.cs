using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] epic = Console.ReadLine().Split().Select(x => int.Parse(new string(x.Reverse().ToArray()))).ToArray();

            if (epic[0] > epic[1]) Console.WriteLine(epic[0]);
            else Console.WriteLine(epic[1]);
        }
    }
}
