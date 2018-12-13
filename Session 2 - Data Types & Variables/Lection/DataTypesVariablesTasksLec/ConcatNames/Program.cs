using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secndName = Console.ReadLine();
            string delimeter = Console.ReadLine();


            Console.WriteLine($"{firstName}{delimeter}{secndName}");



        }
    }
}
