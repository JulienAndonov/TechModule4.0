using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMethodsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());


            int smallestInt = getSmallestValue(numberOne, numberTwo, numberThree);

            Console.WriteLine(smallestInt);
        }

        public static int getSmallestValue(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;

            }else if (num2 < num1 && num2 < num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }







        }
    }
}