using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

namespace welcomeeasy
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "welcome to code jam";

            int numTestCases = int.Parse(Console.ReadLine());

            for(int i = 0; i < numTestCases; i++)
            {
                string input = Console.ReadLine();

                BigInteger[] values = new BigInteger[input.Length];

                //remove bad letters
                List<string> listInput = input.Select(x => x.ToString()).ToList();
                string cleanInput = "";

                for (int j = 0; j < listInput.Count; j++)
                {

                    if (welcome.Contains(listInput[j]))
                    {
                        cleanInput += listInput[j];
                    }
                }

                //alg
                for(int j = welcome.Length - 1;j >= 0; j--)
                {
                    char check = welcome[j];
                    //Console.WriteLine("check:)" + check);

                    for (int k = 0; k < cleanInput.Length; k++)
                    {
                        //m
                        if(cleanInput[k] == check)
                        {
                            if (j == welcome.Length - 1)
                            {
                                values[k] = 1;
                            }
                            else
                            {
                                char sumCheck = welcome[j + 1];
                                BigInteger sum = 0;
                                //Console.WriteLine("Sum Check:" + sumCheck);
                                //Console.WriteLine("index: " + k);
                                //Console.WriteLine(cleanInput + "\n");

                                for(int l = k; l < cleanInput.Length; l++)
                                {
                                    //the rest
                                    if(cleanInput[l] == sumCheck)
                                    {
                                        sum += values[l];
                                    }
                                }

                                values[k] = sum;
                            }
                        }
                    }
                }

                BigInteger wSum = 0;

                for(int j = 0; j < cleanInput.Length; j++)
                {
                    if(cleanInput[j] == 'w')
                    {
                        wSum += values[j];
                    }
                }

                string val = "";

                string leString = wSum.ToString();

                if(leString.Length == 1)
                {
                    val = "000" + leString[0];
                }
                else if(leString.Length == 2)
                {
                    val = "00" + leString;
                }
                else if(leString.Length == 3)
                {
                    val = "0" + leString;
                }
                else if(leString.Length == 4)
                {
                    val = leString;
                }
                else
                {
                    val = leString.Substring(leString.Length - 4);
                }

                Console.WriteLine("Case #" + (i + 1) + ": " + val);
            }

            Console.Read();
        }
    }
}
