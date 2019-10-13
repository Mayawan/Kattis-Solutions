using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] split_input = input.Split();
            char[] cards = split_input.Select(x => x[0]).ToArray();

            var grouped_cards = cards.GroupBy(x => x);

            int max = 0;
            foreach(var group in grouped_cards)
            {
                if (group.Count() > max) max = group.Count();
            }

            Console.WriteLine(max);
        }
    }
}
