using System;
using System.Globalization;

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
            return (year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0);
         

        }
        public static bool IsFrameworkLeapYear(int year)
        {
            GregorianCalendar myGreCal = new GregorianCalendar();
            return myGreCal.IsLeapYear(year);
        }

        public static bool IsPowerOf(int number, int power)
        {
            return PowerOf(number, power, power);
        }
        public static bool PowerOf(int number, int power, int startIndex)
        {
            if (number == 1) return true;
            if (power == 1) return false;
            if (Math.Abs(number) < Math.Abs(power)) return false;
            if (number == power) return true;
            else return PowerOf(number, power * startIndex, startIndex);
        }
    }
}
