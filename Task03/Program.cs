using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task03
{
    public class Program
    {
        private static int num = 0;

        public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            num = int.Parse(Console.ReadLine());
            var result = new StringBuilder();
            var wordIsAdded = false;

            var word = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];

                if (IsWordSymbol(symbol))
                {
                    word.Add(symbol);

                    wordIsAdded = false;
                }
                else
                {
                    // if current character is not a letter this is the end of word
                    // and word we must rotate the word and add it to the result

                    if (!wordIsAdded && word.Count > 0)
                    {
                        var rotated = RotateWord(word);

                        result.Append(rotated + symbol);

                        word.Clear();

                        wordIsAdded = true;
                    }
                    else
                    {
                        // just add character to result if we have more then one non-letter character
                        result.Append(symbol);
                    }
                }
            }

            if (!wordIsAdded)
            {
                var rotated = RotateWord(word);

                result.Append(rotated);
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static bool IsWordSymbol(char ch)
        {
            if (char.IsLetter(ch) || ch == '-')
            {
                return true;
            }

            return false;
        }

        private static string RotateWord(List<char> word)
        {
            if (word.Count == 1)
            {
                return word[0].ToString();
            }

            // for optimizing count of loops
            int count = word.Count < num ? num % word.Count : num;
            
            for (int i = 0; i < count; i++)
            {                
                var lastSymbol = word.Last();                
                var temp = word.SkipLast(1).ToArray();

                word.Clear();

                word.Add(lastSymbol);
                word.AddRange(temp);                
            }

            return string.Join("", word);
        }
    }
}
