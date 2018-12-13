using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,decimal> gameCatalog = new Dictionary<string, decimal>()
            {
                { "OutFall 4" ,(decimal)39.99},
                { "CS: OG", (decimal)15.99 },
                { "Zplinter Zell",(decimal)19.99},
                { "Honored 2", (decimal)59.99},
                { "RoverWatch", (decimal)29.99},
                { "RoverWatch Origins Edition",(decimal)39.99}
            };


            decimal wallet = decimal.Parse(Console.ReadLine());
            decimal initwallet = wallet;
            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                
                if (gameCatalog.ContainsKey(command))
                {
                    if (gameCatalog[command] > wallet)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {

                        wallet -= gameCatalog[command];
                        Console.WriteLine($"Bought {command}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: {initwallet - wallet}. Remaining: {wallet}");

        }
    }
}
