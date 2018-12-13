using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjustEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> entryNums = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToList();


            for (int i = 0; i < entryNums.Count - 1; i++)
            {
                if (entryNums[i] == entryNums[i + 1])
                {
                    entryNums[i] *= 2;
                    entryNums.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",entryNums));
        }
    }
}
