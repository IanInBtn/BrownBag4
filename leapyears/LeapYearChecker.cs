using System;

namespace leapyears
{
    public class LeapYearChecker
    {
        public bool? IsLeapYear(int year)
        {
            return IsYearUntypicalCommonYear(year) && 
                   IsYearTypicalLeapYear(year);
        }

        private static bool IsYearTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }

        private static bool IsYearUntypicalCommonYear(int year)
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            return true;
        }
    }
}
