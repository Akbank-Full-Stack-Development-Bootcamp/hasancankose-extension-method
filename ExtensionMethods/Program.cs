using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "-10";

            int convertedNumber = number.ConvertToInteger();
            Console.WriteLine(convertedNumber.AddOddNumbersFromOne());

            string text = "Hasan";

            int[] numbers = text.ConvertToAscii();

            foreach(int num in numbers)
            {
                Console.WriteLine(num);

            }
        }
    }
}
