using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string[] wordsDeffinition = input.Split(" | ");


            foreach (var wordsKey in wordsDeffinition)
            {
                string[] wordKey = wordsKey.Split(": ");
                string word = wordKey[0];
                string deffinition = wordKey[1];

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                words[word].Add(deffinition);

            }

            string[] instructions = Console.ReadLine().Split(" | ");

            foreach (var instruction in instructions)
            {
                if (words.ContainsKey(instruction))
                {
                    Console.WriteLine($"{instruction}");
                    foreach (var deffinition in words[instruction].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{deffinition}");
                    }
                }
            }

            string finalCommand = Console.ReadLine();


            if (finalCommand == "List")
            {
                Console.WriteLine(String.Join(" ", words.Keys.OrderBy(a => a)));
            }
        }
    }
}
