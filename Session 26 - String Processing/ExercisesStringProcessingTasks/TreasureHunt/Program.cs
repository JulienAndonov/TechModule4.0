using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            List<string> decryptedMessage = new List<string>();
            List<string> encrypterMessages = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find")
                {
                    break;
                }
                encrypterMessages.Add(input);
            }

            foreach (var message in encrypterMessages)
            {
                string decryptedWord = "";
                for (int i = 0; i < message.Length; i++)
                {
                    char outputChar = (char)((int)message[i] - keys[i % keys.Length]);
                    decryptedWord += outputChar;
                }
                decryptedMessage.Add(decryptedWord);
            }

            foreach (var message in decryptedMessage)
            {
                string type = message.Split('&')[1];
                string coordinates = message.Split('<', '>')[1];
                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
