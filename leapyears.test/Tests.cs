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
        public void IsUntypicalLeapYear()
        {
            Assert.IsTrue(LeapYearChecker.IsLeapYear(2000));
        }

        [Test]
        public void IsCommonYear()
        {
            Assert.IsFalse(LeapYearChecker.IsLeapYear(2001));
        }

        [Test]
        public void IsUnTypicalCommonYear()
        {
            Assert.IsFalse(LeapYearChecker.IsLeapYear(1900));
        }
    }
}