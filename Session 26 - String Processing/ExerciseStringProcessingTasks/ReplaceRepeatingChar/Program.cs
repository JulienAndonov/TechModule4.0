using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryString = Console.ReadLine();
            int start = 0;
            int end = 0;

            for (int i = 0; i < entryString.Length - 1; i++)
            {
                start = i;
                for (int j = i + 1; j < entryString.Length; j++)
                {
                    if (entryString[i] == entryString[j])
                    {
                        if (j > end)
                        {
                            end = j;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (start != -1 && end != -1)
                {
                    entryString = entryString.Remove(start, end - start);
                    start = -1;
                    end = -1;
                }
            }


            Console.WriteLine(entryString);
        }
    }
}
