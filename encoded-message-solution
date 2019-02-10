using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500iq
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            for(int i = 0; i < input1; i++)
            {
                string encoded = Console.ReadLine();

                int side = (int)Math.Sqrt(encoded.Length);

                char[,] sq = new char[side,side];
                int counter = 0;

                for(int j = 0; j < side; j++)
                {
                    for(int k = 0; k < side; k++)
                    {
                        sq[j,k] = encoded[counter];
                        counter++;
                    }
                }

                string decoded = "";
                for (int j = side - 1; j >= 0; j--)
                {
                    for (int k = 0; k < side; k++)
                    {
                        decoded += sq[k, j];
                    }
                }

                Console.WriteLine(decoded);
            }
            Console.Read();
        }
    }
}
