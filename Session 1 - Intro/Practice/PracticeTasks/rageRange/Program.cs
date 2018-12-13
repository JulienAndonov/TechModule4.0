using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rageRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal dispalyPrice = decimal.Parse(Console.ReadLine());
            int counter = 1;

            decimal damage = 0;



            for (int i = 1; i < lostGames+1; i++)
            {
                if (i % 2 == 0)
                {
                    damage += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    damage += mousePrice;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    damage += keyboardPrice;
                    counter++;
                }

                if (counter % 3 == 0)
                {
                    damage += dispalyPrice;
                    counter = 1;
                }
            }


            Console.WriteLine($"Rage expenses: {damage:F2} lv.");



        }
    }
}
