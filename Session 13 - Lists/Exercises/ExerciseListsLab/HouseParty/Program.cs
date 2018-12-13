using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numofGuests = int.Parse(Console.ReadLine());


            List<string> commands = new List<string>();
            List<string> guests = new List<string>();


            for (int i = 0; i < numofGuests; i++)
            {
                commands = Console.ReadLine().Split(' ').ToList();
                if (commands[2] == "not")
                {
                    if (guests.Contains(commands[0]))
                    {
                        guests.RemoveAt(guests.IndexOf(commands[0]));
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
                else if (commands[2] == "going!")
                {
                    if (guests.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(commands[0]);
                    }
                }
                
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));

        }
    }
}
