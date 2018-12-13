using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int topRange = int.Parse(Console.ReadLine());


            for (int i = 1; i <= topRange; i++)
            {
                if (checkTop(i))
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static bool checkTop(int number)
        {
            int sum = 0;
            bool oddDigit = false;
            char[] numToChar = number.ToString().ToCharArray();



            for (int i = 0; i < numToChar.Length; i++)
            {
                sum += int.Parse(numToChar[i].ToString());
                if ((int) (numToChar[i] - '0') % 2 != 0)
                {
                    oddDigit = true;
                }
            }


            if (sum % 8 == 0)
            {
                if (oddDigit)
                {
                    return true;
                }
            }


            return false;
        }
    }
}
