using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> entryNums = Console.ReadLine().Split(new string[] {"|"},StringSplitOptions.RemoveEmptyEntries).ToList();


            List<int> result = new List<int>();

            for (int i = entryNums.Count - 1; i >= 0; i--)
            {
                result.AddRange(entryNums[i].Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList());
            }

            Console.WriteLine(string.Join(" ",result));

        }
    }
}
