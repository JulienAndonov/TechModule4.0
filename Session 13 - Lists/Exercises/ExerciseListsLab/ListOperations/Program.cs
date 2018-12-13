using System;
using System.Collections.Generic;
using System.Linq;


namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> entryNums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
           


            while (true)
            {
                string input = Console.ReadLine();


                if (input == "End")
                {
                    break;
                }


                string[] commands = input.Split(' ');

                switch (commands[0])
                {
                    case "Add":
                        entryNums.Add(int.Parse(commands[1]));
                        break;

                    case "Insert":
                        if (int.Parse(commands[2]) > entryNums.Count || int.Parse(commands[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        int index = int.Parse(commands[2]);
                        int value = int.Parse(commands[1]);
                        entryNums.Insert(index,value);
                        break;

                    case "Remove":
                        if (int.Parse(commands[1]) > entryNums.Count || int.Parse(commands[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        entryNums.RemoveAt(int.Parse(commands[1]));
                        break;

                    case "Shift":
                        string direction = commands[1];
                        int rotations = int.Parse(commands[2]);
                        if (direction == "left")
                        {
                            for (int i = 0; i < rotations % entryNums.Count; i++)
                            {
                                int firstNumber = entryNums[0];
                                entryNums.Add(firstNumber);
                                entryNums.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < rotations % entryNums.Count; i++)
                            {
                                int lastNumber = entryNums.Last();
                                entryNums.Insert(0, lastNumber);
                                entryNums.RemoveAt(entryNums.Count - 1);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", entryNums));
        }
        
    }
}