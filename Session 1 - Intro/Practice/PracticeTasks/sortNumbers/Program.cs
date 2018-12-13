using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            int[] arrayNumbers = new int[] {num1,num2,num3};


            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = i; j < arrayNumbers.Length; j++)
                {
                    if (arrayNumbers[i] >= arrayNumbers[j])
                    {
                        int temp = arrayNumbers[j];
                        arrayNumbers[j] = arrayNumbers[i];
                        arrayNumbers[i] = temp;
                    }
                }
            }

            for (int i = arrayNumbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayNumbers[i]);
            }




        }
    }
}
