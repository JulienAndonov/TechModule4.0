using System;

namespace BakingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budet = decimal.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            decimal priceFlourPackage = decimal.Parse(Console.ReadLine());
            decimal priceEgg = decimal.Parse(Console.ReadLine());
            decimal priceApron = decimal.Parse(Console.ReadLine());
            int freePackages = studentCount / 5;
            decimal totalPrice = 0;
            int bonusAprons = (int)Math.Ceiling((decimal)(20 * studentCount)/100);


            int totalApron = studentCount + bonusAprons;


            decimal priceForProducts = (priceApron * totalApron) + (priceEgg * 10 * studentCount) + (priceFlourPackage * (studentCount - freePackages));


            if (priceForProducts <= budet)
            {
                Console.WriteLine($"Items purchased for {priceForProducts:F2}$.");

            }
            else
            {
                decimal difference = priceForProducts - budet;
                Console.WriteLine($"{difference:F2}$ more needed.");
            }

        }
    }
}
