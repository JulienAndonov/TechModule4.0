using System;

namespace ChoreWarsV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int dishesTotalTime = 0;

            while (true)
            {
                if (input == "wife is happy")
                {
                    break;
                }

                if (input.Contains("<") && input.Contains(">"))
                {
                    int startIndex = input.IndexOf("<");
                    int currentTime = 0;
                    bool isValid = false;
                    int endIndex = input.IndexOf(">");

                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        if (input[i] == '<')
                        {

                            startIndex = i;
                        }
                    }

                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        if (char.IsDigit(input[i]) || char.IsLower(input[i]))
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    
                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        if (isValid)
                        {
                            if (char.IsDigit(input[i]))
                            {
                                string digit = input[i].ToString();
                                currentTime += int.Parse(digit);
                            }
                        }
                    }

                    dishesTotalTime += currentTime;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(dishesTotalTime);
        }
    }
}
