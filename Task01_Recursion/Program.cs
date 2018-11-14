using System;

namespace Task01_Recursion
{
    public class Program
    {
        private const string Message = "Please, enter a number greater then 0 and lower than 20:";
        private const string WrongNumber = "Wrong number!";
        private static int number = -1;
        private static string result = "";

        public static void Main()
        {
            Console.WriteLine(Message);
            string input = Console.ReadLine();
            
            while (!Validator.IsPositiveNumber(input) || (number = int.Parse(input)) >= 20)
            {
                Console.WriteLine(WrongNumber);
                Console.WriteLine(Message);
                input = Console.ReadLine();
            }
            
            GenerateElement(1);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static int GenerateElement(int element)
        {
            if (element > number)
            {
                return 0;
            }

            result = result + element.ToString() + result;

            return GenerateElement(element + 1);
        }
    }
}
