using System;
using System.Text.RegularExpressions;

namespace ChoreWarsRegex
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int dishesTime = 0;
            int cleaningTime = 0;
            int laundryTime = 0;

            string dishesPattern = @"(?<=\<)[a-z0-9]+(?=\>)";
            string houseCleanPattern = @"(?<=\[)[A-Z0-9]+(?=\])";
            string laundryPattern = @"(?<=\{)[^]]+(?=\})";


            while (input != "wife is happy")
            {
                if (input.Contains("<") && input.Contains(">"))
                {
                    dishesTime += getTime(input, dishesPattern);

                }
                else if (input.Contains("[") && input.Contains("]"))
                {
                    cleaningTime += getTime(input, houseCleanPattern);
                }
                else if (input.Contains("{") && input.Contains("}"))
                {
                    laundryTime += getTime(input, laundryPattern);
                }
                input = Console.ReadLine();
            }

            int totalTime = dishesTime + cleaningTime + laundryTime;

            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine($"Total - {totalTime} min.");

        }


        public static int getTime(string input, string pattern)
        {
            int digit = 0;
            Match busStr = Regex.Match(input, pattern);

            if (busStr.Success)
            {
                foreach (var chr in busStr.ToString())
                {
                    if (char.IsDigit(chr))
                    {
                        digit += chr - '0';
                    }
                }
            }
            return digit;
        }
    }
}
