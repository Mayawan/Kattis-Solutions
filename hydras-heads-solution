using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydrasHead
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int counter = 0;
                string input = Console.ReadLine();

                if (input == "0 0")
                {
                    break;
                }
                else
                {
                    input = input.Trim(' ');
                    input = input.TrimEnd('\r', '\n');
                    string[] values = input.Split(' ');
                    decimal heads = decimal.Parse(values[0]);
                    decimal tails = decimal.Parse(values[1]);
                    if(heads % 2 == 1 && tails ==0)
                    {
                        Console.WriteLine("-1");
                        Console.ReadLine();
                        break;
                    }
                    while (heads >= 2)
                    {
                        heads = heads - 2;
                        counter++;
                    }
                    while ((heads + tails / 2) % 2 != 0)
                    {
                        tails++;
                        counter++;
                    }
                    while (tails != 0)
                    {
                        tails = tails - 2;
                        heads++;
                        counter++;
                    }
                    while (heads != 0)
                    {
                        heads = heads - 2;
                        counter++;
                    }
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
