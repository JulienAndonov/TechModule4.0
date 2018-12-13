using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entryNums = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList();


            List<string> commands = Console.ReadLine().Split(' ').ToList();
            bool isChanged = false;

            while (true)
            {
                string nextCommand = commands[0];

                if (nextCommand == "end")
                {
                    break;
                }

                switch (nextCommand)
                {
                    case "Add":
                        entryNums.Add(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        int index = entryNums.IndexOf(int.Parse(commands[1]));
                        entryNums.RemoveAt(index);
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        entryNums.RemoveAt(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        entryNums.Insert(int.Parse(commands[2]),int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        if (entryNums.Contains(int.Parse(commands[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", entryNums.Where(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", entryNums.Where(x => x % 2 != 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(entryNums.Sum());
                        break;

                    case "Filter":
                        if (commands[1] == ">")
                        {
                            Console.WriteLine(string.Join(" ", entryNums.Where(x => x > int.Parse(commands[2]))));
                        }
                        else if (commands[1] == ">=")
                        {
                            Console.WriteLine(string.Join(" ", entryNums.Where(x => x >= int.Parse(commands[2]))));
                        }
                        else if (commands[1] == "<")
                        {
                            Console.WriteLine(string.Join(" ", entryNums.Where(x => x < int.Parse(commands[2]))));
                        }
                        else if (commands[1] == "<=")
                        {
                            Console.WriteLine(string.Join(" ", entryNums.Where(x => x <= int.Parse(commands[2]))));
                        }

                        break;
                }

                commands = Console.ReadLine().Split(' ').ToList();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ",entryNums));
            }
        }
    }
}
