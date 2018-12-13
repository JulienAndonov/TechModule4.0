using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUnIExamResults2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> submissions = new Dictionary<string, Dictionary<string, List<int>>>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            string input = Console.ReadLine();



            while (input != "exam finished")
            {
                List<string> entries = input.Split('-').ToList();

                string name = entries[0];
                string lanaguage = entries[1];
                int points = int.Parse(entries[1] == "banned" ? "0" : entries[2]);

                if (!submissions.ContainsKey(name))
                {
                    submissions[name] = new Dictionary<string, List<int>>();

                }

                if (!languages.ContainsKey(lanaguage))
                {
                    languages[lanaguage] = 0;
                }

                languages[lanaguage]++;

                if (submissions[name].ContainsKey(lanaguage))
                {
                    submissions[name][lanaguage].Add(points);
                }
                else
                {
                    submissions[name].Add(lanaguage, new List<int>() { points });
                }
                input = Console.ReadLine();
            }


            Console.WriteLine("Results:");

            foreach (var submission in submissions.Where(x => !x.Value.ContainsKey("banned")).OrderByDescending(x => x.Value.Values.Max().Max()).ToDictionary(kvp => kvp.Key, kvp => kvp.Value))
            {
                Console.WriteLine($"{submission.Key} | {submission.Value.Max().Value.Max()}");
            }

            Console.WriteLine("Submissions:");
            foreach(var language in languages.Where(x => x.Key != "banned").OrderBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
           
        }
    }
}
