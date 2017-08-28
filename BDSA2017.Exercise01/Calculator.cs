using System;

namespace BDSA2017.Exercise01
{
    public class Calculator
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                throw new ArgumentException("Year must be greater than 1582", nameof(year));
            }
            if (year > 9999)
            {
                throw new ArgumentException("Year must less than 10000", nameof(year));
            }
            if (year % 4 != 0)
            {
                return false;
            }
            if (year % 100 != 0)
            {
                return true;
            }
            if (year % 400 != 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsPowerOf(int number, int power)
        {
            throw new NotImplementedException();
        }
    }
}
