using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "-10";

            int a = number.ConvertToInteger();
            Console.WriteLine(a.AddOddNumbersFromOne());
        }
    }
}
