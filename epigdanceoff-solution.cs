using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epigdanceoff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            string[] dance = Enumerable.Range(0, nm[0]).Select(x => Console.ReadLine()).ToArray();

            int rating = 1;
            for(int i = 0; i < nm[1]; i++)
            {
                if (dance.Select(x => x[i]).All(x => x == '_')) rating++;
            }

            Console.WriteLine(rating);
        }
    }
}
