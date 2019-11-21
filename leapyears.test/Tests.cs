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

        [Test]
        public void IsNormalLeapYear()
        {
            Assert.IsTrue(LeapYearChecker.IsLeapYear(1996));
        }

        [Test]
        public void IsRegularYear()
        {
            Assert.IsFalse(LeapYearChecker.IsLeapYear(2001));
        }

        [Test]
        public void IsUntypicalRegularYear()
        {
            Assert.IsFalse(LeapYearChecker.IsLeapYear(1900));
        }

        [Test]
        public void IsUntypicalLeapYear()
        {
            Assert.IsTrue(LeapYearChecker.IsLeapYear(2000));
        }
    }
}