using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseListsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            int capacity = int.Parse(Console.ReadLine());

            List<string> commands = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                if (commands[0] == "end")
                {
                    Console.WriteLine(string.Join(" ",wagons));
                    break;
                }


                if (commands[0] == "Add")
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity >= wagons[i] + int.Parse(commands[0]))
                        {
                            wagons[i] += int.Parse(commands[0]);
                            break;
                        }

                    }
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
