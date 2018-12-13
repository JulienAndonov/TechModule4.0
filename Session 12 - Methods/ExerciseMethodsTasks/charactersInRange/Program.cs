using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char charStart = char.Parse(Console.ReadLine());
            char charEnd = char.Parse(Console.ReadLine());

            printRange(charStart, charEnd);
        }

        public static void printRange(char charStart, char charEnd)
        {
            char startChar = (char)Math.Min((int)charStart, (int)charEnd);
            char endChar = (char)Math.Max((int)charStart, (int)charEnd);



            for (char ch = (char)(startChar+1); ch < endChar; ch++)
            {
                Console.Write(ch);
                Console.Write(" ");
            }

            Console.WriteLine();

        }
    }
}
