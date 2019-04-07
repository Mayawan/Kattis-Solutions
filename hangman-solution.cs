using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();
            String guesses = Console.ReadLine();
            int counter = 0;

            foreach (char c in guesses)
            {
                if (word == "")
                {
                    Console.WriteLine("WIN");
                    break;
                }

                if(counter > 9)
                {
                    Console.WriteLine("LOSE");
                    break;
                }

                if (word.Contains(c.ToString()))
                {
                    word = word.Replace(c.ToString(), "");
                }
                else counter++;
            }
        }
    }
} 
