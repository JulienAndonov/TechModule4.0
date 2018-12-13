using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] entryString = Console.ReadLine().Split();

            string stringOne = entryString[0];
            string stringTwo = entryString[1];
            int sum = 0;

            int minLength = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                int intCharOne = (int)stringOne[i];
                int intCharTwo = (int)stringTwo[i];
                int multiplier = intCharOne * intCharTwo;
                sum += multiplier;
            }



            if (stringOne.Length > stringTwo.Length)
            {
                for (int i = minLength; i < stringOne.Length; i++)
                {
                    sum += (int) stringOne[i];
                }
            }
            else
            {
                for (int i = minLength; i < stringTwo.Length; i++)
                {
                    sum += (int)stringTwo[i];
                }
            }


            Console.WriteLine(sum);


        }
    }
}