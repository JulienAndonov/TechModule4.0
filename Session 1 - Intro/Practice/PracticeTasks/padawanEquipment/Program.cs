using System;
using System.Collections.Generic;
using System.Linq;

namespace padawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightSaber = decimal.Parse(Console.ReadLine());
            decimal robe = decimal.Parse(Console.ReadLine());
            decimal belt = decimal.Parse(Console.ReadLine());

            decimal lightsabersPrice = lightSaber * Math.Ceiling((decimal)students + ((decimal)(10*students)/100));
            decimal robePrice = students * robe;
            decimal beltPrice = belt * (students - (int) (students / 6));


            decimal total = lightsabersPrice + robePrice + beltPrice;

            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - money:F2}lv more.");
            }
        }
    }
}
