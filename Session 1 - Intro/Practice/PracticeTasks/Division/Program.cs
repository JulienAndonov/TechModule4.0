using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int dividor = 0;

            int[] dividers = new int[] {2,3,6,7,10};


            for (int i = dividers.Length - 1; i >= 0; i--) 
            {
                if (number % dividers[i] == 0)
                {
                    //Console.WriteLine($"The number is divisible by {dividers[i]}");
                    dividor = dividers[i];
                    break;
                }
                
            }

            if (dividor != 0)
            {
                Console.WriteLine($"The number is divisible by {dividor}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
