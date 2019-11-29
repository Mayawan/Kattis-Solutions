using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisaintyourgrandpascheckerboard
{
    class Program
    {
        static bool checkString(string s)
        {
            return s.Contains("WWW") || s.Contains("BBB") || s.Count(x => x == 'B') != s.Count(x => x == 'W');
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] grid = new string[n];

            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (checkString(s))
                    goto Aint;
                grid[i] = s;
            }

            for(int i = 0; i < n; i++)
            {
                string s = new string(grid.Select(x => x[i]).ToArray());
                if (checkString(s))
                    goto Aint;
            }
            Console.WriteLine(1);
            return;
        Aint:
            Console.WriteLine(0);
        }
    }
}
