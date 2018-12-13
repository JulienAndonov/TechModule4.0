using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToConvert = int.Parse(Console.ReadLine());
            char[] binaryEntryNumber = Convert.ToString(numToConvert, 2).ToCharArray();
            Array.Reverse(binaryEntryNumber);
            Console.WriteLine(binaryEntryNumber[1].ToString());
        }
    }
}
