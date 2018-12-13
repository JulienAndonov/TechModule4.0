using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());



            int turns = (int) Math.Ceiling((double)totalPeople / capacity);


            Console.WriteLine(turns);
        }
    }
}
