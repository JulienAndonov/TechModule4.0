using System;
using System.Collections.Generic;
using System.Linq;

namespace IronGirder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int[]> trips = new Dictionary<string, int[]>();


            //0-st Index = time
            //1-nd Index = Passangers

            while (input != "Slide rule")
            {
                string[] tokens = input.Split(":");
                string town = tokens[0];
                string[] scnTokens = tokens[1].Split("->");
                int passangerCount = int.Parse(scnTokens[1]);


                if (input.Contains("ambush"))
                {

                    if (trips.ContainsKey(town))
                    {
                        trips[town][0] = 0;
                        trips[town][1] -= passangerCount;
                    }
                }
                else
                {
                    int time = int.Parse(scnTokens[0]);

                    if (!trips.ContainsKey(town))
                    {
                        trips[town] = new int[2];
                    }

                    if (trips[town][0] > time || trips[town][0] == 0)
                    {
                        trips[town][0] = time;
                    }
                    trips[town][1] += passangerCount;
                }
                input = Console.ReadLine();
            }

            foreach (var trip in trips.Where(t => t.Value[0] != 0 && t.Value[1] > 0).OrderBy(t => t.Value[0]).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{trip.Key} -> Time: {trip.Value[0]} -> Passengers: {trip.Value[1]}");
            }
        }
    }
}
