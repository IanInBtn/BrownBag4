namespace leapyears
{
    public class LeapYearChecker
    {
        public bool? IsLeapYear(int year)
        {
            return IsTypicalLeapYear(year) &&
                   !IsExceptionToLeapYear(year);
        }

        private static bool IsExceptionToLeapYear(int year)
        {
            return IsCenturyYear(year) && 
                   !IsExceptionalCenturyYear(year);
        }

        private static bool IsTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }

        private static bool IsCenturyYear(int year)
        {
            return year % 100 == 0;
        }

        private static bool IsExceptionalCenturyYear(int year)
        {
            return year % 400 == 0;
        }
    }
}
