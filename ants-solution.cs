using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _400iq
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempInput = Console.ReadLine();
            int cases = int.Parse(tempInput);
            for (int i = 0; i < cases; i++)
            {
                //get length and ant number
                string[] input1 = Console.ReadLine().Split(' ');
                int length = int.Parse(input1[0]);
                int ants = int.Parse(input1[1]);

                //get ant distance from mid
                double mid = (double)length / 2;
                int currentAnts = 0;
                List<double> positions = new List<double>();
                while (currentAnts < ants)
                {
                    string[] input2 = Console.ReadLine().Split(' ');

                    List<double> intInput2 = new List<double>();
                    for (int j = 0; j < input2.Length; j++)
                    {
                        intInput2.Add(Math.Abs(double.Parse(input2[j]) - mid));
                    }
                    currentAnts += input2.Length;
                    positions.AddRange(intInput2);
                }

                positions.Sort();

                Console.WriteLine((mid - positions[0]) + " " + (length - (mid - positions.Last())));
            }
            Console.Read();
        }
    }
}
