using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionMethods.Extensions
{
    public static class Extension
    {

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
        public static int ConvertToInteger(this string number)
        {
            return int.Parse(number, NumberStyles.AllowLeadingSign);
        }
    }
}
