using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesStringProcessingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] possibleUsernames = Console.ReadLine().Split(new[] { ", " },StringSplitOptions.None).ToArray();
            List<string> validUsername = new List<string>();

            foreach (var username in possibleUsernames)
            {


                if (username.Length >= 3 && username.Length <= 16)
                {
                    if (checkDigitLetters(username))
                    {
                        validUsername.Add(username);
                    }
                }
            }

            Console.WriteLine(String.Join(System.Environment.NewLine,validUsername));

        }


        public static bool checkDigitLetters(string username)
        {
            foreach(var symbol in username)
            {
                if(char.IsLetterOrDigit(symbol) || symbol == '_' || symbol == '-')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
