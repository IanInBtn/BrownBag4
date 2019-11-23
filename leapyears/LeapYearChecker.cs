namespace leapyears
{
    public class LeapYearChecker
    {
        public bool? IsLeapYear(int year) => 
            IsTypicalLeapYear(year) && !IsExceptionToLeapYear(year);

        private static bool IsExceptionToLeapYear(int year) =>
            IsCenturyYear(year) && !IsExceptionalCenturyYear(year);

        private static bool IsTypicalLeapYear(int year) => year % 4 == 0;

        private static bool IsCenturyYear(int year) => year % 100 == 0;

        private static bool IsExceptionalCenturyYear(int year) => year % 400 == 0;
    }
}
