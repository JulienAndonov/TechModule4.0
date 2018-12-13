using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamProjectV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();

            int numberOfTeams = int.Parse(Console.ReadLine());



            for (int i = 0; i < numberOfTeams; i++)
            {
                List<string> instructions = Console.ReadLine().Split('-').ToList();
                string teamMember = instructions[0];
                string teamName = instructions[1];

                if (!teams.ContainsKey(teamName))
                {
                    teams[teamName] = new List<string>() { teamMember };
                    Console.WriteLine($"Team {teamName} has been created by {teamMember}!");
                }
                else
                {
                    if (checkMember(teams, teamMember) != "-1")
                    {
                        Console.WriteLine($"{teamMember} cannot create another team!");
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                    teams[teamName].Add(teamMember);
                }
                
            }

            while (true)
            {
                string teamInstructions = Console.ReadLine();

                if (teamInstructions == "end of assignment")
                {
                    break;
                }
                List<string> instructions = teamInstructions.Split(new[] { "->" }, StringSplitOptions.None).ToList();

                string teamMember = instructions[0];
                string teamName = instructions[1];

                if (!teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    if (teams[teamName].Contains(teamMember))
                    {
                        Console.WriteLine($"Member {teamMember} cannot join team {teamName}!");
                    }
                    else
                    {
                        teams[teamName].Add(teamMember);
                    }

                }

            }

            teams = teams.OrderByDescending(x => x.Value.Count).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var team in teams.Where(x => x.Value.Count > 1))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- {team.Value[0]}");
                foreach (var member in team.Value.GetRange(1, team.Value.Count - 1))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(x => x.Value.Count == 1))
            {
                Console.WriteLine(team.Key);
            }

          

        }


        public static string checkMember(Dictionary<string, List<string>> teams, string checkName)
        {

            foreach (var team in teams)
            {
                foreach (var member in team.Value)
                {
                    if (member == checkName)
                    {
                        return team.Key;
                    }
                }

            }
            return "-1";
        }

    }
}
