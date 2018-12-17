using System;
using System.Linq;
using System.Collections.Generic;

namespace QueensJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Retire!")
                {
                    break;
                }

                List<string> tokens = input.Split(" - ").ToList();

                // string command = tokens[0];

                if (tokens[0] == "Start")
                {
                    string lessonTitle = tokens[1];

                    if (!lessons.Contains(tokens[1]))
                    {
                        lessons.Add(tokens[1]);
                    }
                }



                else if (tokens[0] == "Complete")
                {
                    string lessonTitle = tokens[1];


                    if (lessons.Contains(tokens[1]))
                    {

                        lessons.Remove(tokens[1]);
                    }
                }

                else if (tokens[0] == "Side Quest")
                {
                    List<string> sideQuest = tokens[1].Split(":").ToList();



                    if (lessons.Contains(sideQuest[0]) && (!lessons.Contains(sideQuest[1])))
                    {
                        int indextokensOne = lessons.IndexOf(sideQuest[0]);

                        lessons.Insert(indextokensOne + 1, sideQuest[1]);

                    }

                }

                else if (tokens[0] == "Renew")
                {
                    if (lessons.Contains(tokens[1]))
                    {
                        // string lessonTitle = tokens[1];
                        int indexs = lessons.IndexOf(tokens[1]);

                        lessons.Add(tokens[1]);
                        lessons.RemoveAt(indexs);
                    }



                }
            }

            Console.Write(string.Join(", ", lessons));
            Console.Write(" ");
        }
    }
}