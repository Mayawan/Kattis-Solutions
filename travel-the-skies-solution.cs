using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Travel_The_Skies
{
    class Program
    {
        static void Main(string[] args)
        {
            v4();
        }

        //;(
        static void v1()
        {
            //input

            int[] knm = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            List<int[]> flightInfo = new List<int[]>();
            List<int[]> arrivalInfo = new List<int[]>();

            for (int i = 0; i < knm[2]; i++)
            {
                flightInfo.Add(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            }

            for (int i = 0; i < knm[1] * knm[0]; i++)
            {
                arrivalInfo.Add(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            }

            //alg

            //airport number n is stored with index n-1
            BigInteger[] airport = new BigInteger[knm[0]];

            for (int i = 0; i < knm[1]; i++)
            {
                //Console.WriteLine("Day " + (i + 1));

                //get flights of that day
                List<int[]> dayFlights = new List<int[]>();
                for (int j = 0; j < flightInfo.Count; j++)
                {
                    if (flightInfo[j][2] == i + 1)
                    {
                        dayFlights.Add(flightInfo[j]);
                        //Console.WriteLine("There is a flight from " + flightInfo[j][0] + " to " + flightInfo[j][1] + " with " + flightInfo[j][3] + " people");
                    }
                }

                //add arrivals of that day
                for (int j = 0; j < arrivalInfo.Count; j++)
                {
                    if (arrivalInfo[j][1] == i + 1)
                    {
                        airport[arrivalInfo[j][0] - 1] += arrivalInfo[j][2];
                        //Console.WriteLine("Airport " + (arrivalInfo[j][0]) + " gained " + arrivalInfo[j][2] + " people");
                    }
                }

                //flights
                for (int j = 0; j < dayFlights.Count; j++)
                {
                    //check if optimal
                    if (dayFlights[j][3] > airport[dayFlights[j][0] - 1]) goto SubOptimal;
                    else
                    {
                        airport[dayFlights[j][0] - 1] -= dayFlights[j][3];
                        airport[dayFlights[j][1] - 1] += dayFlights[j][3];
                    }
                }
            }

            Console.WriteLine("optimal");
            Console.Read();
            return;

        SubOptimal:
            Console.WriteLine("suboptimal");
            Console.Read();
        }

        //;(
        static void v2()
        {
            //get k,n,m input
            int[] knm = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int k = knm[0];
            int n = knm[1];
            int m = knm[2];

            //get flights and arrivals, instantiates # of people in airport
            int[] people = new int[k];
            Dictionary<int, List<int[]>> flights = new Dictionary<int, List<int[]>>();
            Dictionary<int, List<int[]>> additional = new Dictionary<int, List<int[]>>();

            //flights
            for (int i = 0; i < m; i++)
            {
                int[] flight = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                flight[0]--;
                flight[1]--;
                flight[2]--;
                try
                {
                    flights[flight[2]].Add(flight);
                }
                catch
                {
                    List<int[]> temp = new List<int[]>();
                    temp.Add(flight);
                    flights.Add(flight[2], temp);
                }

            }

            //arrivals
            for (int i = 0; i < k * n; i++)
            {
                int[] arrival = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                arrival[0]--;
                arrival[1]--;
                try
                {
                    additional[arrival[1]].Add(arrival);
                }
                catch
                {
                    List<int[]> temp = new List<int[]>();
                    temp.Add(arrival);
                    additional.Add(arrival[1], temp);
                }
            }

            //alg

            for (int i = 0; i < n; i++)
            {
                //add new arrivals
                foreach (int[] arrival in additional[i])
                {
                    people[arrival[0]] += arrival[2];
                }

                //flights
                foreach (int[] flight in flights[i])
                {
                    people[flight[0]] -= flight[3];
                    if (people[flight[0]] < 0) goto SubOptimal;
                    people[flight[1]] += flight[3];
                }
            }

            Console.WriteLine("optimal");
            Console.Read();
            return;
        SubOptimal:
            Console.WriteLine("suboptimal");
            Console.Read();
        }

        //;(
        static void v3()
        {
            //get k,n,m input
            int[] knm = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int k = knm[0];
            int n = knm[1];
            int m = knm[2];

            //get flights and arrivals, instantiates # of people in airport
            int[] people = new int[k];
            Dictionary<int, List<int[]>> flights = new Dictionary<int, List<int[]>>();
            Dictionary<int, List<int[]>> additional = new Dictionary<int, List<int[]>>();

            //flights
            for (int i = 0; i < m; i++)
            {
                int[] flight = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                flight[0]--;
                flight[1]--;
                flight[2]--;
                try
                {
                    flights[flight[2]].Add(flight);
                }
                catch
                {
                    List<int[]> temp = new List<int[]>();
                    temp.Add(flight);
                    flights.Add(flight[2], temp);
                }

            }

            //arrivals
            for (int i = 0; i < k * n; i++)
            {
                int[] arrival = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                arrival[0]--;
                arrival[1]--;
                try
                {
                    additional[arrival[1]].Add(arrival);
                }
                catch
                {
                    List<int[]> temp = new List<int[]>();
                    temp.Add(arrival);
                    additional.Add(arrival[1], temp);
                }
            }

            //alg
            for (int i = 0; i < n; i++)
            {
                //add new arrivals
                foreach (int[] arrival in additional[i])
                {
                    people[arrival[0]] += arrival[2];
                }

                //fly out
                foreach (int[] flight in flights[i])
                {
                    people[flight[0]] -= flight[3];
                    if (people[flight[0]] < 0) goto SubOptimal;
                }

                foreach (int[] flight in flights[i])
                {
                    people[flight[1]] += flight[3];
                }
            }

            Console.WriteLine("optimal");
            Console.Read();
            return;

        SubOptimal:
            Console.WriteLine("suboptimal");
            Console.Read();
        }

        //works
        static void v4()
        {
            //input

            int[] knm = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            List<int[]> flightInfo = new List<int[]>();
            List<int[]> arrivalInfo = new List<int[]>();

            for (int i = 0; i < knm[2]; i++)
            {
                flightInfo.Add(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            }

            for (int i = 0; i < knm[1] * knm[0]; i++)
            {
                arrivalInfo.Add(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            }

            //alg

            //airport number n is stored with index n-1
            BigInteger[] airport = new BigInteger[knm[0]];

            for (int i = 0; i < knm[1]; i++)
            {
                //Console.WriteLine("Day " + (i + 1));

                //get flights of that day
                List<int[]> dayFlights = new List<int[]>();
                for (int j = 0; j < flightInfo.Count; j++)
                {
                    if (flightInfo[j][2] == i + 1)
                    {
                        dayFlights.Add(flightInfo[j]);
                        //Console.WriteLine("There is a flight from " + flightInfo[j][0] + " to " + flightInfo[j][1] + " with " + flightInfo[j][3] + " people");
                    }
                }

                //add arrivals of that day
                for (int j = 0; j < arrivalInfo.Count; j++)
                {
                    if (arrivalInfo[j][1] == i + 1)
                    {
                        airport[arrivalInfo[j][0] - 1] += arrivalInfo[j][2];
                        //Console.WriteLine("Airport " + (arrivalInfo[j][0]) + " gained " + arrivalInfo[j][2] + " people");
                    }
                }

                //flight out
                for (int j = 0; j < dayFlights.Count; j++)
                {
                    //check if optimal
                    if (dayFlights[j][3] > airport[dayFlights[j][0] - 1]) goto SubOptimal;
                    else
                    {
                        airport[dayFlights[j][0] - 1] -= dayFlights[j][3];
                    }
                }

                //flight in
                for (int j = 0; j < dayFlights.Count; j++)
                {
                    airport[dayFlights[j][1] - 1] += dayFlights[j][3];
                }
            }

            Console.WriteLine("optimal");
            Console.Read();
            return;

        SubOptimal:
            Console.WriteLine("suboptimal");
            Console.Read();
        }

        //works
        static void v5()
        {
            string tempInput = Console.ReadLine();
            tempInput = tempInput.Trim(' ');
            tempInput = tempInput.TrimEnd('\r', '\n');
            string[] input1 = tempInput.Split(' ');
            int airports = int.Parse(input1[0]);
            int days = int.Parse(input1[1]);
            int numFlights = int.Parse(input1[2]);

            List<List<int>> flightInfo = new List<List<int>>();
            for (int i = 0; i < numFlights; i++)
            {
                tempInput = Console.ReadLine();
                string[] input2 = tempInput.Split(' ');
                List<int> thisFlight = new List<int>();
                for (int j = 0; j < input2.Length; j++)
                {
                    thisFlight.Add(int.Parse(input2[j]));
                }
                flightInfo.Add(thisFlight);
            }

            int kn = airports * days;
            List<List<int>> arrivals = new List<List<int>>();
            for (int i = 0; i < kn; i++)
            {
                tempInput = Console.ReadLine();
                string[] input3 = tempInput.Split(' ');
                List<int> thisArrival = new List<int>();
                for (int j = 0; j < input3.Length; j++)
                {
                    thisArrival.Add(int.Parse(input3[j]));
                }
                arrivals.Add(thisArrival);
            }

            bool isOptimal = true;
            int[] peopleInAirport = new int[airports];
            for (int i = 0; i < days; i++)
            {
                //get index of all arrivals
                List<int> indexOfArrivals = new List<int>();
                for (int j = 0; j < arrivals.Count; j++)
                {
                    if (arrivals[j][1] == i + 1) indexOfArrivals.Add(j);
                }
                //get arrivals for all peopleInAirport.Length airports at day i
                for (int j = 0; j < indexOfArrivals.Count; j++)
                {
                    peopleInAirport[arrivals[indexOfArrivals[j]][0] - 1] += arrivals[indexOfArrivals[j]][2];
                }

                int[] peopleATT = peopleInAirport;

                //gets index of flights on day i
                List<int> indexOfFlights = new List<int>();
                for (int j = 0; j < flightInfo.Count; j++)
                {
                    if (flightInfo[j][2] == i + 1) indexOfFlights.Add(j);
                }

                for (int j = 0; j < indexOfFlights.Count; j++)
                {
                    int startingLocation = flightInfo[indexOfFlights[j]][0] - 1;
                    int destination = flightInfo[indexOfFlights[j]][1] - 1;
                    int capacity = flightInfo[indexOfFlights[j]][3];

                    if (capacity > peopleATT[startingLocation])
                    {
                        isOptimal = false;
                        break;
                    }
                    //sends people to destination
                    peopleInAirport[startingLocation] -= capacity;
                }

                for (int j = 0; j < indexOfFlights.Count; j++)
                {
                    int startingLocation = flightInfo[indexOfFlights[j]][0] - 1;
                    int destination = flightInfo[indexOfFlights[j]][1] - 1;
                    int capacity = flightInfo[indexOfFlights[j]][3];

                    //adds people to airport
                    peopleInAirport[destination] += capacity;
                }
            }
            if (isOptimal)
            {
                Console.WriteLine("optimal");
            }
            else
            {
                Console.WriteLine("suboptimal");
            }
            Console.Read();
        }
    }
}

