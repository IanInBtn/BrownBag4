using NUnit.Framework;

namespace leapyears.test
{
    [TestFixture]
    public class Tests
    {
        private LeapYearChecker LeapYearChecker { get; set; }

        [SetUp]
        public void Setup()
        {
            LeapYearChecker = new LeapYearChecker();
        }

        [TestCase(1200)]
        [TestCase(1996)]
        [TestCase(2000)]
        [TestCase(2004)]
        public void IsNormalLeapYear(int year)
        {
            Assert.IsTrue(LeapYearChecker.IsLeapYear(year));
        }

        [TestCase(1)]
        [TestCase(1000)]
        [TestCase(1998)]
        [TestCase(2001)]
        public void IsRegularYear(int year)
        {
            Assert.IsFalse(LeapYearChecker.IsLeapYear(year));
        }

        [TestCase(1700)]
        [TestCase(1900)]
        [TestCase(2100)]
        [TestCase(3000)]
        public void IsUntypicalRegularYear(int year)
        {
            Assert.IsFalse(LeapYearChecker.IsLeapYear(year));
        }

        [TestCase(0)]
        [TestCase(800)]
        [TestCase(1600)]
        [TestCase(2000)]
        public void IsUntypicalLeapYear(int year)
        {
            Assert.IsTrue(LeapYearChecker.IsLeapYear(year));
        }
    }
}