using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Two_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int.Parse(Console.ReadLine()) % 2 == 0) ? "Bob" : "Alice");
        }
    }
}
