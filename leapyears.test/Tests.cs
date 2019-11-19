using NUnit.Framework;

namespace leapyears.test
{
    public class Tests
    {
        private LeapYearChecker LeapYearChecker { get; set; }

        [SetUp]
        public void Setup()
        {
            LeapYearChecker = new LeapYearChecker();
        }

        [Test]
        public void IsNormalLeapYear()
        {
            Assert.IsTrue(LeapYearChecker.IsLeapYear(1996));
        }
    }
}