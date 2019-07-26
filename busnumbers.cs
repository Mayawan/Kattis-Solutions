using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busnumbers
{
    class Program
    {
        static List<int> buses;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            buses = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            buses.Sort();

            List<string> e = new List<string>();
            while(buses.Count > 0)
            {
                e.Add(next());
            }

            Console.WriteLine(String.Join(" ", e));
            Console.ReadLine();
        }

        static string next()
        {
            int first = buses[0];
            buses.RemoveAt(0);

            if (buses.Count < 2) goto Simple;

            if(first + 1 == buses[0] &&
                buses[0] + 1 == buses[1])
            {
                int prev = first;

                int next = buses[0];

                while (true)
                {
                    try
                    {
                        if (prev + 1 == next)
                        {
                            prev = next;
                            buses.RemoveAt(0);
                            next = buses[0];
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
                return first + "-" + prev;
            }
            Simple:
            return first.ToString();
        }
    }
}
