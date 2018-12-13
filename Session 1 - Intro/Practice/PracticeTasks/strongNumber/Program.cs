using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace strongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayChars = Console.ReadLine().ToCharArray();

            int[] arrayNumbers = new int[arrayChars.Length];

            int sumFact = 1;
            int sumTotal = 0;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = int.Parse(arrayChars[i].ToString());
            }



            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = 1; j <= arrayNumbers[i]; j++)
                {
                    sumFact *= j;
                }

                sumTotal += sumFact;
                sumFact = 1;

            }

            string numberString = string.Join("", arrayChars);

            if (numberString == sumTotal.ToString())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
