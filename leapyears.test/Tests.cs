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
        public void Test1()
        {
        }
    }
}