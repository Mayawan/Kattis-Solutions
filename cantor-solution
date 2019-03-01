using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal input;
                try
                {
                    input = decimal.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine("MEMBER");
                    }
                    else
                    {
                        List<decimal> decimals = new List<decimal>();
                        decimals.Add(input);

                        while (true)
                        {
                            input = input * 3;
                            int digit = (int)Math.Floor(input);
                            input -= digit;
                            if (digit == 1)
                            {
                                Console.WriteLine("NON-MEMBER");
                                break;
                            }
                            else if (decimals.Contains(input - digit))
                            {
                                Console.WriteLine("MEMBER");
                                break;
                            }
                            decimals.Add(input);
                        }
                    }
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
