using System;

namespace PhoneNoFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes an array of 10 numbers (between 0 and 9) and returns a string of those numbers formatted as a phone number (xxx) xxx-xxxx)");

            int[] numbers = new int [10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Method 1
            //string phoneNumber = String.Format("{0:(###) ###-####)}", Numbers);
            //Console.WriteLine(phoneNumber);

            //Method 2
            string numbersString = String.Join(",",numbers);
            string phoneFormat = "";

            if (numbersString.Length > 0)
            {
                phoneFormat += "(";
                int n = 1;
                foreach (char c in numbersString)
                {
                    phoneFormat += c;
                    if (n == 3)
                    {
                        phoneFormat += ")";
                    }
                    else if (n == 6)
                    {
                        phoneFormat += "-";
                    }
                }
            }
            Console.WriteLine(phoneFormat);


            Console.ReadKey();
        }
    }
}
