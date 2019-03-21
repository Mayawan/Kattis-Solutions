using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] a = input.Select(x => int.Parse(x)).ToArray();
            int[] correct = new int[]{ 1, 1, 2, 2, 2, 8 };
            for (int i =0; i < a.Length; i++)
            {
                Console.Write((correct[i] - a[i]) + " ");
            }
            Console.Read();
        }
    }
}
