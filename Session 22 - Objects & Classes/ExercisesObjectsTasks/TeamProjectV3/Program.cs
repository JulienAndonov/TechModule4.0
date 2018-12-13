using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectV3
{

    class Team
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }


        public Team(string name, string creatorName)
        {
            this.Name = name;
            this.CreatorName = creatorName;
            this.Members = new List<string>();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] splittedInput = Console.ReadLine().Split('-');


                string creatorName = splittedInput[0];
                string teamName = splittedInput[1];

                bool isTeamNameExists = teams.Any(x => x.Name == teamName);
                bool isCreatorNameExists = teams.Any(x => x.CreatorName == creatorName);

                if (isTeamNameExists == false && isCreatorNameExists == false)
                {
                    Team team = new Team(teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (isTeamNameExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorNameExists)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();


                if (input == "end of assignment")
                {
                    break;
                }


                string[] splittedInput = input.
                    Split(new[] { "->" }, StringSplitOptions.None);



                string user = splittedInput[0];
                string teamName = splittedInput[1];



                bool isTeamExists = teams.Any(x => x.Name == teamName);
                bool isAlreadymember = teams.Any(x => x.Members.Contains(user) || x.CreatorName == user);



                if (isTeamExists == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (isAlreadymember)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }


                if (isTeamExists && !isAlreadymember)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == teamName);
                    teams[indexOfTeam].Members.Add(user);
                    continue;
                }

            }

            List<Team> teamWithmembers = teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count()).ThenBy(x => x.Name).ToList();

            List<Team> teamWithoutmembers = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).ToList();


            foreach (var team in teamWithmembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.CreatorName);
                Console.WriteLine(String.Join(System.Environment.NewLine, team.Members.Select(x => $"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamWithoutmembers)
            {
                Console.WriteLine(team.Name);
            }



        }
    }
}
