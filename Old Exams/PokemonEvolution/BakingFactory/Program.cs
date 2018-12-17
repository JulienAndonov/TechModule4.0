using System;
using System.Collections.Generic;
using System.Linq;

namespace BakingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string bestBread = "";
            int maxQuality = int.MinValue;
            int minCount = int.MinValue;
            double maxAvarage = double.MinValue;

            while (input != "Bake It!")
            {
                List<int> breadQuality = input.Split("#", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
                int quality = breadQuality.Sum();
                int count = breadQuality.Count();
                double avarage = quality / count;

                if (quality > maxQuality)
                {
                    maxQuality = quality;
                    bestBread = String.Join(" ", breadQuality);
                    minCount = count;
                    maxAvarage = avarage;
                }
                else if (quality == maxQuality && avarage > maxAvarage)
                {
                    maxQuality = quality;
                    bestBread = String.Join(" ", breadQuality);
                    minCount = count;
                    maxAvarage = avarage;
                }
                else if (quality == maxQuality && avarage == maxAvarage && count < minCount)
                {
                    maxQuality = quality;
                    bestBread = String.Join(" ", breadQuality);
                    minCount = count;
                }
                quality = -1;
                count = -1;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best Batch quality: {maxQuality}");
            Console.WriteLine($"{bestBread}");

        }
    }
}
