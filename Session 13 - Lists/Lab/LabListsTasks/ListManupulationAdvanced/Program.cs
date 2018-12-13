using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManupulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entryNums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();


            List<string> commands = Console.ReadLine().Split(' ').ToList();


            while (true)
            {
                if (commands[0] == "end")
                {
                    break;
                }


                switch (commands[0])
                {
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
                        Console.WriteLine(string.Join(" ",entryNums.Where(x => x % 2 ==0)));
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
                            Console.WriteLine(string.Join(" ",entryNums.Where(x => x <= int.Parse(commands[2]))));
                        }
                        break;
                }



                commands = Console.ReadLine().Split(' ').ToList();
            }

        }
    }
}
