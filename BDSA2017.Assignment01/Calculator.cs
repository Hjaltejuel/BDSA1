using System;
using System.Globalization;


namespace BDSA2017.Assignment01
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
            if (number == 1) return true; //Hvis nummeret vi prøver at ramme er 1, så er det altid sandt, idet at et alle tal opløftet i 0 giver 1
            if (power == 1) return false; //Hvis power er 1 efter at vi har fastlået at number ikke er 1 kan den aldrig gå op idet 1 opløftet i alt giver 1
            if (Math.Abs(number) < Math.Abs(power)) return false; // check for at se om vi er gået over number værdien
            if (number == power) return true;//check for at se om vi er nået number værdien
            else return PowerOf(number, power * startIndex, startIndex); //recursivt kald
        }
    }
}
