using System;

namespace leapyears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap Year Checker!");

            var checker = new LeapYearChecker();

            //Console.WriteLine($"{1875} is {(checker.IsLeapYear(1875) ? "" : "not")} a leap year. ");
            //Console.WriteLine($"{1876} is {(checker.IsLeapYear(1876) ? "" : "not")} a leap year. ");
            //Console.WriteLine($"{2000} is {(checker.IsLeapYear(2000) ? "" : "not")} a leap year. ");
            //Console.WriteLine($"{1900} is {(checker.IsLeapYear(1900) ? "" : "not")} a leap year. ");
        }
    }
}
