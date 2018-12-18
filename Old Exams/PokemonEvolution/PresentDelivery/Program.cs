using System;
using System.Collections.Generic;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houseMembers = Console.ReadLine().Split("@").Select(h => int.Parse(h)).ToArray();
            string input = Console.ReadLine();
            int index = 0;


            while (input != "Merry Xmas!")
            {
                string[] tokens = input.Split();
                int jumpLength = int.Parse(tokens[1]);
                index = (index + jumpLength) % houseMembers.Length;
                
                if (houseMembers[index] > 0)
                {
                    houseMembers[index] -= 2;
                }
                else
                {
                    Console.WriteLine($"House {index} will have a Merry Christmas.");
                }

                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {index}.");

            int successfullHouses = houseMembers.Where(t => t <= 0).Count();

            if (successfullHouses == houseMembers.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int difference = houseMembers.Length - successfullHouses;
                Console.WriteLine($"Santa has failed {difference} houses.");
            }
        }
    }
}
