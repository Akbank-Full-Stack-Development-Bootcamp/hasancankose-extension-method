using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionMethods.Extensions
{
    public static class Extension
    {
        // Converts a string to an array of its ascii codes.
        public static int[] ConvertToAscii(this string text)
        {
            List<int> asciiNumbers = new List<int>();

            foreach (char c in text)
            {
                asciiNumbers.Add(Convert.ToInt32(c));
            }

            return asciiNumbers.ToArray();
        }

        //Adds all numbers starting from zero to given number(including negative numbers)
        public static int AddFromOne(this int number)
        {
            int result = 0;
            int i;

            if (number > 0)
            {
                for (i = 0; i < number + 1; i++)
                {
                    result += i;
                }
            }
            else
            {
                for (i = 0; i > number - 1; i--)
                {
                    result += i;
                }
            }
            return result;
        }

        //Adds even numbers starting from zero to given number(including negative numbers)
        public static int AddEvenNumbersFromOne(this int number)
        {
            int result = 0;
            int i;

            if (number > 0)
            {
                for (i = 0; i < number + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                for (i = 0; i > number - 1; i--)
                {
                    if (i % 2 == 0)
                    {
                        result += i;
                    }
                }
            }
            return result;
        }

        //Adds odd numbers starting from zero to given number(including negative numbers)
        public static int AddOddNumbersFromOne(this int number)
        {
            int result = 0;
            int i;

            if (number > 0)
            {
                for (i = 0; i < number + 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                for (i = 0; i > number - 1; i--)
                {
                    if (i % 2 != 0)
                    {
                        result += i;
                    }
                }
            }
            return result;
        }

        //Converts a string type number to an integer type number(including negative numbers)
        public static int ConvertToInteger(this string number)
        {
            return int.Parse(number, NumberStyles.AllowLeadingSign);
        }
    }
}
