using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOddNum = int.Parse(Console.ReadLine());
            int odd = 1;
            int sum = 0;
            int counter = 0;

            do
            {
                sum += odd;
                Console.WriteLine(odd);
                odd += 2;
                counter++;

            } while (counter < countOddNum);


            Console.WriteLine($"Sum: {sum}");


        }
    }
}
