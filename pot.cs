using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> p = Enumerable.Range(0, n).Select(i => Console.ReadLine()).ToList();
            int x = 0;
            p.ForEach(i => x += (int)Math.Pow(double.Parse(i.Substring(0, i.Length - 1)), double.Parse(i.Last().ToString())));
            Console.WriteLine(x);
        }
    }
}
