using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryString = Console.ReadLine();


            int numOfVowels = getVowels(entryString);


            Console.WriteLine(numOfVowels);

        }



        public static int getVowels(string entryString)
        {

            int numOfVowels = 0;

            entryString = entryString.ToLower();
            char[] vowels = {'a', 'u', 'e', 'i', 'o',};

            foreach (char ch in entryString)
            {
                if (vowels.Contains(ch))
                {
                    numOfVowels++;
                }
            }

            return numOfVowels;


        }
    }
}
