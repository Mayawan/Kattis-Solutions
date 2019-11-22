using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rationalsequence3
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());

            for(int i = 0; i < P; i++)
            {
                uint[] kpq = Console.ReadLine().Split().Select(x => uint.Parse(x)).ToArray();
                uint k = kpq[0];
                uint n = kpq[1];

                int p = 1;
                int q = 1;

                string bin = Convert.ToString(n, toBase: 2);
                
                for(int j = 1; j < bin.Length; j++)
                {
                    if(bin[j] == '0')
                    {
                        q += p;
                    }
                    else
                    {
                        p += q;
                    }
                }

                Console.WriteLine($"{k} {p}/{q}");
            }
        }
    }
}
