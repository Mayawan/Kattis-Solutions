using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacking_Curvy_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double[] curve1;
                try
                {
                    curve1 = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
                }
                catch
                {
                    break;
                }
                if (curve1.Length == 0) break;

                double[] curve2 = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

                List<double> finalCurve = new List<double>();

                for(int i = 0; i < curve1.Length; i++)
                    finalCurve.Add(curve2[i] - curve1[i]);

                double[] derive = { finalCurve[1], finalCurve[2] * 2, finalCurve[3] * 3 };

                double discrim = Math.Pow(derive[1], 2) - (4 * derive[2] * derive[0]);

                List<double> b = new List<double>();
                List<double> sol = new List<double>();

                if(derive[2] != 0)
                {
                    if(discrim >= 0)
                    {
                        b.Add((-derive[1] + Math.Sqrt(discrim)) / (2 * derive[2]));
                        b.Add((-derive[1] - Math.Sqrt(discrim)) / (2 * derive[2]));
                    }

                    foreach (double s in b)
                    {
                        if (s < 1 && s > 0)
                        {
                            sol.Add(finalCurve[0] +
                                (finalCurve[1] * s) +
                                (finalCurve[2] * Math.Pow(s, 2)) +
                                (finalCurve[3] * Math.Pow(s, 3))
                                );
                        }
                    }
                }

                sol.Add(finalCurve[0]);
                sol.Add(finalCurve[0] + finalCurve[1] + finalCurve[2] + finalCurve[3]);

                Console.WriteLine(sol.Max() - sol.Min());
            }
        }
    }
}
