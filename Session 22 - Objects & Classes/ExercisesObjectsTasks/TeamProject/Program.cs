using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Team
    {
        public string TeamCreator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }



        public void addMember(string newMember)
        {
            Members.Add(newMember);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int numberOfTeams = int.Parse(Console.ReadLine());
            DateTime dateStart = DateTime.Now;

            for (int i = 0; i < numberOfTeams; i++)
            {

               List<string> instructions = Console.ReadLine().Split(new[] { "-" }, StringSplitOptions.None).ToList();
                string teamCreator = instructions[0];
                string teamName = instructions[1];
                if (!checkExists(teams, teamName))
                {
                    teams.Add(new Team()
                    {
                        TeamCreator = teamCreator,
                        TeamName = teamName,
                        Members = new List<string>()
                    });
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

            }


            string participationInstructions = Console.ReadLine();

            while (true)
            {
                if (participationInstructions == "end of assignment")
                {
                    break;
                }

                List<string> commands = participationInstructions.Split(new[] { "->" }, StringSplitOptions.None).ToList();


                string nameOfMember = commands[0];
                string nameOfTheTeam = commands[1];
                int indexOfTeam = IndexOfTeam(teams, nameOfTheTeam);

                if (indexOfTeam == -1)
                {
                    Console.WriteLine($"Team {nameOfTheTeam} does not exist!");
                }
                else
                {
                    if (!ExistInotherteam(teams, nameOfMember))
                    {
                        teams[indexOfTeam].addMember(nameOfMember);
                    }
                    else
                    {
                        Console.WriteLine($"Member {nameOfMember} cannot join team {nameOfTheTeam}");
                    }
                }
                participationInstructions = Console.ReadLine();
            }
            DateTime dateEnd = DateTime.Now;
            Console.WriteLine(dateEnd - dateStart);

        }


        public static bool checkExists(List<Team> teams, string checkName)
        {
            foreach (var team in teams)
            {
                if (team.TeamName == checkName)
                {
                    return true;
                }
            }
            return false;
        }



        public static int IndexOfTeam(List<Team> teams, string nameOfTheTeam)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].TeamName == nameOfTheTeam)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool ExistInotherteam(List<Team> teams, string checkName)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Contains(checkName))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
