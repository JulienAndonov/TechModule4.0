using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleLatingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int starter = int.Parse(Console.ReadLine());


            for (int i = 0; i < starter; i++)
            {
                for (int j = 0; j < starter; j++)
                {
                    for (int k = 0; k < starter; k++)
                    {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + j));
                        Console.Write((char)('a' + k));
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
