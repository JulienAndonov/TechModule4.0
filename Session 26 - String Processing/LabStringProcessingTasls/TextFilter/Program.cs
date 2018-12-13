using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] inputText = Console.ReadLine().Split();


            StringBuilder sb = new StringBuilder();



            foreach (var word in inputText)
            {
                sb.Append(word);
                sb.Append(" ");
            }

            foreach(var bannedWord in bannedWords)
            {
                sb.Replace(bannedWord, new string('*', bannedWord.Length));
            }


            Console.WriteLine(sb.ToString());







        }
    }
}
