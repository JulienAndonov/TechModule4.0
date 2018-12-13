using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalText = Console.ReadLine();
            StringBuilder sb = new StringBuilder();



            for (int i = 0; i < originalText.Length; i++)
            {
                int originalCharacter = (int)originalText[i];
                originalCharacter += 3;
                char nextCharacter = (char)originalCharacter;
                sb.Append(nextCharacter);
            }

            Console.WriteLine(sb.ToString());



        }
    }
}
