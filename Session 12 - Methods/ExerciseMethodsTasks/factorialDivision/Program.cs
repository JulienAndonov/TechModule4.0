using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            int factorialNum1 = getFactorial(num1);
            int factorialNum2 = getFactorial(num2);


            double division = factorialNum1 / factorialNum2;


            Console.WriteLine($"{division:F2}");
            
        }


        public static int getFactorial(int number)
        {
            int factorial = 1;


            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;

        }
    }
}
