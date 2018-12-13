using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money;
            decimal wallet = 0;
            string product;
            Dictionary<string,decimal> assortment = new Dictionary<string, decimal>()
            {
                {"nuts",(decimal)2.0},
                {"water",(decimal)0.7},
                {"crisps",(decimal)1.5},
                {"soda",(decimal)0.8},
                {"coke",(decimal)1.0}
            };

            decimal[] coins = new decimal[] {(decimal)0.1,(decimal)0.2, (decimal)0.5, (decimal)1, (decimal)0.2, (decimal)2 };

            money = Console.ReadLine().ToLower();

            while(money != "start")
            {
                    if (coins.Contains(decimal.Parse(money)))
                    {
                        wallet += decimal.Parse(money);
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {money}");
                    }

                money = Console.ReadLine().ToLower();
            }

            product = Console.ReadLine().ToLower();


            while (product != "end")
            {
                
                if (assortment.ContainsKey(product))
                {
                    if (wallet >= assortment[product])
                    {
                        Console.WriteLine($"Purchased {product}");
                        wallet -= assortment[product];
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {wallet:F2}");

        }
    }
}
