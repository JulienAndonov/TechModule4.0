using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int initCount = int.Parse(Console.ReadLine());
            int sum = 0;
            int testNum = 0;
            bool checkSpecial = false;
            for (int ch = 1; ch<= initCount; ch++)
            {
                testNum = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                checkSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{testNum} -> {checkSpecial}");
                sum = 0;
                ch = testNum;
            }
        }
    }
}
