using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();

            string first = "";
            string second = "";
            string third = "";
            bool b = false;

            for(int i = 0; i < a.Length; i++)
            {
                first += ".." + (((i + 1) % 3 == 0) ? "*" : "#") + ".";
                second += "." + (((i + 1) % 3 == 0) ? "*" : "#") + "." + (((i + 1) % 3 == 0) ? "*" : "#");
                if ((i + 1) % 3 == 0)
                {
                    third += "*." + a[i] + ".";
                    b = true;
                }
                else if(b)
                {
                    third += "*." + a[i] + ".";
                    b = false;
                }
                else
                {
                    third += "#." + a[i] + ".";
                }
                    
            }
            first += ".";
            second += ".";
            third += ((a.Length) % 3 == 0) ? "*" : "#";

            Console.WriteLine("{0}\n{1}\n{2}\n{1}\n{0}", first, second, third);
        }
    }
}
  
