using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entryNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            for (int i = 0; i < entryNumbers.Count/2; i++)
            {
                entryNumbers[i] += entryNumbers[entryNumbers.Count - 1 - i];
            }


            if (entryNumbers.Count % 2 != 0)
            {
                entryNumbers.RemoveRange(entryNumbers.Count / 2 + 1, entryNumbers.Count / 2);
            }
            else
            {
                entryNumbers.RemoveRange(entryNumbers.Count / 2, entryNumbers.Count/2);
            }

            


            Console.WriteLine(String.Join(" ",entryNumbers));

            





        }
    }
}
