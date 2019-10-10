using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedlimit
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == -1) break;

                int count = 0;
                int hours = 0;
                for(int i = 0; i < n; i++)
                {
                    int[] st = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                    count += st[0] * (st[1] - hours);
                    hours = st[1];
                    
                }

                Console.WriteLine(count + " miles");
            }
        }
    }
}
