using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace timeloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, int.Parse(Console.ReadLine())).ToList().ForEach(x => Console.WriteLine(x + " Abracadabra"));
        }
    }
}
