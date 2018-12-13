using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();



            while (true)
            {
                if (input == "Lumpawaroo")
                {
                    break;
                }


                if (input.Contains("|"))
                {
                    List<string> entries = input.Split('|').Select(x => x.Trim()).ToList();

                    string side = entries[0];
                    string name = entries[1];

                    if (!forceUsers.ContainsKey(side))
                    {
                        forceUsers[side] = new List<string>();
                    }

                    if (!forceUsers[side].Contains(name))
                    {
                        forceUsers[side].Add(name);
                    }
                }

                if (input.Contains("->"))
                {
                    List<string> entries = input.Split(new[] { "->" }, StringSplitOptions.None).Select(x => x.Trim()).ToList();


                    string name = entries[0];
                    string oldSide = getOldSide(name, forceUsers);
                    string newSide = entries[1];

                    if (!forceUsers.ContainsKey(newSide.ToLower()))
                    {
                        forceUsers[newSide.ToLower()] = new List<string>();
                    }

                    if (!forceUsers[newSide].Contains(name.ToLower()))
                    {
                        forceUsers[newSide.ToLower()].Add(name);
                        Console.WriteLine($"{name} joins the {newSide} side!");

                        try
                        {
                            forceUsers[oldSide].Remove(name);
                        }
                        catch (KeyNotFoundException ex)
                        {
                        }
                    }
                }
                input = Console.ReadLine();
            }

            forceUsers = forceUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(kvp => kvp.Key,kvp => kvp.Value);
            


            foreach (var forceUser in forceUsers)
            {
                if (forceUser.Value.Count > 0)
                {
                    List<string> users = forceUser.Value.OrderBy(x => x).ToList();
                    Console.WriteLine($"Side: {forceUser.Key}, Members: {forceUser.Value.Count}");
                    foreach (var user in users)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }


        public static string getOldSide(string name, Dictionary<string, List<string>> forceUsers)
        {
            foreach (var forceUser in forceUsers)
            {
                if (forceUser.Value.Contains(name))
                {
                    return forceUser.Key;
                }
            }
            return "noSide";
        }
    }
}
