using System;

namespace ChristmasSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int daysUntilChristmas = int.Parse(Console.ReadLine());
            int totalCost = 0;
            int totalSpirit = 0;



            int ornamentSet = 2;
            int treeSkirt = 5;
            int treeGarlands = 3;
            int treeLights = 15;


            for (int i = 1; i <= daysUntilChristmas; i++)
            {
                int cost = 0;
                if (i % 11 == 0)
                {
                    quantity += 2;
                }

                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    cost += 1 * treeSkirt + 1 * treeGarlands + 1 * treeLights;

                }


                if (i % 5 == 0)
                {
                    cost += treeLights * quantity;
                        
                    if (i % 3 == 0)
                    {
                        totalSpirit += 30;
                    }
                    totalSpirit += 17;
                }

                if (i % 3 == 0)
                {
                    cost += quantity * treeSkirt + quantity * treeGarlands;
                    totalSpirit += 13;
                }

                if (i % 2 == 0)
                {
                    cost += quantity * ornamentSet;
                    totalSpirit += 5;
                }
                totalCost += cost;

                if (i == daysUntilChristmas && i % 10 == 0)
                {
                    totalSpirit -= 30;
                }

            }

            Console.WriteLine($"Total cost: {totalCost}");
            Console.WriteLine($"Total spirit: {totalSpirit}");
        }
    }
}
