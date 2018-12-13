using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensionToPrint = int.Parse(Console.ReadLine());


            printMatrix(dimensionToPrint);
        }



        public static void printMatrix (int dimensions)
        {

            for (int i = 0; i < dimensions; i++)
            {
                for (int j = 0; j < dimensions; j++)
                {
                    Console.Write(dimensions);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


        }
    }
}
