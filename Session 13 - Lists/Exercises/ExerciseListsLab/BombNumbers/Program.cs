using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entryNums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            List<int> tokens = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();



            int searchedValue = tokens[0];
            int blastRange = tokens[1];


            for (int i = 0; i < entryNums.Count; i++)
            {

                if (entryNums.Contains(searchedValue))
                {


                    int index = entryNums.IndexOf(searchedValue);
                    int start = 0;
                    int end = 0;

                    if (index - blastRange < 0)
                    {
                        start = 0;

                    }
                    else
                    {
                        start = index - blastRange;
                    }



                    if (index + blastRange > entryNums.Count - 1)
                    {
                        end = entryNums.Count - 1;
                    }
                    else
                    {
                        end = index + blastRange;
                    }

                    entryNums.RemoveRange(start, end - start + 1);

                }

            }
            Console.WriteLine(entryNums.Sum());
        }
    }
}
