using System;
using System.Text;

namespace Decipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedText = Console.ReadLine();
            string[] tokens = Console.ReadLine().Split(" ");
            StringBuilder decryptedText = new StringBuilder();


            var match = encryptedText.IndexOfAny(new char[] { 'a', 'b', 'c' });

            if (match != -1)
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            else
            {
                foreach (char letter in encryptedText)
                {
                    char decrypterChar = (char)((int)letter - 3);
                    decryptedText.Append(decrypterChar);
                }

                string firstToken = tokens[0];
                string secondToken = tokens[1];
                decryptedText.Replace(firstToken, secondToken);
                Console.WriteLine(decryptedText.ToString());
                
            }


        }
    }
}
