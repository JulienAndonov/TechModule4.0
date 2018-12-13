using System;
using System.Collections.Generic;
using System.Linq;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> decryptedMessage = new List<string>();
            Dictionary<char, string> morseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
                                   };

            foreach (var word in words)
            {
                if (word == "|")
                {
                    decryptedMessage.Add(" ");
                }
                else
                {
                    char letter = morseAlphabetDictionary.FirstOrDefault(x => x.Value == word).Key;
                    decryptedMessage.Add(letter.ToString().ToUpper());
                }

            }
            Console.WriteLine(String.Join("",decryptedMessage));
        }
    }
}
