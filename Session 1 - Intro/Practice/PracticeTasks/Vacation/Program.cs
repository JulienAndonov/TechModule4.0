using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string dayOfStay = Console.ReadLine();

            double totalPrice = 0;

            if (peopleType == "Students")
            {
                if (dayOfStay == "Friday")
                {
                    totalPrice = 8.45 * peopleCount;
                }
                else if (dayOfStay == "Saturday")
                {
                    totalPrice = 9.80 * peopleCount;
                }
                else if (dayOfStay == "Sunday")
                {
                    totalPrice = 10.46 * peopleCount;
                }

                if (peopleCount >= 30)
                {
                    totalPrice = totalPrice - ((15 * totalPrice) / 100);
                }
            }
            else if (peopleType == "Business")
            {
                if (peopleCount >= 100)
                {
                    peopleCount = peopleCount - 10;
                }
                if (dayOfStay == "Friday")
                {
                    totalPrice = 10.90 * peopleCount;
                }
                else if (dayOfStay == "Saturday")
                {
                    totalPrice = 15.60 * peopleCount;
                }
                else if (dayOfStay == "Sunday")
                {
                    totalPrice = 16 * peopleCount;
                }
            }
            else if (peopleType == "Regular")
            {
                if (dayOfStay == "Friday")
                {
                    totalPrice = 15 * peopleCount;
                }
                else if (dayOfStay == "Saturday")
                {
                    totalPrice = 20 * peopleCount;
                }
                else if (dayOfStay == "Sunday")
                {
                    totalPrice = 22.50 * peopleCount;
                }

                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice = totalPrice - ((5 * totalPrice) / 100);
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
