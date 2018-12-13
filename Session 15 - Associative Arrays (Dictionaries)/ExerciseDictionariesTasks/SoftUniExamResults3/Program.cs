using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExamResults3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> submissions = new Dictionary<string, List<string>>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            string input = Console.ReadLine();
            

            while (input != "exam finished")
            {
                List<string> entries = input.Split('-').ToList();
                string name = entries[0];
                string language = entries[1];
                int points = int.Parse(entries[1] == "banned" ? "-1" : entries[2]);

                if (!submissions.ContainsKey(name))
                {
                    submissions[name] = new List<string>() { language };
                }
        
                if (!languages.ContainsKey(language))
                {
                    languages[language] = 0;
                }

                languages[language]++;
         
                submissions[name].Add(points.ToString());

                input = Console.ReadLine();
            }

            submissions = submissions.OrderByDescending(x => x.Value.Skip(1).Max()).ThenBy(x => x.Value.Take(1).Max()).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);


            Console.WriteLine("Results:");

            foreach (var submission in submissions.Where(x => !x.Value.Contains("-1")))
            {
                int maxScore = submission.Value.Skip(1).Select(x => int.Parse(x)).Max();
                Console.WriteLine($"{submission.Key} | {maxScore}");
            }

            Console.WriteLine("Submissions:");
    
            foreach(var language in languages.OrderBy(x => x.Key).Where(x => !x.Key.Contains("banned")))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
         

        }
    }
}
