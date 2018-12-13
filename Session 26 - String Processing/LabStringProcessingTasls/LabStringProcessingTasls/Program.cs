using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStringProcessingTasls
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }



                string reverseString = "";

                for (int i = 0; i < input.Length; i++)
                {
                    reverseString += input[input.Length - 1 - i];
                }

                input = String.Concat(input, " = ", reverseString);

                Console.WriteLine(input);
            }






        }
    }
}
