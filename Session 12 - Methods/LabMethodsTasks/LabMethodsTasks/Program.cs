using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMethodsTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            string entryString = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            repeat(entryString, repeatCount);

        }


        public static void repeat(string entryString, int repeatCount)
        {
            for (int i = 0; i < repeatCount; i++)
            {
                Console.Write(entryString);
            }
            Console.WriteLine();

        }
    }
}
