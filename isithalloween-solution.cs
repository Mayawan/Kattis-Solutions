using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isithalloween
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "OCT 31" || input == "DEC 25")
                Console.WriteLine("yup");
            else
                Console.WriteLine("nope");
        }
    }
}
