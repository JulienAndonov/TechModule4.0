using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDigitsOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder specials = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {

                char charInspect = inputText[i];

                if (char.IsDigit(charInspect))
                {
                    digits.Append(charInspect);
                }
                else if (char.IsLetter(charInspect))
                {
                    letters.Append(charInspect);
                }
                else
                {
                    specials.Append(charInspect);
                }
            }


            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(specials.ToString());

        }
    }
}
