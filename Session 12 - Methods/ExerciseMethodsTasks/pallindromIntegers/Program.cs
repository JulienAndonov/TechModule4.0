using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pallindromIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryNumber = Console.ReadLine();



            while (true)
            {

                if (entryNumber == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(checkPallindrom(entryNumber).ToString().ToLower());
                }
                entryNumber = Console.ReadLine();
            }
        }

        public static bool checkPallindrom(string checkString)
        {
            int length = checkString.Length;
            int count = 0;


            for (int i = 0; i < length/2; i++)
            {
                if (checkString[i] == checkString[length - 1 - i])
                {
                    count++;
                }
            }


            if (count == length / 2)
            {
                return true;
            }

            return false;
        }
    }
}
