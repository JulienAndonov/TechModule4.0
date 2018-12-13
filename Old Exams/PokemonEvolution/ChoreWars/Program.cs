using System;

namespace ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int dishesTime = 0;
            int cleaningHouseTime = 0;
            int laundryTime = 0;

            while (true)
            {

                if (input == "wife is happy")
                {
                    break;
                }

                if (input.Contains('<') && input.Contains('>'))
                {
                    string dishesSubtr = getSubtr(input, '<', '>');
                    bool isValid = true;
                    char[] inputToChar = input.ToCharArray();

                    foreach (char ch in dishesSubtr)
                    {
                        if (!((ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9')))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        foreach (char ch in dishesSubtr)
                        {
                            if (Char.IsDigit(ch))
                            {
                                dishesTime += ch - '0';
                            }
                        }
                    }
                }

                if (input.Contains('[') && input.Contains(']'))
                {
                    string cleaningSubtr = getSubtr(input, '[', ']');
                    bool isValid = true;
                    char[] inputToChar = input.ToCharArray();

                    foreach (char ch in cleaningSubtr)
                    {
                        if (!((ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9')))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        foreach (char ch in cleaningSubtr)
                        {
                            if (Char.IsDigit(ch))
                            {
                                cleaningHouseTime += ch - '0';
                            }
                        }
                    }
                }

                if (input.Contains('{') && input.Contains('}'))
                {
                    string laundrySubtr = getSubtr(input, '{', '}');

                    foreach (char ch in laundrySubtr)
                    {
                        if (Char.IsDigit(ch))
                        {
                            laundryTime += ch - '0';
                        }
                    }

                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the hous - {cleaningHouseTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
        }


        public static string getSubtr(string input, char beginChar, char endChar)
        {
            string substr = input.Split(beginChar, endChar)[1];

            if(substr.Contains(beginChar) || substr.Contains(endChar))
            {
                getSubtr(substr, beginChar, endChar);
            }
            return substr;
        }
    }
}
