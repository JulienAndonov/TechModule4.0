﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                sum +=i;
                Console.Write(i);
                Console.Write(' ');
            }

            Console.WriteLine();


            Console.WriteLine($"Sum: {sum}");
        }
    }
}