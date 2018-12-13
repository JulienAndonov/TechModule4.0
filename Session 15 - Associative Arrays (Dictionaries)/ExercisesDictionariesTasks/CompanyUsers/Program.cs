using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();


            while (input != "End")
            {
                List<string> entries = input.Split(new[] { "->" }, StringSplitOptions.None).ToList();
                string companyName = entries[0];
                string employeeID = entries[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
                
                input = Console.ReadLine();
            }

            companies = companies.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var company in companies)
            {
                string companyName = company.Key;
                Console.WriteLine(companyName.Trim());

                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i].Trim()}");
                }
            }
        }
    }
}
