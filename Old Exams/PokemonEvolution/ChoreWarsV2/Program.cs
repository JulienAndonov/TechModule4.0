using System;

namespace ChoreWarsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int dishesTotalTime = 0;
            int cleaningTotalTime = 0;
            int laundryTotalTime = 0;


            while (input != "wife is happy")
            {
                if (input.Contains("<") && input.Contains(">"))
                {
                    int startIndex = input.LastIndexOf("<");
                    int endIndex = input.IndexOf(">");
                    bool isValid = false;

                    if (startIndex > endIndex)
                    {
                        for (int i = 0; i < endIndex; i++)
                        {
                            if (input[i] == '<')
                            {
                                startIndex = i;
                            }
                        }
                    }

                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        if (char.IsLower(input[i]) || char.IsDigit(input[i]))
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        for (int i = startIndex + 1; i < endIndex; i++)
                        {
                            if (char.IsDigit(input[i]))
                            {
                                int time = int.Parse(input[i].ToString());
                                dishesTotalTime += time;
                            }

                        }
                    }
                }
                else if (input.Contains("[") && input.Contains("]"))
                {
                    int startIndex = input.LastIndexOf("[");
                    int endIndex = input.IndexOf("]");
                    bool isValid = false;
                    
                    if (startIndex > endIndex)
                    {
                        for (int i = 0; i < endIndex; i++)
                        {
                            if (input[i] == '[')
                            {
                                startIndex = i;
                            }
                        }
                    }

                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        if (char.IsUpper(input[i]) || char.IsDigit(input[i]))
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        for (int i = startIndex + 1; i < endIndex; i++)
                        {
                            if (char.IsDigit(input[i]))
                            {
                                int time = int.Parse(input[i].ToString());
                                cleaningTotalTime += time;
                            }

                        }
                    }
                }
                else if (input.Contains("{") && input.Contains("}"))
                {
                    int startIndex = input.LastIndexOf("{");
                    int endIndex = input.IndexOf("}");


                    if (startIndex > endIndex)
                    {
                        for (int i = 0; i < endIndex; i++)
                        {
                            if (input[i] == '{')
                            {
                                startIndex = i;
                            }
                        }
                    }

                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        if (char.IsDigit(input[i]))
                        {
                            int time = int.Parse(input[i].ToString());
                            laundryTotalTime += time;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            int total = dishesTotalTime + cleaningTotalTime + laundryTotalTime;

            Console.WriteLine($"Doing the dishes - {dishesTotalTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTotalTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTotalTime} min.");
            Console.WriteLine($"Total - {total} min.");

        }
    }
}