using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Learning_Stuff
{
    public class Translator
    {
        public static Dictionary<char, string> _morseAlphabetDictionary;

        public static void InitializeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<char, string>()
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
        }

        public static string GetUserInput()
        {
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                input = input.ToLower();
            }

            return input;
        }

        public static string Translate(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char character in input)
            {
                if (_morseAlphabetDictionary.ContainsKey(character))
                {
                    stringBuilder.Append(_morseAlphabetDictionary[character] + " ");
                }
                else if (character == ' ')
                {
                    stringBuilder.Append("/ ");
                }
                else
                {
                    stringBuilder.Append(character + " ");
                }
            }

            return stringBuilder.ToString();
        }
    }
}
