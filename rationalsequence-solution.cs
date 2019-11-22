using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rationalsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());

            for(int i = 0; i < P; i++)
            {
                int[] kpq = Console.ReadLine().Split(new char[] { ' ', '/'}).Select(x => int.Parse(x)).ToArray();
                int k = kpq[0];
                int p = kpq[1];
                int q = kpq[2];

                int l = p / q;
                
                if(q == 1)
                {
                    Console.WriteLine($"{k} {q}/{p + 1}");
                }
                else if(p < q)
                {
                    Console.WriteLine($"{k} {q}/{q - p}");
                }
                else
                {
                    Console.WriteLine($"{k} {q}/{(2 * l + 1) * q - p}");
                }
            }

            Console.Read();
        }
    }
}
