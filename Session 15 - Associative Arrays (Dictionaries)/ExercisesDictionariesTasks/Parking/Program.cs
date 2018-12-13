using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> registry = new Dictionary<string, List<string>>();



            for (int i = 0; i < numberOfOperations; i++)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                string operation = commands[0];
                string personsName = commands[1];
               


                switch (operation)
                {
                    case "register":
                        string carNumber = commands[2];
                        if (!registry.ContainsKey(personsName))
                        {
                            registry[personsName] = new List<string> { personsName, carNumber };
                            Console.WriteLine($"{personsName} registered {carNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {carNumber}");
                        }
                        break;
                    case "unregister":
                        
                        if (registry.ContainsKey(personsName))
                        {
                            registry.Remove(personsName);
                            Console.WriteLine($"{personsName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {personsName} not found");
                        }
                        break;
                }
            }


            foreach (var register in registry)
            {
                string personName = register.Value[0];
                string plate = register.Value[1];
                Console.WriteLine($"{personName} => {plate}");
            }
            
        }
    }
}
