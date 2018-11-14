using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    public static class Validator
    {
        public static bool IsPositiveNumber(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            char[] characters = input.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] < '0' || characters[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
