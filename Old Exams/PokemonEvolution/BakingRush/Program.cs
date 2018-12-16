using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BakingRush
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            int energy = 100;
            int coins = 100;
            int totalGained = 0;
            bool isValid = false;

            foreach (var evnt in input)
            {
                string[] tokens = evnt.Split("-");
                string commandIngridient = tokens[0];
                string amount = tokens[1];


                if (commandIngridient == "rest")
                {
                    energy += int.Parse(amount);
                    if (energy > 100)
                    {
                        int gainedEnergy = energy - 100;
                        energy = 100;
                        Console.WriteLine($"You gained 0 energy.");
                        isValid = true;
                    }
                    else
                    {
                        int gainedEnergy = int.Parse(amount);
                        Console.WriteLine($"You gained {gainedEnergy} energy.");
                    }
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (commandIngridient == "order")
                {
                    int cost = 30;
                    int earnedCoins = int.Parse(amount);

                    if (energy - cost >= 0)
                    {
                        energy -= cost;
                        coins += earnedCoins;
                        Console.WriteLine($"You earned {earnedCoins} coins.");
                        isValid = true;
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    int costIngridient = int.Parse(amount);

                    if (coins - costIngridient > 0)
                    {
                        coins -= costIngridient;
                        Console.WriteLine($"You bought {commandIngridient}.");
                    }
                    else
                    {
                        isValid = false;
                        Console.WriteLine($"Closed! Cannot afford {commandIngridient}.");
                        break;
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}

