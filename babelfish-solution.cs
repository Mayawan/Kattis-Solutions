using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "") break;

                string[] split_input = input.Split();

                string key = split_input[1];
                string value = split_input[0];

                words.Add(key, value);
            }

            try
            {
                while (true)
                {
                    input = Console.ReadLine();
                    string key = "eh";

                    if (words.ContainsKey(input)) key = words[input];

                    Console.WriteLine(key);
                }
            }
            catch
            {

            }
        }
    }
}
