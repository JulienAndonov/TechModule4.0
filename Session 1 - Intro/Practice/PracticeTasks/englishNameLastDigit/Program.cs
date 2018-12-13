using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englishNameLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string lastDigit = getString(number);
            Console.WriteLine(lastDigit);
        }



        public static string getString(int number)
        {
            char[] charNumber = number.ToString().ToCharArray();

            char lastDigit = charNumber[charNumber.Length - 1];

            if (lastDigit == '0')
            {
                return "zero";
            }

            if (lastDigit == '1')
            {
                return "one";
            }
            if (lastDigit == '2')
            {
                return "two";
            }
            if (lastDigit == '3')
            {
                return "three";
            }
            if (lastDigit == '4')
            {
                return "four";
            }
            if (lastDigit == '5')
            {
                return "five";
            }
            if (lastDigit == '6')
            {
                return "six";
            }
            if (lastDigit == '7')
            {
                return "seven";
            }
            if (lastDigit == '8')
            {
                return "eight";
            }



            return "nine";
        }
    }
    
}
