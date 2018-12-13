using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabListsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entryNums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Where(x => x > 0).ToList();



            if (entryNums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                entryNums.Reverse();
                Console.WriteLine(string.Join(" ", entryNums));
            }
            
            
        }
    }
}
