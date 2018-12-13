using System;
using System.Linq;
using System.Text;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            int sumSubstract = Sum(num1, num2, num3);

            Console.WriteLine(sumSubstract);
        }


        public static int Sum(int num1, int num2, int num3)
        {
            int sum = num1 + num2;

            return sum - num3;



        }
    }
}
