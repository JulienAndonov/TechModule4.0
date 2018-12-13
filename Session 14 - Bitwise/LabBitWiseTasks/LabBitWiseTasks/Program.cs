using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBitWiseTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToConvert = int.Parse(Console.ReadLine());
            int numberToSearch = int.Parse(Console.ReadLine());
            int result = 0;


            string stringNumber = Convert.ToString(numberToConvert, 2);


            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (stringNumber[i].ToString() == numberToSearch.ToString())
                {
                    result++;
                }
            }


            Console.WriteLine(result);
        }
    }
}
