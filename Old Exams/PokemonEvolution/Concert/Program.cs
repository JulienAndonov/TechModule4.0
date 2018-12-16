using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> bandSingers = new Dictionary<string, List<string>>();
            Dictionary<string, uint> bandTime = new Dictionary<string, uint>();




            while (input != "start of concert")
            {
                string[] tokens = input.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string band = tokens[1];


                if (command == "Add")
                {
                    List<string> singers = tokens[2].Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (!bandSingers.ContainsKey(band))
                    {
                        bandTime[band] = 0;
                        bandSingers[band] = singers;
                    }
                    else
                    {
                        for (int i = 0; i < singers.Count; i++)
                        {
                            string singer = singers[i];
                            if (bandSingers[band].IndexOf(singer) == -1)
                            {
                                bandSingers[band].Add(singer);
                            }
                        }
                    }
                }
                else if (command == "Play")
                {
                    uint time = uint.Parse(tokens[2]);
                    if (!bandTime.ContainsKey(band))
                    {
                        bandSingers[band] = new List<string>();
                        bandTime[band] = 0;
                    }
                    bandTime[band] += time;
                }
                input = Console.ReadLine();
            }

            long totalTime = bandTime.Skip(0).Sum(t => t.Value);

            Console.WriteLine($"Total time: {totalTime}");


            foreach (var band in bandTime.OrderByDescending(b => b.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }


            string bandStart = Console.ReadLine();


            foreach (var band in bandSingers.Where(b => b.Key == bandStart))
            {
                Console.WriteLine($"{band.Key}");
                foreach (var singer in band.Value)
                {
                    Console.WriteLine($"=> {singer}");
                }

            }


        }
    }
}
