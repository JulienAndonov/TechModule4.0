using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            List<int> secondList = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();


            List<int> resultList = new List<int>();

            int min = Math.Min(firstList.Count, secondList.Count);
            int max = Math.Max(firstList.Count, secondList.Count);


            for (int i = 0; i < min; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }


            if (firstList.Count > secondList.Count)
            {
                for (int i = min; i < firstList.Count; i++)
                {
                    resultList.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = min; i < secondList.Count; i++)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ",resultList));

        }
    }
}
