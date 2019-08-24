using System;

namespace PhoneNoFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes an array of 10 numbers (between 0 and 9) and returns a string of those numbers formatted as a phone number (xxx) xxx-xxxx)");

            int[] numbers = new int [10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            string phoneNumberInFormat = "(";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 3)
                    phoneNumberInFormat += ") ";
                else if (i == 6)
                    phoneNumberInFormat += "-";

                phoneNumberInFormat += numbers[i];
            }

            Console.WriteLine(phoneNumberInFormat);

            Console.ReadKey();
        }
    }
}
