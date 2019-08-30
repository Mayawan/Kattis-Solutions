using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batterup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            List<int> values = Console.ReadLine().Split().Select(x => int.Parse(x)).Where(x => x != -1).ToList();
            Console.WriteLine((double)values.Sum() / values.Count);
        }
    }
}
