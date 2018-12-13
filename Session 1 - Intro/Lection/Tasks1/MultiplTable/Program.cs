using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplNumber = int.Parse(Console.ReadLine());


            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{multiplNumber} X {i} = {multiplNumber * i}" );
            }
        }
    }
}
