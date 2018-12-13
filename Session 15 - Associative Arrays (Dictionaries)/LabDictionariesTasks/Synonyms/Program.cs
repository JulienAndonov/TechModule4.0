using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            int wordsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();


            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }

                synonyms[word].Add(synonym);
            }


            foreach (var synonym in synonyms)
            {
                Console.WriteLine($"{synonym.Key} - {string.Join(", ",synonyms[synonym.Key])}");
            }
        }
    }
}
