using System;

namespace Task01
{
    public class Program
    {
        private const string Message = "Please, enter a number greater then 0 and lower than 20:";
        private const string WrongNumber = "Wrong number!";

        public static void Main()
        {
            Console.WriteLine(Message);
            string input = Console.ReadLine();

            int number = -1;

            while (!Validator.IsPositiveNumber(input) || (number = int.Parse(input)) >= 20)
            {
                Console.WriteLine(WrongNumber);
                Console.WriteLine(Message);
                input = Console.ReadLine();
            }

            string result = "";

            for (int i = 0; i < number; i++)
            {                
                result = result + (i + 1).ToString() + result;
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }        
    }
}
