using System;
using System.Collections.Generic;
using System.Linq;


namespace ExerciseDictionariesTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Dictionary<string, List<decimal>> orders = new Dictionary<string, List<decimal>>();

            while (input != "buy")
            {
                
                List<string> rawOrders = input.Split(' ').ToList();

                string item = rawOrders[0];
                decimal price = decimal.Parse(rawOrders[1]);
                int quantity = int.Parse(rawOrders[2]);


                if (!orders.ContainsKey(item))
                {
                    orders[item] = new List<decimal> { 0, 0 };
                }


               
                orders[item][0] = price;
                orders[item][1] += quantity;


                input = Console.ReadLine();
            }


            foreach(var order in orders)
            {
                decimal totalQuantity = order.Value[0];
                decimal totalPrice = order.Value[1];
                Console.WriteLine($"{order.Key} -> {totalQuantity * totalPrice:F2}");
            }
        }
    }
}
