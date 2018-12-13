using System;
using System.Linq;
using System.Collections.Generic;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            string firstPart = input[0];
            string scndPart = input[1];
            string thrdPart = input[2];
            string firstSubstr = "";
            int startIndex = -1;
            int endIndex = -1;
            int length = -1;

            for (int i = 0; i < firstPart.Length; i++)
            {
                char currChar = firstPart[i];
                if (currChar == '#' || currChar == '$' || currChar == '%' || currChar == '*' || currChar == '&')
                {
                    if (firstPart.IndexOf(currChar, i + 1) != -1 && i < firstPart.Length - 1)
                    {
                        startIndex = i;
                        endIndex = firstPart.IndexOf(currChar, startIndex + 1);
                        length = endIndex - startIndex;
                        firstSubstr = firstPart.Substring(startIndex + 1,length - 1);
                    }
                }
            }


            foreach(char ch in firstSubstr)
            {
                int asciiCode = (int)ch;
                int index = scndPart.IndexOf(asciiCode.ToString());
                for (int i = index; i < scndPart.Length; i++)
                {
                    
                    if (char.IsDigit(scndPart[i + 3]) && char.IsDigit(scndPart[i + 4]))
                    {
                        string wordLengthStr = scndPart.Substring(i + 3, 2);
                        int wordLength = int.Parse(wordLengthStr) + 1;
                        string[] thirdPartSbstr = thrdPart.Split(" ");
                        string word = thirdPartSbstr.Where(t => t[0] == (char)asciiCode && t.Length == wordLength).First();
                        Console.WriteLine(word);
                        break;
                    }
                    else
                    {
                        i = scndPart.IndexOf(asciiCode.ToString(),index + 1) - 1;
                    }
                }
            }
        }
    }
}
