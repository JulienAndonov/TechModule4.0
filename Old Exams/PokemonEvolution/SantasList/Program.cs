using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> noisyKids = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finished!")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];
                string name = tokens[1];

                if (command == "Bad")
                {
                    if (!noisyKids.Contains(name))
                    {
                        noisyKids.Insert(0, name);
                    }
                }

                if (command == "Good")
                {
                    if (noisyKids.Contains(name))
                    {
                        noisyKids.Remove(name);
                    }
                }


                if (command == "Rename")
                {
                    string oldName = name;
                    string newname = tokens[2];

                    if (noisyKids.Contains(oldName))
                    {
                        int index = noisyKids.IndexOf(oldName);
                        noisyKids.Remove(name);
                        noisyKids.Insert(index, newname);
                    }
                }


                if (command == "Rearrange")
                {
                    if (noisyKids.Contains(name))
                    {
                        noisyKids.Remove(name);
                        noisyKids.Add(name);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", noisyKids));
        }
    }
}
