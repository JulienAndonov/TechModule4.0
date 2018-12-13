using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryPassword = Console.ReadLine();
            bool hasCharacters = checkCharacters(entryPassword);
            bool hasLettersAndDigits = checklettersAndDigits(entryPassword);
            bool hasDigits = checkDigits(entryPassword);

            if (hasDigits == true && hasLettersAndDigits == true && hasDigits == true)
            {
                Console.WriteLine("Password is valid");
            }



        }

        public static bool checkCharacters(string entryPassword)
        {
            if (entryPassword.Length < 6 || entryPassword.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }

            return true;

        }


        public static bool checklettersAndDigits(string entryPassword)
        {
            int nonLettersOrDigits = 0;

            foreach (char ch in entryPassword)
            {
                if (!((ch >= '0' && ch <= '9') || (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')))
                {
                    nonLettersOrDigits++;
                }
            }

            if (nonLettersOrDigits > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }

            return true;
        }

        public static bool checkDigits(string entryPassword)
        {
            int countDigits = 0;

            foreach (char ch in entryPassword)
            {
                if (ch >= '0' && ch <= '9')
                {
                    countDigits++;
                }
            }

            if (countDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }

            return true;

        }
            
    }
}
