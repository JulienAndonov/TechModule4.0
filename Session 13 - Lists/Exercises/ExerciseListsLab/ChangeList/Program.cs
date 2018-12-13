using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
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
                    case "Delete":
                        for (int i = 0; i < entryNums.Count; i++)
                        {
                            if (entryNums[i] == int.Parse(commands[1]))
                            {
                                entryNums.RemoveAt(i);
                            }
                        }
                        break;
                    case "Insert":
                        entryNums.Insert(int.Parse(commands[2]),int.Parse(commands[1]));
                        break;
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }


            Console.WriteLine(string.Join(" ",entryNums));



        }
    }
}
