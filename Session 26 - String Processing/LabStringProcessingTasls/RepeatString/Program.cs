using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputValues = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();


            foreach (var value in inputValues)
            {
                int lenght = value.Length;

                for (int i = 0; i < lenght; i++)
                {
                    sb.Append(value);
                }
            }


            Console.WriteLine(sb.ToString());

        }
    }
}
