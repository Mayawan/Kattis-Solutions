using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _700iq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hwn = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int[] bricks = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int j = 0;
            for (int i = 0; i < hwn[0]; i++)
            {
                int width = 0;
                for(bool test; j < bricks.Length && width < hwn[1]; j++)
                {
                    width += bricks[j];
                }
                if (width != hwn[1]) goto no;
            }
            Console.WriteLine("YES");
            return;
            no:
            Console.WriteLine("NO");
            return;
        }
    }
}
