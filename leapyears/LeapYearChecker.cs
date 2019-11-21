using System;

namespace leapyears
{
    public class LeapYearChecker
    {
        public bool? IsLeapYear(int year)
        {
            return IsYearTypicalLeapYear(year) && 
                   IsYearUntypicalCommonYear(year);
        }

        private static bool IsYearTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }

        private static bool IsYearUntypicalCommonYear(int year)
        {
            return !IsTypicalCentury(year) || 
                   IsYearUntypicalCentury(year);
        }

        private static bool IsYearUntypicalCentury(int year)
        {
            return year % 400 == 0;
        }

        private static bool IsTypicalCentury(int year)
        {
            return year % 100 == 0;
        }
    }
}
