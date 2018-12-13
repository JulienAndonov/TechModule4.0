using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').Select(x => x.ToLower()).ToList();
            Dictionary<string, int> counters = new Dictionary<string, int>();


            for (int i = 0; i < words.Count; i++)
            {
                if (!counters.ContainsKey(words[i]))
                {
                    counters[words[i]] = 0;
                }
                counters[words[i]]++;
            }


            foreach (var keyValuePair in counters.Where(x => x.Value % 2 != 0))
            {
                Console.Write(keyValuePair.Key + " ");
            }
            Console.WriteLine();

        }
    }
}
