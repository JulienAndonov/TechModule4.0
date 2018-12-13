using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesDictionariesTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            Dictionary<char,int> counters = new Dictionary<char, int>();



            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!counters.ContainsKey(word[i]))
                    {
                        counters.Add(word[i],0);
                    }
                    counters[word[i]]++;
                }
            }


            foreach (var counter in counters)
            {
                Console.WriteLine($"{counter.Key} -> {counter.Value}");
            }
        }
    }
}
