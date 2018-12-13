using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namePoints = new Dictionary<string, int>();
            Dictionary<string, int> languageCount = new Dictionary<string, int>();


            while (true)
            {

                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] tokens = input.Split('-');

                string name = tokens[0];
                string language = tokens[1];


                if (tokens.Length == 2)
                {
                    namePoints.Remove(name);
                    continue;
                }


                int points = int.Parse(tokens[2]);
                if (namePoints.ContainsKey(name) == false)
                {
                    namePoints[name] = points;
                }
                else
                {
                    if (namePoints[name] < points)
                    {
                        namePoints[name] = points;
                    }
                }


                if (languageCount.ContainsKey(language) == false)
                {
                    languageCount[language] = 1;
                }
                else
                {
                    languageCount[language]++;
                }
            }


            Console.WriteLine("Results:");
            Console.WriteLine(String.Join(Environment.NewLine,namePoints
                .OrderByDescending(a => a.Value)
                .ThenBy(b => b.Key)
                .Select(c => $"{c.Key} | {c.Value}")));


            Console.WriteLine("Submissions:");
            Console.WriteLine(String.Join(Environment.NewLine,languageCount
                .OrderByDescending(a => a.Value)
                .ThenBy(b => b.Key)
                .Select(c => $"{c.Key} - {c.Value}")));
        }
    }
}
