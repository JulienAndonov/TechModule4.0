using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryText = Console.ReadLine();


            printMiddleCharacters(entryText);
        }



        public static void printMiddleCharacters(string entryText)
        {
            int middleLength = entryText.Length / 2;


            if (entryText.Length % 2 == 0)
            {
                for (int i = middleLength - 1; i <= middleLength; i++)
                {
                    Console.Write(entryText[i]);
                }
            }
            else
            {
                Console.WriteLine(entryText[middleLength]);
            }

            Console.WriteLine();



        }
    }
}
