using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplTablev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplNumber = int.Parse(Console.ReadLine());
            int multiplactor = int.Parse(Console.ReadLine());



            for (int i = multiplactor; i < 11; i++)
            {
                Console.WriteLine($"{multiplNumber} X {i} = {multiplNumber * i}");
            }


            if (multiplactor > 10)
            {
                Console.WriteLine($"{multiplNumber} X {multiplactor} = {multiplNumber * multiplactor}");

            }
        }
    }
}
