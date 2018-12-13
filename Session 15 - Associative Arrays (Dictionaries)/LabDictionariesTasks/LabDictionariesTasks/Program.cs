using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDictionariesTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();



            Dictionary<int, int> counters = new Dictionary<int, int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (!counters.ContainsKey(numbers[i]))
                {
                    counters[numbers[i]] = 0;
                }

                counters[numbers[i]]++;
            }

            counters = counters.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key,kvp => kvp.Value);

            foreach (var counter in counters)
            {
                Console.WriteLine($"{counter.Key} -> {counter.Value}");
            }
        }
    }
}
