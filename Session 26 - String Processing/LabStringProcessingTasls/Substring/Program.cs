using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string inputString = Console.ReadLine().ToLower();
            StringBuilder sw = new StringBuilder();

            


            for (int i = 0; i < inputString.Length; i++)
            {
                int indexOfRemove = inputString.IndexOf(stringToRemove.ToLower());
                if(indexOfRemove != -1)
                {
                    inputString = inputString.Remove(indexOfRemove, stringToRemove.Count());
                }
                
            }



            Console.WriteLine(inputString);

        }
    }
}
