using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDown = int.Parse(Console.ReadLine());
            


            for (int i = 1; i < countDown + 1; i++)
            {
                int sum = 0;
                int number = i;

                for (int j = 0; j < i.ToString().Length; j++)
                {
                    sum += number % 10;
                    number = number / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }



        }
    }
}
