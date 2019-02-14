using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                while (true)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    if (input[0] == "")
                    {
                        break;
                    }
                    double sum = 0;
                    int counter = 0;
                    string name = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        try
                        {
                            sum += double.Parse(input[i]);
                            counter++;
                        }
                        catch
                        {
                            name += input[i] + ' ';
                        }
                    }
                    Console.Write(sum / counter);
                    Console.Write(" " + name + "\n");

                }
            }
            catch
            {
                return;
            }
        }
    }
}
