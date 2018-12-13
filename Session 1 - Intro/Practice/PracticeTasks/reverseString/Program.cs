using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] straightArray = input.ToCharArray();
            Array.Reverse(straightArray);

            Console.WriteLine(String.Join("",straightArray));


        }
    }
}
