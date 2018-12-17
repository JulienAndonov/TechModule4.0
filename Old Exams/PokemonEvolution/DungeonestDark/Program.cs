using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> numbers = Console.ReadLine().Split("|").ToList();
        List<string> tokens = new List<string>();
        int health = 100;
        int coins = 0;
        int counter = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            tokens = numbers[i].Split(" ").ToList();
            counter++;

            if (tokens[0] == "potion")
            {
                if (health + int.Parse(tokens[1]) >= 100)
                {
                    Console.WriteLine("You healed for {0} hp.", 100 - health);
                    Console.WriteLine("Current health: 100 hp.");
                    health = 100;
                }

                else if (health + int.Parse(tokens[1]) < 100)
                {
                    health = health + int.Parse(tokens[1]);
                    Console.WriteLine("You healed for {0} hp.", int.Parse(tokens[1]));
                    Console.WriteLine("Current health: {0} hp.", health);
                }

            }


            else if (tokens[0] == "chest")
            {
                coins = coins + int.Parse(tokens[1]);
                Console.WriteLine("You found {0} coins.", int.Parse(tokens[1]));



            }
            else
            {
                int monster = int.Parse(tokens[1]);

                if (health > monster)
                {
                    health = health - int.Parse(tokens[1]);
                    Console.WriteLine("You slayed {0}.", tokens[0]);

                }
                else if (health <= monster)
                {

                    Console.WriteLine("You died! Killed by {0}.", (tokens[0]));

                    if (counter < numbers.Count)
                    {
                        Console.WriteLine("Best room: {0}", counter);
                        return;
                    }


                }


            }
            if (i == numbers.Count - 1)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine("Coins: {0}", coins);
                Console.WriteLine("Health: {0}", health);
            }
        }

    }



}